using Magic.Switch.Board.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;
using static Magic.Switch.Board.Statics;

namespace Magic.Switch.Board
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		private readonly IHostBuilder hostBuilder;
		private readonly IHost host;

		/// <summary>
		/// The App constructor
		/// </summary>
		public App()
		{
			hostBuilder = Host.CreateDefaultBuilder()
				.UseContentRoot(AsseblyDirectory);

			hostBuilder.ConfigureLogging(logging =>
			{
				logging.ConfigureConsoleLogging();
			});

			hostBuilder.ConfigureAppConfiguration(config =>
			{
				config.ConfigureUserSecrets();
			});

			hostBuilder.ConfigureServices(services =>
			{
				services.ConfigureScopedServices();
				services.ConfigureSingletonServices();
				services.AddSingleton<MainWindow>();
			});

			host = hostBuilder.Build();
		}

		private async void Application_Startup(object sender, StartupEventArgs e)
		{
			await host.StartAsync();
			MainWindow? mainWindow = host.Services.GetRequiredService<MainWindow>();
			mainWindow.Show();
		}

		private async void Application_Exit(object sender, ExitEventArgs e)
		{
			using (host)
			{
				await host.StopAsync(TimeSpan.FromSeconds(5));
			}
		}
	}
}
