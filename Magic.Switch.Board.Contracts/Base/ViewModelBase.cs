using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Magic.Switch.Board.Contracts.Base;

/// <summary>
/// The <see cref="ViewModelBase"/> class.
/// </summary>
/// <remarks>
/// Implements the members of the <see cref="INotifyPropertyChanged"/> interface.
/// </remarks>
public class ViewModelBase : INotifyPropertyChanged
{
	/// <inheritdoc/>
	public event PropertyChangedEventHandler? PropertyChanged;

	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="field">The field reference.</param>
	/// <param name="newValue">The value that should be set.</param>
	/// <param name="propertyName">The name of the property.</param>
	/// <returns><see langword="true"/> or <see langword="false"/> if the property has been set.</returns>
	protected bool SetProperty<T>(ref T field, T newValue, [CallerMemberName] string propertyName = null!)
	{
		if (!Equals(field, newValue))
		{
			field = newValue;
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
			return true;
		}
		return false;
	}
}