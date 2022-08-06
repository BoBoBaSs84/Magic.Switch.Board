using Magic.Switch.Board.App.Extensions;
using static Magic.Switch.Board.App.Statics;

namespace Magic.Switch.Board.App;

internal sealed class Program
{
	private static async Task Main(string[] args)
	{
		IHostBuilder hostBuilder = Host.CreateDefaultBuilder(args)
			.UseContentRoot(AsseblyDirectory);

		hostBuilder.ConfigureLogging(logging =>
		{
			logging.ConfigureConsoleLogging();
		});

		hostBuilder.ConfigureAppConfiguration(config =>
		{
			config.ConfigureCommandLine(args);
			config.ConfigureUserSecrets();
		});

		hostBuilder.ConfigureServices(services =>
		{
			services.ConfigureConsoleService();
			services.ConfigureTransientServices();
			services.ConfigureSingletonServices();
			services.ConfigureScopedServices();
		});

		await hostBuilder.RunConsoleAsync()
			.ConfigureAwait(false); ;
	}
}