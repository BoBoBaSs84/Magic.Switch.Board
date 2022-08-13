using System.Windows.Input;

namespace Magic.Switch.Board.Contracts.Base
{
	/// <summary>
	/// The <see cref="RelayCommand"/> base class. Implements the members of the <see cref="ICommand"/> interface.
	/// </summary>
	public class RelayCommand : ICommand
	{
		private readonly Predicate<object> _canExecute;
		private readonly Action<object> _execute;

		/// <summary>
		/// The <see cref="RelayCommand"/> class constructor
		/// </summary>
		/// <param name="execute"></param>
		public RelayCommand(Action<object> execute) : this(execute, default!)
		{
		}

		/// <summary>
		/// The <see cref="RelayCommand"/> class constructor
		/// </summary>
		/// <param name="canExecute"></param>
		/// <param name="execute"></param>
		public RelayCommand(Action<object> execute, Predicate<object> canExecute)
		{
			_canExecute = canExecute;
			_execute = execute;
		}

		/// <inheritdoc/>
		public event EventHandler? CanExecuteChanged
		{
			add => CommandManager.RequerySuggested += value;
			remove => CommandManager.RequerySuggested -= value;
		}

		/// <inheritdoc/>
		public bool CanExecute(object? parameter) =>
			parameter is not null && _canExecute(parameter);

		/// <inheritdoc/>
		public void Execute(object? parameter)
		{
			if (parameter is not null)
				_execute(parameter);
		}
	}
}