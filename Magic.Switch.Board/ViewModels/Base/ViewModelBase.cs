using System.Collections;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Magic.Switch.Board.ViewModels.Base;

/// <summary>
/// The <see langword="abstract"/> <see cref="ViewModelBase"/> base class.
/// </summary>
/// <remarks>
/// The <see cref="ViewModelBase"/> class implements the following interfaces:
/// <list type="bullet">
///		<item>The members of the <see cref="INotifyPropertyChanged"/> interface.</item>
///		<item>The members of the <see cref="INotifyPropertyChanging"/> interface.</item>
/// </list>
/// </remarks>
public abstract class ViewModelBase : INotifyPropertyChanged, INotifyPropertyChanging
{
	#region Property access methods
	/// <summary>
	/// Sets a new value for a property and notifies about the change.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="field">The referenced field.</param>
	/// <param name="newValue">The new value for the property.</param>
	/// <param name="propertyName">The property name.</param>
	/// <exception cref="ArgumentNullException">If <paramref name="propertyName"/> is null.</exception>
	protected void SetProperty<T>(ref T field, T newValue, [CallerMemberName] string? propertyName = null)
	{
		if (propertyName is null)
			throw new ArgumentNullException(nameof(propertyName));

		if (!Equals(field, newValue))
		{
			RaisePropertyChanging(propertyName);
			field = newValue;
			RaisePropertyChanged(propertyName);
		}
	}

	/// <summary>
	/// Sets a new value for a property and does not notify about the change.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="field">The referenced field.</param>
	/// <param name="newValue">The new value for the property.</param>
	/// <param name="propertyName">The property name.</param>
	/// <returns><see langword="true"/> or <see langword="false"/> if the property has been set.</returns>
	/// <exception cref="ArgumentNullException">If <paramref name="propertyName"/> is null.</exception>
	protected static void SetPropertyNoNotify<T>(ref T field, T newValue, [CallerMemberName] string? propertyName = null)
	{
		if (propertyName is null)
			throw new ArgumentNullException(nameof(propertyName));

		if (!Equals(field, newValue))
			field = newValue;
	}
	#endregion

	#region INotifyPropertyChanged members
	/// <inheritdoc/>
	public event PropertyChangedEventHandler? PropertyChanged;

	/// <summary>
	/// The <see cref="RaisePropertyChanged(string?)"/> method to raise the changed event.
	/// </summary>
	/// <remarks>
	/// The calling member's name will be used as the parameter.
	/// </remarks>
	/// <param name="propertyName">The name of the property, can be <see langword="null"/>.</param>
	protected virtual void RaisePropertyChanged([CallerMemberName] string? propertyName = null) =>
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	#endregion

	#region INotifyPropertyChanging members
	/// <inheritdoc/>
	public event PropertyChangingEventHandler? PropertyChanging;

	/// <summary>
	/// The <see cref="RaisePropertyChanging(string?)"/> method to raise the changing event.
	/// </summary>
	/// <remarks>
	/// The calling member's name will be used as the parameter.
	/// </remarks>
	/// <param name="propertyName">The name of the property, can be <see langword="null"/>.</param>
	protected virtual void RaisePropertyChanging([CallerMemberName] string? propertyName = null) =>
		PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(propertyName));
	#endregion
}

/// <summary>
/// The <see langword="abstract"/> <see cref="ViewModelBase{TModel}"/> class.
/// </summary>
/// <remarks>
/// The <see cref="ViewModelBase{TModel}"/> class implements the following interfaces:
/// <list type="bullet">
///		<item>The members of the <see cref="INotifyDataErrorInfo"/> interface.</item>
/// </list>
/// </remarks>
/// <typeparam name="TModel">The domain model class.</typeparam>
public abstract class ViewModelBase<TModel> : ViewModelBase, INotifyDataErrorInfo where TModel : class
{
	private TModel model;

	/// <summary>
	/// Initializes a new instance of the <see cref="ViewModelBase{TModel}"/> class.
	/// </summary>
	/// <param name="model">The domain model class.</param>
	protected ViewModelBase(TModel model) => this.model = model;

	/// <summary>
	/// The <see cref="Model"/> property.
	/// </summary>
	public TModel Model
	{
		get => model;
		private set => SetProperty(ref model, value);
	}

