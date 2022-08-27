using Magic.Switch.Board.Core.Contracts.Services;
using Magic.Switch.Board.Extensions;
using Magic.Switch.Board.Views;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Windows;
using System.Windows.Threading;

namespace Magic.Switch.Board;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
	private readonly IHost _host;
	private readonly ILoggerService _logger;

	/// <summary>
	/// The App constructor
	/// </summary>
	public App()
	{
		_host = Host.CreateDefaultBuilder()
			.UseContentRoot(AppContext.BaseDirectory)
			.ConfigureServices((context, services) =>
			{
				services.ConfigureTransientServices();
				services.ConfigureSingletonServices();
				services.ConfigureViews();
				services.ConfigureViewsModels();
			})
			.Build();

		_logger = GetService<ILoggerService>();

		DispatcherUnhandledException += OnUnhandledException;
	}

	public static T GetService<T>() where T : class =>
		(Current as App)!._host.Services.GetService(typeof(T)) is not T service
		? throw new ArgumentException($"{typeof(T)} needs to be registered in ConfigureServices within App.xaml.cs.")
		: service;

	private async void Application_Startup(object sender, StartupEventArgs e)
	{
		_logger.Information("Apllication starting...");
		await _host.StartAsync();
		MainWindow mainWindow = _host.Services.GetRequiredService<MainWindow>();
		mainWindow.Show();
	}

	private async void Application_Exit(object sender, ExitEventArgs e)
	{
		_logger.Information("Apllication exiting...");
		using (_host)
		{
			await _host.StopAsync(TimeSpan.FromSeconds(5));
		}
	}

	private void OnUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e) =>
		_logger.Critical($"{e.Exception.Message}");
}