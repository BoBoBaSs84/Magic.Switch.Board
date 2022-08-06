using Magic.Switch.Board.App.Services.Interfaces;
using Magic.Switch.Board.Services.Logging.Interfaces;
using static Magic.Switch.Board.App.Enums;

namespace Magic.Switch.Board.App.Services;

internal sealed class ConsoleService : IHostedService
{
	private readonly ILoggerService loggerService;
	private readonly IHostApplicationLifetime appLifetime;
	private readonly IMainService mainService;
	private CancellationTokenSource? cancellationTokenSource;
	private Task<ExitCode>? mainTask;

	public ConsoleService(ILoggerService loggerService, IHostApplicationLifetime appLifetime, IMainService mainService)
	{
		this.loggerService = loggerService;
		this.appLifetime = appLifetime;
		this.mainService = mainService;
	}

	/// <summary>
	/// Triggered when the application host is ready to start the service.
	/// </summary>
	/// <param name="cancellationToken">Indicates that the start process has been aborted.</param>
	public Task StartAsync(CancellationToken cancellationToken)
	{
		cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
		// Bail if the start process has been aborted.
		if (cancellationTokenSource.IsCancellationRequested)
			return Task.CompletedTask;

		appLifetime.ApplicationStarted.Register(() =>
		{
			string[]? args = Environment.GetCommandLineArgs();
			mainTask = ExecuteMainAsync(args, cancellationTokenSource.Token);
		});

		return Task.CompletedTask;
	}

	/// <summary>
	/// Triggered when the application host is performing a graceful shutdown.
	/// </summary>
	/// <param name="cancellationToken">Indicates that the shutdown process should no longer be graceful.</param>
	public async Task StopAsync(CancellationToken cancellationToken)
	{
		ExitCode exitCode;

		if (mainTask is not null)
		{
			// If the main service is still running or the passed in cancellation token is in the cancelled state
			// then request a cancellation.
			if (!mainTask.IsCompleted || cancellationToken.IsCancellationRequested)
				cancellationTokenSource?.Cancel();

			// Wait for the main service to fully complete any cleanup tasks.
			// Note that this relies on the cancellation token to be properly used in the application.
			exitCode = await mainTask.ConfigureAwait(false);
		}
		else
		{
			// The main service task never started.
			exitCode = ExitCode.Aborted;
		}
		
		loggerService.LogDebug($"Exiting with return code: {exitCode}");
		Environment.ExitCode = (int)exitCode;
	}

	/// <summary>
	/// Executes the <see cref="MainService.Main" /> method of the <see cref="MainService" /> and handles any exceptions.
	/// </summary>
	/// <param name="args">The command line arguments.</param>
	/// <param name="cancellationToken">The cancellation token.</param>
	/// <returns>
	/// An <see cref="ExitCode" /> that indicates the outcome of the application..
	/// </returns>
	private async Task<ExitCode> ExecuteMainAsync(string[] args, CancellationToken cancellationToken)
	{
		try
		{
			return await mainService.Main(args, cancellationToken);
		}
		catch (Exception ex)
		{
			loggerService.LogError(ex.Message);
			return ExitCode.UnhandledException;
		}
		finally
		{
			appLifetime.StopApplication();
		}
	}
}