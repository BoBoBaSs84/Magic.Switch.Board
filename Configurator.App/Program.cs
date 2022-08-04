using Configurator.Extensions;
using Microsoft.Extensions.Hosting;
using System.Reflection;

namespace Configurator
{
	internal sealed class Program
	{
		private static async Task Main(string[] args)
		{
			IHostBuilder? hostBuilder = Host.CreateDefaultBuilder(args)
				.UseContentRoot(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

			hostBuilder.ConfigureAppConfiguration(configurationBuilder =>
			{
				configurationBuilder.ConfigureSecrets();
				configurationBuilder.ConfigureCommandLine(args);
			});

			hostBuilder.ConfigureServices((hostContext, services) =>
			{
				services.ConfigureHostedService();
				services.ConfigureTransientServices();
				services.ConfigureSingletonServices();
				services.ConfigureScopedServices();
			});

			await hostBuilder.RunConsoleAsync()
				.ConfigureAwait(false);
		}
	}
}