using System.Windows.Input;

namespace Magic.Switch.Board.UI.Logic.BaseTypes;

/// <summary>
/// The <see cref="RelayCommand"/> class. Implements the mebmer of the <see cref="ICommand"/> interface.
/// </summary>
/// <remarks>
/// A command whose sole purpose is to relay its functionality to other objects by invoking delegates.
/// The default return value for the CanExecute method is <see langword="true"/>.
/// RaiseCanExecuteChanged needs to be called whenever CanExecute is expected to return a different value.
/// </remarks>
public sealed class RelayCommand : ICommand
{
	private readonly Action _execute;
	private readonly Func<bool>? _canExecute;

	/// <inheritdoc/>
	public event EventHandler? CanExecuteChanged;

	/// <summary>
	/// Initializes a new instance of the <see cref="RelayCommand"/> class that can always execute.
	/// </summary>
	/// <param name="execute">The execution logic.</param>
	public RelayCommand(Action execute) : this(execute, null)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="RelayCommand"/> class.
	/// </summary>
	/// <param name="execute">The execution logic.</param>
	/// <param name="canExecute">The execution status logic.</param>
	public RelayCommand(Action execute, Func<bool>? canExecute)
	{
		if (execute is null)
			throw new ArgumentNullException(nameof(execute));
		_execute = execute;
		_canExecute = canExecute;
	}

	#region ICommand members
	/// <summary>
	/// Determines whether this RelayCommand can execute in its current state.
	/// </summary>
	/// <param name="parameter">
	/// Data used by the command. If the command does not require data to be passed,
	/// this object can be set to null.
	/// </param>
	/// <returns>true if this command can be executed; otherwise, false.</returns>
	public bool CanExecute(object? parameter) => _canExecute is null || _canExecute();

	/// <summary>
	/// Executes the RelayCommand on the current command target.
	/// </summary>
	/// <param name="parameter">
	/// Data used by the command. If the command does not require data to be passed,
	/// this object can be set to null.
	/// </param>
	public void Execute(object? parameter) => _execute();

	/// <summary>
	/// Method used to raise the CanExecuteChanged event
	/// to indicate that the return value of the CanExecute
	/// method has changed.
	/// </summary>
	public void RaiseCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);
	#endregion
}