	/// <summary>
	/// The <see cref="OnPropertyChangedPropagate(object?, PropertyChangedEventArgs)"/> method
	/// propagates the changes in the view model through to the domain model.
	/// </summary>
	/// <remarks>
	/// The method can only / should be called from the derived class.
	/// </remarks>
	/// <param name="sender">The sender will/should be <see cref="ViewModelBase{TModel}"/>.</param>
	/// <param name="e"></param>
	protected virtual void OnPropertyChangedPropagate(object? sender, PropertyChangedEventArgs e)
	{
		if (sender is not ViewModelBase<TModel> modelBase)
			return;

		if (e.PropertyName is not null)
		{
			object? propertyValue = modelBase.GetType().GetProperty(e.PropertyName)!.GetValue(modelBase, null);
			modelBase.Model.GetType().GetProperty(e.PropertyName)!.SetValue(modelBase.Model, propertyValue, null);
		}
	}

	#region Property access methods
	/// <summary>
	/// Sets a new value for a property, notifies about the change and tries to
	/// validate the property against the domain model class.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="field">The referenced field.</param>
	/// <param name="newValue">The new value for the property.</param>
	/// <param name="propertyName">The property name.</param>
	/// <exception cref="ArgumentNullException">If <paramref name="propertyName"/> is null.</exception>
	protected void SetPropertyAndValidate<T>(ref T field, T newValue, [CallerMemberName] string? propertyName = null)
	{
		if (propertyName is null)
			throw new ArgumentNullException(nameof(propertyName));

		if (!Equals(field, newValue))
		{
			SetProperty(ref field, newValue, propertyName);
			Validate(newValue, propertyName);
		}
	}

	/// <summary>
	/// Sets a new value for a property, does not notify about the changeand tries to
	/// validate the property against the domain model class.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="field">The referenced field.</param>
	/// <param name="newValue">The new value for the property.</param>
	/// <param name="propertyName">The property name.</param>
	/// <returns><see langword="true"/> or <see langword="false"/> if the property has been set.</returns>
	/// <exception cref="ArgumentNullException">If <paramref name="propertyName"/> is null.</exception>
	protected void SetPropertyNoNotifyAndValidate<T>(ref T field, T newValue, [CallerMemberName] string? propertyName = null)
	{
		if (propertyName is null)
			throw new ArgumentNullException(nameof(propertyName));

		if (!Equals(field, newValue))
		{
			field = newValue;
			Validate(newValue, propertyName);
		}
	}
	#endregion

	#region INotifyDataErrorInfo members
	/// <summary>
	/// The dictonary contains the errors for each property.
	/// </summary>
	private readonly Dictionary<string, List<string>> _propertyErrors = new();

	/// <inheritdoc/>
	public bool HasErrors => _propertyErrors.Any();

	/// <inheritdoc/>
	public event EventHandler<DataErrorsChangedEventArgs>? ErrorsChanged;

	/// <inheritdoc/>
	public IEnumerable GetErrors(string? propertyName) =>
		_propertyErrors.ContainsKey(propertyName!) ? _propertyErrors[propertyName!] : null!;

	/// <summary>
	/// The <see cref="RaiseErrorsChanged(string?)"/> method to raise the erros changed event.
	/// </summary>
	/// <remarks>
	/// The calling member's name will be used as the parameter.
	/// </remarks>
	/// <param name="propertyName">The property name.</param>
	protected virtual void RaiseErrorsChanged([CallerMemberName] string? propertyName = null) =>
		ErrorsChanged?.Invoke(this, new DataErrorsChangedEventArgs(propertyName));

	/// <summary>
	/// The <see cref="Validate{T}(T, string)"/> method will try to validate the property value.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="value">The value of the property.</param>
	/// <param name="propertyName">The property name.</param>
	protected void Validate<T>(T value, string propertyName)
	{
		ValidationContext context = new(Model) { MemberName = propertyName };
		List<ValidationResult> results = new();

		ClearErrors(propertyName);

		if (!Validator.TryValidateProperty(value, context, results))
		{
			foreach (ValidationResult error in results)
				AddError(propertyName, error.ErrorMessage!);
		}
	}

	/// <summary>
	/// The <see cref="AddError(string, string)"/> method will add an error message for the property.
	/// </summary>
	/// <param name="propertyName">The property name.</param>
	/// <param name="errorMessage">The error message.</param>
	private void AddError(string propertyName, string errorMessage)
	{
		if (!_propertyErrors.ContainsKey(propertyName))
			_propertyErrors[propertyName] = new List<string>();

		if (!_propertyErrors[propertyName].Contains(errorMessage))
		{
			_propertyErrors[propertyName].Add(errorMessage);
			RaiseErrorsChanged(propertyName);
		}
	}

	/// <summary>
	/// The <see cref="ClearErrors(string)"/> method will clear all errors for the property.
	/// </summary>
	/// <param name="propertyName">The property name.</param>
	private void ClearErrors(string propertyName)
	{
		if (_propertyErrors.ContainsKey(propertyName))
		{
			_ = _propertyErrors.Remove(propertyName);
			RaiseErrorsChanged(propertyName);
		}
	}
	#endregion
}