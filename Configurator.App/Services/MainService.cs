using Configurator.Core.Models.Device;
using Configurator.Core.Services.Interfaces;
using Configurator.Services.Interfaces;
using static Configurator.Core.Enums;
using static Configurator.Enums;

namespace Configurator.Services
{
	/// <summary>
	/// Main application service.
	/// </summary>
	/// <remarks>
	/// This service implements the main application logic.
	/// The method <see cref="Main" /> is executed once when the application executes.
	/// </remarks>
	public sealed class MainService : IMainService
	{
		private readonly IUserNotificationService userNotificationService;
		private readonly IDeviceConfigService deviceConfigService;
		private readonly IAppConfigService appConfigService;

		/// <summary>
		/// Initialises the <see cref="MainService" /> using the specified dependencies.
		/// </summary>
		/// <param name="userNotificationService">The notification service.</param>
		/// <param name="deviceConfigService">The device configuration service.</param>
		/// <param name="appConfigService">The application configuration service.</param>
		public MainService(IUserNotificationService userNotificationService, IDeviceConfigService deviceConfigService, IAppConfigService appConfigService)
		{
			this.userNotificationService = userNotificationService;
			this.deviceConfigService = deviceConfigService;
			this.appConfigService = appConfigService;
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
			Core.Models.Application.Configuration? appConfig = appConfigService.Create(Statics.AssemblyVersion);
			await userNotificationService.NotifyWithMessageAsync("Application configuration created.");

			appConfigService.Write(appConfig, null);
			await userNotificationService.NotifyWithMessageAsync("Application configuration saved.");

			Configuration? deviceConfig = deviceConfigService.Create(Statics.AssemblyVersion);
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

			var list = Core.Enums.FlagsToList(Core.Enums.SwitchChannels.Ch1 | SwitchChannels.Ch2 | SwitchChannels.Ch3 | SwitchChannels.Ch4);			
			var list2 = Core.Enums.ToList<Core.Enums.LoopChannels>();

			if (list is not null)
				foreach (var item in list)
					Console.WriteLine($"{nameof(item)}: {item}\t{nameof(item)}Number: {(int)item}\tdescription: {item.GetDescription()}");


			if (list2 is not null)
				foreach (var item in list2)
					Console.WriteLine($"{nameof(item)}: {item}\t{nameof(item)}Number: {(int)item}\tdescription: {item.GetDescription()}");

			deviceConfigService.Write(deviceConfig, null);
			deviceConfig = deviceConfigService.Read();

			return ExitCode.Success;
		}
	}
}