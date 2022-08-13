using System.Collections;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Magic.Switch.Board.Contracts.Base
{
	/// <summary>
	/// The <see cref="ViewModelBase"/> class, should be inherited by every view model because it 
	/// implements the following interfaces: <see cref="INotifyPropertyChanged"/>, <see cref="INotifyDataErrorInfo"/>
	/// </summary>
	public abstract class ViewModelBase : INotifyPropertyChanged, INotifyDataErrorInfo
	{
		/// <summary>
		/// The <see cref="ViewModelBase"/> constructor
		/// </summary>
		public ViewModelBase()
		{
			Errors = new Dictionary<string, IList<object>>();
			ValidatedAttributedProperties = new HashSet<string>();
		}

		/// <summary>
		/// The <see cref="SetProperty{T}(T, T, string, bool)"/> method takes control of the property value setting.
		/// </summary>
		/// <remarks>
		/// 
		/// </remarks>
		/// <typeparam name="T"></typeparam>
		/// <param name="field"></param>
		/// <param name="newValue"></param>
		/// <param name="propertyName">The name of the property.</param>
		/// <param name="validate">Should the property be validated before setting?</param>
		/// <returns>Returns 'true' if the property has been set.</returns>
		public bool SetProperty<T>(T field, T newValue, [CallerMemberName] string propertyName = default!, bool validate = false)
		{
			if (!Equals(field, newValue))
			{
				if (validate)
				{
					if (!IsPropertyValid(propertyName))
						return false;
				}
				field = newValue;
				OnPropertyChanged();
				return true;
			}
			return false;
		}

		/// <summary>
		/// Validate property using decorating attributes. 
		/// </summary>
		/// <typeparam name="TValue"></typeparam>
		/// <param name="value"></param>
		/// <param name="propertyName">The name of the property.</param>
		/// <returns>Returns 'true' if the property attribute is valid.</returns>
		private bool IsAttributedPropertyValid<TValue>(TValue value, string propertyName)
		{
			ValidatedAttributedProperties.Add(propertyName);

			// The result flag
			bool isValueValid = true;

			// Check if property is decorated with validation attributes
			// using reflection
			IEnumerable<Attribute> validationAttributes = GetType()
				.GetProperty(propertyName, BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static)
				?.GetCustomAttributes(typeof(ValidationAttribute)) ?? new List<Attribute>();

			// Validate using attributes if present
			if (validationAttributes.Any())
			{
				ValidationContext validationContext = new(this, null, null) { MemberName = propertyName };
				List<ValidationResult> validationResults = new();
				if (!Validator.TryValidateProperty(value, validationContext, validationResults))
				{
					isValueValid = false;
					AddErrorRange(propertyName, validationResults.Select(attributeValidationResult => attributeValidationResult.ErrorMessage!));
				}
			}
			return isValueValid;
		}

		/// <summary>
		/// Checks if a property is valid or not. Can take additional checks with error messages.
		/// </summary>
		/// <remarks>
		/// Also checks the attributes with the <see cref="IsAttributedPropertyValid{TValue}(TValue, string)"/> method.
		/// </remarks>
		/// <typeparam name="TValue"></typeparam>
		/// <param name="value"></param>
		/// <param name="validationDelegate"></param>
		/// <param name="propertyName">The name of the property.</param>
		/// <returns>Returns 'true' if the property is valid.</returns>
		public bool IsPropertyValid<TValue>(
			TValue value,
			Func<TValue, (bool IsValid, IEnumerable<object> ErrorMessages)> validationDelegate = default!,
			[CallerMemberName] string propertyName = default!)
		{
			// Clear previous errors of the current property to be validated
			ClearErrors(propertyName);

			// Validate using the delegate
			(bool IsValid, IEnumerable<object> ErrorMessages) = validationDelegate?.Invoke(value) ?? (true, Enumerable.Empty<object>());

			// Store the error messages of the failed validation
			if (!IsValid)
				AddErrorRange(propertyName, ErrorMessages);

			bool isAttributedPropertyValid = IsAttributedPropertyValid(value, propertyName);
			return isAttributedPropertyValid && IsValid;
		}

		/// <summary>
		/// Removes all errors of the specified property. 
		/// </summary>
		/// <remarks>
		/// Raises the ErrorsChanged event if the Errors collection changes.
		/// </remarks>
		/// <param name="propertyName">The name of the property.</param>
		/// <returns>Returns 'true' if the error for the property is removed.</returns>
		public bool ClearErrors(string propertyName)
		{
			ValidatedAttributedProperties.Remove(propertyName);
			if (Errors.Remove(propertyName))
			{
				OnErrorsChanged(propertyName);
				return true;
			}
			return false;
		}

		/// <summary>
		/// Adds the specified errors to the errors collection if it is not already
		/// present, inserting it in the first position if 'isWarning' is false.
		/// </summary>
		/// <remarks>
		/// Raises the ErrorsChanged event if the Errors collection changes.		
		/// A property can have multiple errors.
		/// </remarks>
		/// <param name="propertyName"></param>
		/// <param name="newErrors"></param>
		/// <param name="isWarning"></param>
		private void AddErrorRange(string propertyName, IEnumerable<object> newErrors, bool isWarning = false)
		{
			if (!newErrors.Any())
				return;

			if (!Errors.TryGetValue(propertyName, out IList<object>? propertyErrors))
			{
				propertyErrors = new List<object>();
				Errors.Add(propertyName, propertyErrors);
			}

			if (isWarning)
				foreach (object error in newErrors)
					propertyErrors.Add(error);
			else
				foreach (object error in newErrors)
					propertyErrors.Insert(0, error);

			OnErrorsChanged(propertyName);
		}

		/// <summary>
		/// Optional method to check if a certain property has validation errors.
		/// </summary>
		/// <param name="propertyName">The name of the property.</param>
		/// <returns>Returns 'true' if the property has any errors.</returns>
		public bool PropertyHasErrors(string propertyName) =>
			Errors.TryGetValue(propertyName, out IList<object>? propertyErrors) && propertyErrors.Any();

		/// <inheritdoc/>
		public event PropertyChangedEventHandler? PropertyChanged;

		/// <summary>
		/// The <see cref="OnPropertyChanged(string)"/> method is called by the Set accessor of each property.
		/// The CallerMemberName attribute that is applied to the optional propertyName parameter causes the
		/// property name of the caller to be substituted as an argument.
		/// </summary>
		/// <remarks>
		/// Should be called after each set of a property.
		/// </remarks>
		/// <param name="propertyName">Should be set automatically via the <see cref="CallerMemberNameAttribute"/>.</param>
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = default!) =>
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

		/// <inheritdoc/>
		public bool HasErrors => Errors.Any();

		/// <inheritdoc/>
		public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;

		/// <inheritdoc/>
		/// <remarks>
		/// This implementation of GetErrors returns all errors of the specified property.
		/// If the argument is 'null' instead of the property's name, then the method will
		/// return all errors of all properties. This method is called by the WPF binding 
		/// engine when ErrorsChanged event was raised and HasErrors retirn true
		/// </remarks>
		public IEnumerable GetErrors(string? propertyName) =>
			string.IsNullOrWhiteSpace(propertyName)
			? Errors.SelectMany(entry => entry.Value)
			: Errors.TryGetValue(propertyName, out IList<object>? errors)
				? (IEnumerable<object>)errors
				: new List<object>();

		/// <summary>
		/// The <see cref="OnErrorsChanged(string)"/> method is called by the Set accessor of each property.
		/// The CallerMemberName attribute that is applied to the optional propertyName parameter causes the
		/// property name of the caller to be substituted as an argument.
		/// </summary>
		/// <remarks>
		/// Should be called before each set of a property.
		/// </remarks>
		/// <param name="propertyName">Should be set automatically via the <see cref="CallerMemberNameAttribute"/>.</param>
		protected virtual void OnErrorsChanged([CallerMemberName] string propertyName = default!) =>
			ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));

		/// <summary>
		/// Maps a property name to a list of errors that belong to this property.
		/// </summary>
		private Dictionary<string, IList<object>> Errors { get; }

		/// <summary>
		/// Track attribute validation calls.
		/// </summary>
		private HashSet<string> ValidatedAttributedProperties { get; }
	}
}