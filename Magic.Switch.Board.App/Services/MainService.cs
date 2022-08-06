using Magic.Switch.Board.App.Services.Interfaces;
using Magic.Switch.Board.Entities.Configuration;
using Magic.Switch.Board.Services.Configuration.Interfaces;
using static Magic.Switch.Board.App.Enums;
using static Magic.Switch.Board.App.Statics;
using static Magic.Switch.Board.Entities.Enums;

namespace Magic.Switch.Board.App.Services;

/// <summary>
/// Main application service.
/// </summary>
/// <remarks>
/// This service implements the main application logic.
/// The method <see cref="Main" /> is executed once when the application executes.
/// </remarks>
internal sealed class MainService : IMainService
{
	private readonly IAppConfigService appConfigService;
	private readonly IDeviceConfigService deviceConfigService;

	public MainService(IAppConfigService appConfigService, IDeviceConfigService deviceConfigService)
	{
		this.appConfigService = appConfigService;
		this.deviceConfigService = deviceConfigService;
	}

	/// <summary>
	/// Executes the main application logic.
	/// </summary>
	/// <remarks>
	/// This method is executed once when the application executes.
	/// </remarks>
	/// <param name="args">The command line arguments.</param>
	/// <param name="cancellationToken">The cancellation token.</param>
	/// <returns>The application exit code.</returns>
	public async Task<ExitCode> Main(string[] args, CancellationToken cancellationToken)
	{
		var appConfig = appConfigService.Create(AssemblyVersion);
		appConfigService.Write(appConfig);

		var deviceConfig = deviceConfigService.Create(AssemblyVersion);
		deviceConfig.Channels.Add(new Channel()
		{
			Name = "Amp Switch plus Reverb and Chorus",
			Input = new() { Number = 13 },
			Output = new() { Number = 45, MessageType = MidiMessageType.PCM, MidiChannel = MidiChannel.Ch2 },
			Switches = new() { Channels = SwitchChannels.Ch1 | SwitchChannels.Ch2 }
		});
		deviceConfig.Channels.Add(new Channel()
		{
			Name = "Distortion and Reverb w/Wah",
			Input = new() { Number = 12 },
			Output = new() { Number = 43, MessageType = MidiMessageType.PCM, MidiChannel = MidiChannel.Ch2 },
			Switches = new() { Channels = SwitchChannels.Ch3 },
			Loops = new() { Channels = LoopChannels.Ch1 }
		});
		deviceConfig.Channels.Add(new Channel()
		{
			Name = "Distortion and Reverb w/Pitch",
			Input = new() { Number = 12 },
			Output = new() { Number = 43, MessageType = MidiMessageType.PCM, MidiChannel = MidiChannel.Ch2 },
			Switches = new() { Channels = SwitchChannels.Ch3 },
			Loops = new() { Channels = LoopChannels.Ch2 }
		});
		deviceConfigService.Write(deviceConfig);

		return ExitCode.Success;
	}
}
