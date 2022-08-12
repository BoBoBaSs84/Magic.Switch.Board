using System.Windows.Input;

namespace Magic.Switch.Board.Contracts.Base
{
	/// <summary>
	/// The <see cref="CommandViewModel"/> class. 
	/// It exposes a property called Command of type <see cref="ICommand"/>.
	/// </summary>
	public class CommandViewModel : ViewModelBase
	{
		/// <inheritdoc/>
		public ICommand Command { get; private set; }

		/// <summary>
		/// The <see cref="CommandViewModel"/> class constructor.
		/// </summary>
		/// <param name="command"></param>
		/// <exception cref="ArgumentNullException"></exception>
		public CommandViewModel(ICommand command)
		{
			if (command is null)
				throw new ArgumentNullException(nameof(command));
			Command = command;
		}
	}
}
