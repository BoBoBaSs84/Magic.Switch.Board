using Magic.Switch.Board.App.Extensions;

namespace Magic.Switch.Board.App;

public class Program
{
	public static void Main(string[] args) =>
		CreateHostBuilder(args)
		.Build()
		.Run();

	public static IHostBuilder CreateHostBuilder(string[] args) =>
		Host.CreateDefaultBuilder(args)
		.UseContentRoot(Path.GetDirectoryName(typeof(Program).Assembly.Location))
		.ConfigureAppConfiguration(config =>
		{
			config.ConfigureCommandLine(args);
			config.ConfigureUserSecrets();
		})
		.ConfigureServices(services =>
		{
			services.ConfigureApplicationHost();
		});
}