using Magic.Switch.Board.Extensions;
using Magic.Switch.Board.Views;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;
using static Magic.Switch.Board.Statics;

namespace Magic.Switch.Board;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
	private readonly IHostBuilder _hostBuilder;
	private readonly IHost _host;

	/// <summary>
	/// The App constructor
	/// </summary>
	public App()
	{
		_hostBuilder = Host.CreateDefaultBuilder()
			.UseContentRoot(AsseblyDirectory);

		_hostBuilder.ConfigureLogging(logging =>
		{
			logging.ConfigureConsoleLogging();
		});

		_hostBuilder.ConfigureAppConfiguration(config =>
		{
			config.ConfigureUserSecrets();
		});

		_hostBuilder.ConfigureServices(services =>
		{
			// Services
			services.ConfigureScopedServices();
			services.ConfigureSingletonServices();

			// Viewmodels
			services.ConfigureViewsModels();
		});

		_host = _hostBuilder.Build();
	}

	private async void Application_Startup(object sender, StartupEventArgs e)
	{
		await _host.StartAsync();
		MainWindow mainWindow = _host.Services.GetRequiredService<MainWindow>();
		mainWindow.Show();
	}

	private async void Application_Exit(object sender, ExitEventArgs e)
	{
		using (_host)
		{
			await _host.StopAsync(TimeSpan.FromSeconds(5));
		}
	}
}
