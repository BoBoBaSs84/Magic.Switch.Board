using System.ComponentModel;
using System.Dynamic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace Magic.Switch.Board.ViewModels.Base;

/// <summary>
/// The <see langword="abstract"/> <see cref="ViewModelBase"/> class.
/// </summary>
/// <remarks>
/// Implements the members of the <see cref="INotifyPropertyChanged"/> interface
/// and the members of the <see cref="INotifyPropertyChanging"/> interface.
/// </remarks>
public abstract class ViewModelBase : INotifyPropertyChanged, INotifyPropertyChanging
{
	#region Constructor
	/// <summary>
	/// Initializes a new instance of the <see cref="ViewModelBase"/> class.
	/// </summary>
	public ViewModelBase() => InitializeCommands();
	#endregion Constructor

	#region Common view properties
	/// <summary>
	/// Gets or sets the display name of this object. Derived classes can set this property to a
	/// new value, or override it to determine the value on-demand.
	/// </summary>
	public virtual string DisplayName
	{
		get => GetProperty<string>();
		set => SetProperty(value);
	}

	/// <summary>
	/// Called when the <see cref="DisplayName"/> property on this object has a new value.
	/// </summary>
	[PropertyChangedHandler(nameof(DisplayName))]
	protected virtual void OnDisplayNameChanged()
	{
		if (DisplayNameSetsModified)
		{
			IsModified = true;
		}
	}

	/// <summary>
	/// Gets or sets a value indicating whether changes to the <see cref="DisplayName"/>
	/// property set <see cref="IsModified"/> to true as if it had the
	/// <see cref="SetsModifiedAttribute"/> set.
	/// </summary>
	protected bool DisplayNameSetsModified { get; set; }

	/// <summary>
	/// Gets or sets a value indicating whether the data in the current instance was modified
	/// after it was loaded from its source.
	/// </summary>
	public virtual bool IsModified
	{
		get => GetProperty<bool>();
		set => SetProperty(value);
	}
	#endregion

	#region Attributes
	/// <summary>
	/// Declares that a property that depends on another property should raise a notification when
	/// the independent property is raising a notification.
	/// </summary>
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
	public class NotifiesOnAttribute : Attribute
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="NotifiesOnAttribute"/> class.
		/// </summary>
		/// <param name="propertyName">The name of the independent property.</param>
		/// <exception cref="ArgumentNullException"><paramref name="propertyName"/> is null.</exception>
		public NotifiesOnAttribute(string propertyName) =>
			Name = propertyName ?? throw new ArgumentNullException(nameof(propertyName));

		/// <summary>
		/// Gets the name of the independent property.
		/// </summary>
		public string Name { get; private set; }

