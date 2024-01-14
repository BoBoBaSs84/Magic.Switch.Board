using System.Collections;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Magic.Switch.Board.UI.Logic.BaseTypes;

/// <summary>
/// The <see langword="abstract"/> <see cref="ViewModelBase"/> base class.
/// </summary>
/// <remarks>
/// The <see cref="ViewModelBase"/> class implements the following interfaces:
/// <list type="bullet">
///		<item>The members of the <see cref="INotifyPropertyChanged"/> interface.</item>
///		<item>The members of the <see cref="INotifyPropertyChanging"/> interface.</item>
/// </list>
/// The class also provides attributes for decorating properties, in turn informing other
/// properties of their value changes. See <see cref="NotifyPropertyChangedAttribute"/>.
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
			NotifyAttributeChangingProperty(propertyName);
			field = newValue;
			RaisePropertyChanged(propertyName);
			NotifyAttributeChangedProperty(propertyName);
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

	#region Notify property attributes
	/// <summary>
	/// The <see cref="NotifyPropertyChangedAttribute"/> class.
	/// </summary>
	/// <remarks>
	/// A property decorated with this attribute propagates its change to the property defined in the attribute.
	/// </remarks>
	[AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
	public sealed class NotifyPropertyChangedAttribute : Attribute
	{
		private string _propertyName = string.Empty;

		/// <summary>
		/// Initializes a new instance of the <see cref="NotifyPropertyChangedAttribute"/> class.
		/// </summary>
		/// <remarks>
		/// Will throw an exception if <paramref name="propertyName"/> is <see langword="null"/> or empty.
		/// </remarks>
		/// <param name="propertyName">The name of the property to notify.</param>
		/// <exception cref="ArgumentException"></exception>
		public NotifyPropertyChangedAttribute(string propertyName)
		{
			if (string.IsNullOrEmpty(propertyName))
				throw new ArgumentException("Can not be null or empty.", nameof(propertyName));

			this._propertyName = propertyName;
		}

		/// <summary>
		/// The <see cref="PropertyName"/> property.
		/// </summary>
		public string PropertyName
		{
			get => _propertyName;
			set
			{
				if (_propertyName != value)
					_propertyName = value;
			}
		}
	}

	/// <summary>
	/// The <see cref="NotifyPropertyChangingAttribute"/> class.
	/// </summary>
	/// <remarks>
	/// A property decorated with this attribute propagates its pending change to the property defined in the attribute.
	/// </remarks>
	[AttributeUsage(AttributeTargets.Property, Inherited = false, AllowMultiple = true)]
	public sealed class NotifyPropertyChangingAttribute : Attribute
	{
		private string _propertyName = string.Empty;

		/// <summary>
		/// Initializes a new instance of the <see cref="NotifyPropertyChangedAttribute"/> class.
		/// </summary>
		/// <remarks>
		/// Will throw an exception if <paramref name="propertyName"/> is <see langword="null"/> or empty.
		/// </remarks>
		/// <param name="propertyName">The name of the property to notify.</param>
		/// <exception cref="ArgumentException"></exception>
		public NotifyPropertyChangingAttribute(string propertyName)
		{
			if (string.IsNullOrEmpty(propertyName))
				throw new ArgumentException("Can not be null or empty.", nameof(propertyName));

			this._propertyName = propertyName;
		}

		/// <summary>
		/// The <see cref="PropertyName"/> property.
		/// </summary>
		public string PropertyName
		{
			get => _propertyName;
			set
			{
				if (_propertyName != value)
					_propertyName = value;
			}
		}
	}
	#endregion

	#region Notify property attribute methods
	/// <summary>
	/// The <see cref="NotifyAttributeChangedProperty(string)"/> method will notify all properties
	/// which have been defined by the <see cref="NotifyPropertyChangedAttribute"/> as to be informed.
	/// </summary>
	/// <param name="propertyName">The property name.</param>
	private void NotifyAttributeChangedProperty(string propertyName)
	{
		PropertyInfo? propertyInfo = GetType().GetProperty(propertyName);
		if (propertyInfo is not null)
		{
			NotifyPropertyChangedAttribute[]? attributes =
				propertyInfo.GetCustomAttributes(typeof(NotifyPropertyChangedAttribute), false) as NotifyPropertyChangedAttribute[];
			if (attributes is not null && attributes.Length > 0)
			{
				foreach (NotifyPropertyChangedAttribute attribute in attributes)
					RaisePropertyChanged(attribute.PropertyName);
			}
		}
	}

	/// <summary>
	/// The <see cref="NotifyAttributeChangingProperty(string)"/> method will notify all properties
	/// which have been defined by the <see cref="NotifyPropertyChangedAttribute"/> as to be informed.
	/// </summary>
	/// <param name="propertyName">The property name.</param>
	private void NotifyAttributeChangingProperty(string propertyName)
	{
		PropertyInfo? propertyInfo = GetType().GetProperty(propertyName);
		if (propertyInfo is not null)
		{
			NotifyPropertyChangingAttribute[]? attributes =
				propertyInfo.GetCustomAttributes(typeof(NotifyPropertyChangingAttribute), false) as NotifyPropertyChangingAttribute[];
			if (attributes is not null && attributes.Length > 0)
			{
				foreach (NotifyPropertyChangingAttribute attribute in attributes)
					RaisePropertyChanged(attribute.PropertyName);
			}
		}
	}
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
/// It inherits the fields and methods from the <see cref="ViewModelBase"/> class.
/// </remarks>
/// <typeparam name="TModel">The domain model class.</typeparam>
public abstract class ViewModelBase<TModel> : ViewModelBase, INotifyDataErrorInfo where TModel : class
{
	private TModel _model;

	/// <summary>
	/// Initializes a new instance of the <see cref="ViewModelBase{TModel}"/> class.
	/// </summary>
	/// <param name="model">The domain model class.</param>
	protected ViewModelBase(TModel model) => this._model = model;

	/// <summary>
	/// The <see cref="Model"/> property.
	/// </summary>
	/// <remarks>
	/// Immutable types are those whose data members can not be changed after the instance is created.
	/// At the first choice of design, for now the property is mutable.
	/// </remarks>
	public TModel Model
	{
		get => _model;
		private set => SetProperty(ref _model, value);
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
		if (sender is not ViewModelBase<TModel> viewModelBase)
			return;

		if (e.PropertyName is not null)
		{
			object? propertyValue = viewModelBase.GetType().GetProperty(e.PropertyName)!.GetValue(viewModelBase, null);
			viewModelBase.Model.GetType().GetProperty(e.PropertyName)!.SetValue(viewModelBase.Model, propertyValue, null);
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
