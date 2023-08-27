using System.Windows;
using System.Windows.Threading;

using Magic.Switch.Board.Core.Contracts.Services;
using Magic.Switch.Board.UI.Extensions;
using Magic.Switch.Board.UI.Views;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Magic.Switch.Board.UI;

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

	/// <summary>
	/// The <see cref="GetService{T}"/> method should the requested registered service.
	/// </summary>
	/// <typeparam name="T">The requested service.</typeparam>
	/// <returns>The registered service.</returns>
	/// <exception cref="ArgumentException">If a service is not registered.</exception>
	public static T GetService<T>() where T : class =>
		(Current as App)!._host.Services.GetService(typeof(T)) is not T service
		? throw new ArgumentException($"{typeof(T)} needs to be registered in ConfigureServices within App.xaml.cs.")
		: service;

	/// <summary>
	/// The <see cref="Application_Startup(object, StartupEventArgs)"/> method should start the application.
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private async void Application_Startup(object sender, StartupEventArgs e)
	{
		_logger.Information("Apllication starting...");
		await _host.StartAsync().ConfigureAwait(false);
		MainWindow mainWindow = _host.Services.GetRequiredService<MainWindow>();
		mainWindow.Show();
	}

	/// <summary>
	/// The <see cref="Application_Exit(object, ExitEventArgs)"/> method should exit the application.
	/// </summary>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	private async void Application_Exit(object sender, ExitEventArgs e)
	{
		_logger.Information("Apllication exiting...");
		using (_host)
			await _host.StopAsync(TimeSpan.FromSeconds(5)).ConfigureAwait(false);
	}

	private void OnUnhandledException(object sender, DispatcherUnhandledExceptionEventArgs e) =>
		_logger.Critical($"{e.Exception.Message}");
}