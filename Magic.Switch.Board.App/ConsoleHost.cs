using Magic.Switch.Board.Services.Logging.Interfaces;
using static Magic.Switch.Board.App.Enums;

namespace Magic.Switch.Board.App;

internal class ConsoleHost : IHostedService
{
	private ExitCode exitCode;
	private readonly ILoggerService loggerService;
	private readonly IHostApplicationLifetime appLifetime;

	public ConsoleHost(ILoggerService loggerService, IHostApplicationLifetime appLifetime)
	{
		this.loggerService = loggerService;
		this.appLifetime = appLifetime;
	}
	
	/// <inheritdoc/>
	public Task StartAsync(CancellationToken cancellationToken)
	{
		loggerService.LogDebug($"Starting with arguments: {string.Join(" ", Environment.GetCommandLineArgs())}");		

		appLifetime.ApplicationStarted.Register(() =>
		{
			Task.Run(async () =>
			{
				try
				{
					loggerService.LogInfo("Hello World!");
					// Simulate real work is being done
					await Task.Delay(5000);

					exitCode = ExitCode.Success;
				}
				catch (Exception ex)
				{
					loggerService.LogError(ex.Message);
					exitCode = ExitCode.UnhandledException;
				}
				finally
				{
					// Stop the application once the work is done
					appLifetime.StopApplication();
				}
			});
		});
		return Task.CompletedTask;
	}
	
	/// <inheritdoc/>
	public Task StopAsync(CancellationToken cancellationToken)
	{
		if (appLifetime.ApplicationStopping.IsCancellationRequested)
			exitCode = ExitCode.Cancelled;

		loggerService.LogDebug($"Exiting with return code: {exitCode}");
		Environment.ExitCode = (int)exitCode;
		return Task.CompletedTask;
	}
}
