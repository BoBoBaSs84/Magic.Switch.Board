using Magic.Switch.Board.App.Extensions;
using NLog;
using static Magic.Switch.Board.App.Statics;

namespace Magic.Switch.Board.App;

internal sealed class Program
{
	private Program()
	{
		LogManager.LoadConfiguration(Path.Combine(AsseblyDirectory, NlogConfigFileName));
	}

	private static async Task Main(string[] args)
	{
		await Host.CreateDefaultBuilder(args)
			.UseContentRoot(AsseblyDirectory)
			.ConfigureLogging(logging =>
			{
				logging.ConfigureConsoleLogging();
			})
			.ConfigureAppConfiguration(config =>
			{
				config.ConfigureCommandLine(args);
				config.ConfigureUserSecrets();
			})
			.ConfigureServices((hostContext, services) =>
			{
				services.ConfigureConsoleHost();
				services.ConfigureTransientServices();
				services.ConfigureSingletonServices();
				services.ConfigureScopedServices();
			})
			.RunConsoleAsync();
	}
}