		/// <summary>
		/// A unique identifier for this attribute.
		/// </summary>
		public override object TypeId => this;
	}

	/// <summary>
	/// Declares that a method is invoked when the specified property is changed, before the
	/// notification event.
	/// </summary>
	[AttributeUsage(AttributeTargets.Method)]
	public class PropertyChangedHandlerAttribute : Attribute
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="PropertyChangedHandlerAttribute"/> class.
		/// </summary>
		/// <param name="propertyName">The name of the property.</param>
		/// <exception cref="ArgumentNullException"><paramref name="propertyName"/> is null.</exception>
		public PropertyChangedHandlerAttribute(string propertyName) =>
			Name = propertyName ?? throw new ArgumentNullException(nameof(propertyName));

		/// <summary>
		/// Gets the name of the independent property.
		/// </summary>
		public string Name { get; private set; }
	}

	/// <summary>
	/// Declares that <see cref="ViewModelBase.IsModified"/> is set to true when the value of a
	/// property is changed.
	/// </summary>
	[AttributeUsage(AttributeTargets.Property)]
	public class SetsModifiedAttribute : Attribute
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="SetsModifiedAttribute"/> class.
		/// </summary>
		public SetsModifiedAttribute()
		{
		}
	}
	#endregion

	#region Commands support
	/// <summary>
	/// Initializes the commands in the ViewModel class.
	/// </summary>
	protected virtual void InitializeCommands()
	{
	}
	#endregion

	#region Property access methods
	/// <summary>
	/// Stores the values for each property in the current object.
	/// </summary>
	private readonly Dictionary<string, object> backingFields = new();

	/// <summary>
	/// Gets the current value of a property.
	/// </summary>
	/// <typeparam name="T">The property type.</typeparam>
	/// <param name="propertyName">The property name.</param>
	/// <returns>The current value.</returns>
	/// <exception cref="ArgumentNullException"></exception>
	protected T GetProperty<T>([CallerMemberName] string? propertyName = null) =>
		propertyName is null ? throw new ArgumentNullException(nameof(propertyName))
		: backingFields.TryGetValue(propertyName, out object? value) ? (T)value : default!;

	/// <summary>
	/// Sets a new value for a property and notifies about the change.
	/// </summary>
	/// <typeparam name="T">The property type.</typeparam>
	/// <param name="newValue">The new value for the property.</param>
	/// <param name="propertyName">The property name.</param>
	/// <remarks>
	/// The order of actions is defined as the following:
	/// <list type="number">
	///		<item>Call the <see cref="OnPropertyChanging(string?)"/> method.</item>
	///		<item>Raise the <see cref="PropertyChanging"/> event for the property.</item>
	///   <item>Change property value, accessible through <see cref="GetProperty{T}(string?)"/></item>
	///   <item>Call the <see cref="OnPropertyChanged(string?)"/> method.</item>
	///   <item>Raise <see cref="PropertyChanged"/> event for the property.</item>
	/// </list>
	/// If code must be executed before the first event is raised, the <see cref="OnPropertyChanging(string?)"/> method is the recommended 
	/// place for that. This keeps the property setter clean and allows using the default notification method.
	/// </remarks>
	/// <returns><see langword="true"/> or <see langword="false"/> if the property has been set.</returns>
	protected bool SetProperty<T>(T newValue, [CallerMemberName] string? propertyName = null)
	{
		if (propertyName is null) throw new ArgumentNullException(nameof(propertyName));

		if (EqualityComparer<T>.Default.Equals(newValue, GetProperty<T>(propertyName)))
			return false;

		OnPropertyChanging(propertyName);
		backingFields[propertyName] = newValue!;
		OnPropertyChanged(propertyName);
		return true;
	}

	/// <summary>
	/// Sets a new value for a property and notifies about the change.
	/// </summary>
	/// <typeparam name="T">The property type.</typeparam>
	/// <param name="newValue">The new value for the property.</param>
	/// <param name="propertyName">The property name.</param>
	/// <param name="additionalPropertyNames">Names of additional properties that must be notified when the value has changed.</param>
	/// <remarks>
	/// The order of actions is defined as the following:
	/// <list type="number">
	///		<item>Call the <see cref="OnPropertyChanging(string?)"/> method.</item>
	///		<item>Raise the <see cref="PropertyChanging"/> event for the property.</item>
	///   <item>Change property value, accessible through <see cref="GetProperty{T}(string?)"/></item>
	///   <item>Call the <see cref="OnPropertyChanged(string?)"/> method.</item>
	///   <item>Raise <see cref="PropertyChanged"/> event for the property.</item>
	/// </list>
	/// If code must be executed before the first event is raised, the <see cref="OnPropertyChanging(string?)"/> method is the recommended 
	/// place for that. This keeps the property setter clean and allows using the default notification method.
	/// </remarks>
	/// <returns><see langword="true"/> or <see langword="false"/> if the property has been set.</returns>
	protected bool SetProperty<T>(T newValue, [CallerMemberName] string? propertyName = null, params string[] additionalPropertyNames)
	{
		if (SetProperty(newValue, propertyName))
		{
			OnPropertyChanged(additionalPropertyNames);
			return true;
		}
		return false;
	}

	/// <summary>
	/// Sets a new value for a property, but does not notify about the change.
	/// </summary>
	/// <typeparam name="T">The property type.</typeparam>
	/// <param name="newValue">The new value for the property.</param>
	/// <param name="propertyName">The property name.</param>
	/// <remarks>
	/// <para>
	/// This method does not call On…Changed methods and does not raise the
	/// <see cref="PropertyChanged"/> event for the indicated or any dependent properties.
	/// </para>
	/// <para>
	/// If you need to use this method to execute other code before the
	/// <see cref="PropertyChanged"/> event may be raised for the property, and then call
	/// <see cref="OnPropertyChanged(string?)"/> manually afterwards, you should consider moving this
	/// pre-processing code out of the property setter into a separate On…Changed method
	/// marked with the <see cref="PropertyChangedHandlerAttribute"/> and call the regular
	/// <see cref="SetProperty{T}(T, string?)"/> method instead.
	/// </para>
	/// </remarks>
	/// <returns><see langword="true"/> or <see langword="false"/> if the property has been set.</returns>
	protected bool SetPropertySuppressNotify<T>(T newValue, [CallerMemberName] string? propertyName = null)
	{
		if (propertyName is null) throw new ArgumentNullException(nameof(propertyName));
		if (EqualityComparer<T>.Default.Equals(newValue, GetProperty<T>(propertyName)))
			return false;

		backingFields[propertyName] = newValue!;
		return true;
	}
	#endregion

	#region View state
	private readonly ExpandoObject viewState = new();

	/// <summary>
	/// Gets a dynamic object that can be used by the view to save its view state.
	/// </summary>
	public dynamic ViewState => viewState;

	/// <summary>
	/// Gets a value indicating whether the view state is not empty.
	/// </summary>
	protected bool HasViewState => ((IDictionary<string, object>)ViewState).Count > 0;

	/// <summary>
	/// Clears all data from the view state.
	/// </summary>
	protected void ClearViewState() => ((IDictionary<string, object>)ViewState).Clear();
	#endregion

	#region INotifyPropertyChanged members
	/// <inheritdoc/>
	public event PropertyChangedEventHandler? PropertyChanged;

	/// <summary>
	/// The <see cref="OnPropertyChanged(string?)"/> method to raise the changed event.
	/// </summary>
	/// <remarks>
	/// The calling member's name will be used as the parameter.
	/// </remarks>
	/// <param name="propertyName">The name of the property, can be <see langword="null"/>.</param>
	protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null) =>
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

	/// <summary>
	/// Raises this object's PropertyChanged event for multiple properties and all their dependent properties.
	/// </summary>
	/// <param name="propertyNames">The names of the properties that have a new value.</param>
	protected virtual void OnPropertyChanged(params string[] propertyNames)
	{
		foreach (string propertyName in propertyNames)
			OnPropertyChanged(propertyName);
	}

	/// <summary>
	/// Raises this object's PropertyChanged event.
	/// </summary>
	/// <typeparam name="TProperty">Value type of the property.</typeparam>
	/// <param name="selectorExpression">A lambda expression that describes the property that has a new value.</param>
	protected void OnPropertyChanged<TProperty>(Expression<Func<TProperty>> selectorExpression)
	{
		// This type of parameter can only be used with the params keyword if all passed
		// member expressions have the same value type. When using object instead of the
		// TProperty type parameter, the expression gets wrapped with some Convert method and
		// is no longer a MemberExpression. So this only works for one property per method call.

		// Only do all this work if somebody might listen to it
		if (PropertyChanged is null)
			return;

		if (selectorExpression is null)
			throw new ArgumentNullException(nameof(selectorExpression));

		if (selectorExpression.Body is not MemberExpression body)
			throw new ArgumentException("The body must be a member expression");

		OnPropertyChanged(body.Member.Name);
	}
	#endregion

	/// <inheritdoc/>
	public event PropertyChangingEventHandler? PropertyChanging;

	/// <summary>
	/// The <see cref="OnPropertyChanging(string?)"/> method to raise the changing event.
	/// </summary>
	/// <remarks>
	/// The calling member's name will be used as the parameter.
	/// </remarks>
	/// <param name="propertyName">The name of the property, can be <see langword="null"/>.</param>
	protected virtual void OnPropertyChanging([CallerMemberName] string? propertyName = null) =>
		PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(propertyName));
}

/// <summary>
/// The <see langword="abstract"/> <see cref="ViewModelBase{TModel}"/> class.
/// </summary>
/// <typeparam name="TModel"></typeparam>
public abstract class ViewModelBase<TModel> : ViewModelBase where TModel : class
{
	/// <summary>
	/// The <see cref="ViewModelBase{TModel}"/> class constructor.
	/// </summary>
	/// <param name="model"></param>
	public ViewModelBase(TModel model) => SetProperty(model);

	/// <summary>
	/// The <see cref="Model"/> property.
	/// </summary>
	public TModel Model
	{
		get => GetProperty<TModel>();
		set => SetProperty(value);
	}
}