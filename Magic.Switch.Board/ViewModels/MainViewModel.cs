using Magic.Switch.Board.Core.Contracts.Services;
using Magic.Switch.Board.Core.Models.Device;
using Magic.Switch.Board.ViewModels.Base;
using System.Windows;
using System.Windows.Input;
using static Magic.Switch.Board.Statics;
using static Magic.Switch.Board.Core.Enums;

namespace Magic.Switch.Board.ViewModels;

/// <summary>
/// The <see cref="MainViewModel"/> class.
/// </summary>
public sealed class MainViewModel : ViewModelBase
{
	private readonly ILoggerService _logger;
	private readonly IDeviceConfigService _deviceConfigService;
	private ConfigurationVM? configurationVM;
	private Configuration? configuration;

	/// <summary>
	/// The <see cref="MainViewModel"/> class constructor.
	/// </summary>
	/// <param name="logger">The logger service.</param>
	/// <param name="deviceConfigService">The device configuration service.</param>
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
		_logger.Trace("Started.");
		configuration = _deviceConfigService.Create(AssemblyVersion);
		_logger.Information("New device configuration created.");
		if (configuration is not null)
		{
			if (configuration.Channels.Count == 0)
			{
				configuration.Channels.Add(new Channel()
				{
					Id = Guid.NewGuid(),
					Name = "This is the first test channel.",
					Input = new Input(MidiChannel.Ch1, MidiMessageType.PCM, 1),
					Output = new Output(MidiChannel.Ch2, MidiMessageType.CCM, 67),
					Switches = new Switches(SwitchChannels.Ch1 | SwitchChannels.Ch3),
					Loops = new Loops(LoopChannels.Ch5 | LoopChannels.Ch7)
				});
				configuration.Channels.Add(new Channel()
				{
					Id = Guid.NewGuid(),
					Name = "This is the second test channel.",
					Input = new Input(MidiChannel.Ch11, MidiMessageType.PCM, 3),
					Output = new Output(MidiChannel.Ch2, MidiMessageType.CCM, 45),
					Switches = new Switches(SwitchChannels.Ch3 | SwitchChannels.Ch2)
				});
			}
			_deviceConfigService.Write($"D:\\", "Test.xml", configuration);
			_logger.Information("New device configuration saved.");
			configuration = _deviceConfigService.Read($"D:\\", "Test.xml");
			_logger.Information("Device configuration loaded.");

			if (configuration is null)
				return;
			configurationVM = new(configuration);
		}
	}

	private RelayCommand? cmdOpenFile;
	/// <summary>
	/// The <see cref="CmdOpenFile"/> command for opening an existing file.
	/// </summary>
	public ICommand CmdOpenFile => cmdOpenFile ??= new RelayCommand(PerformCmdOpenFile);

	private void PerformCmdOpenFile()
	{
		_logger.Trace("Started.");
		MessageBox.Show("This is a message box message", "message box", MessageBoxButton.OK, MessageBoxImage.Information);
	}

	private RelayCommand? cmdOpenSettings;
	/// <summary>
	/// The <see cref="CmdOpenFile"/> command for opening the settings.
	/// </summary>
	public ICommand CmdOpenSettings => cmdOpenSettings ??= new RelayCommand(PerformCmdOpenSettings);

	private void PerformCmdOpenSettings()
	{
		_logger.Trace("Started.");
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