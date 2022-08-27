using Magic.Switch.Board.Core.Contracts.Services;
using Magic.Switch.Board.Core.Models.Device;
using Magic.Switch.Board.ViewModels.Base;
using System.Windows;
using System.Windows.Input;
using static Magic.Switch.Board.Statics;

namespace Magic.Switch.Board.ViewModels;

/// <summary>
/// The <see cref="MainViewModel"/> class.
/// </summary>
public sealed class MainViewModel : ViewModelBase
{
	private readonly ILoggerService _logger;
	private readonly IDeviceConfigService _deviceConfigService;
	private Configuration? configuration;

	/// <summary>
	/// The <see cref="MainViewModel"/> class constructor.
	/// </summary>
	/// <param name="logger">The logger service.</param>
	/// <param name="deviceConfigService">The device configuration service.</param>
	/// <param name="applicationVersion">The application version.</param>
	public MainViewModel(ILoggerService logger, IDeviceConfigService deviceConfigService)
	{
		_logger = logger;
		_deviceConfigService = deviceConfigService;
	}

	private RelayCommand? cmdNewFile;
	/// <summary>
	/// The <see cref="CmdNewFile"/> command for creating a new file.
	/// </summary>
	public ICommand CmdNewFile => cmdNewFile ??= new RelayCommand(PerformCmdNewFile);

	private void PerformCmdNewFile()
	{
		_logger.Trace("Let's trace!");
		configuration = _deviceConfigService.Create(AssemblyVersion);
		if (configuration is not null)
			_logger.Information($"{nameof(Configuration)} created.");
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
			_logger.Trace("Application shut down aborted.");
		else
		{
			_logger.Trace("Application shut down confirmed.");
			Application.Current.Shutdown();
		}
	}

	private RelayCommand? cmdShowAbout;
	/// <summary>
	/// The <see cref="CmdShowAbout"/> command for showing the about Message.
	/// </summary>
	public ICommand CmdShowAbout => cmdShowAbout ??= new RelayCommand(PerformCmdShowAbout);

	private void PerformCmdShowAbout()
	{
	}
}