using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Magic.Switch.Board.ViewModels.Base;

/// <summary>
/// The <see cref="ViewModelBase"/> class.
/// </summary>
/// <remarks>
/// Implements the members of the <see cref="INotifyPropertyChanged"/> interface.
/// Implements the members of the <see cref="INotifyPropertyChanging"/> interface.
/// </remarks>
public class ViewModelBase : INotifyPropertyChanged, INotifyPropertyChanging
{
	/// <inheritdoc/>
	public event PropertyChangedEventHandler? PropertyChanged;
	/// <inheritdoc/>
	public event PropertyChangingEventHandler? PropertyChanging;

	/// <summary>
	/// The <see cref="SetProperty{T}(ref T, T, string)"/> method should update the property.
	/// </summary>
	/// <remarks>
	/// If the property value is a different value than the one to be set, the new value is set.
	/// </remarks>
	/// <typeparam name="T"></typeparam>
	/// <param name="field">The field reference.</param>
	/// <param name="newValue">The value that should be set.</param>
	/// <param name="propertyName">The name of the property.</param>
	/// <returns><see langword="true"/> or <see langword="false"/> if the property has been set.</returns>
	protected bool SetProperty<T>(ref T field, T newValue, [CallerMemberName] string? propertyName = null)
	{
		if (!Equals(field, newValue))
		{
			PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(propertyName));
			field = newValue;
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
			return true;
		}
		return false;
	}
}