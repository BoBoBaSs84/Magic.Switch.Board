using Magic.Switch.Board.Contracts.Base;
using Magic.Switch.Board.Services.Logging.Interfaces;
using System.Windows;
using System.Windows.Input;

namespace Magic.Switch.Board.Contracts
{
	/// <summary>
	/// The <see cref="MainViewModel"/> class.
	/// </summary>
	public class MainViewModel : ViewModelBase
	{
		private readonly ILoggerService _logger;

		/// <summary>
		/// The <see cref="MainViewModel"/> class constructor.
		/// </summary>
		/// <param name="logger"></param>
		public MainViewModel(ILoggerService logger)
		{
			_logger = logger;
		}

		private RelayCommand? cmdNewFile;
		/// <summary>
		/// The <see cref="CmdNewFile"/> command for creating a new file.
		/// </summary>
		public ICommand CmdNewFile => cmdNewFile ??= new RelayCommand(PerformCmdNewFile);

		private void PerformCmdNewFile()
		{
			_logger.Trace("Let's trace!");
			MessageBox.Show("This is a message box message", "message box", MessageBoxButton.OK, MessageBoxImage.Information);
		}

		private RelayCommand? cmdOpenFile;
		/// <summary>
		/// The <see cref="CmdOpenFile"/> command for opening an existing file.
		/// </summary>
		public ICommand CmdOpenFile => cmdOpenFile ??= new RelayCommand(PerformCmdOpenFile);

		private void PerformCmdOpenFile()
		{
			_logger.Trace("Let's trace!");
			MessageBox.Show("This is a message box message", "message box", MessageBoxButton.OK, MessageBoxImage.Information);
		}

		private RelayCommand? cmdOpenSettings;
		/// <summary>
		/// The <see cref="CmdOpenFile"/> command for opening the settings.
		/// </summary>
		public ICommand CmdOpenSettings => cmdOpenSettings ??= new RelayCommand(PerformCmdOpenSettings);

		private void PerformCmdOpenSettings()
		{
			_logger.Trace("Let's trace!");
			MessageBox.Show("This is a message box message", "message box", MessageBoxButton.OK, MessageBoxImage.Information);
		}

		private RelayCommand? cmdQuitApplication;
		/// <summary>
		/// The <see cref="CmdQuitApplication"/> command for exiting the apllication.
		/// </summary>
		public ICommand CmdQuitApplication => cmdQuitApplication ??= new RelayCommand(PerformCmdQuitApplication);

		private void PerformCmdQuitApplication()
		{
			_logger.Trace("Application shut down reqeusted.");
			if (MessageBox.Show("do you really want to quit?", "Quit", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.No)
			{
				_logger.Trace("Application shut down aborted.");
			}
			else
			{
				_logger.Trace("Application shut down confirmed.");
				Application.Current.Shutdown();
			}			
		}
	}
}