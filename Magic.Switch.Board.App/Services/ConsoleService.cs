using Magic.Switch.Board.App.Services.Interfaces;
using Magic.Switch.Board.Services.Logging.Interfaces;
using static Magic.Switch.Board.App.Enums;

namespace Magic.Switch.Board.App.Services;

/// <summary>
/// Hosted service that handles the application lifetime events and invokes the main application service.
/// </summary>
internal sealed class ConsoleService : IHostedService
{
	private readonly IHostApplicationLifetime appLifetime;
	private readonly ILoggerService loggerService;	
	private readonly IMainService mainService;
	private CancellationTokenSource? cancellationTokenSource;
	private Task<ExitCode>? mainTask;

	/// <summary>
	/// Initialises the <see cref="ConsoleService" /> using the specified dependencies.
	/// </summary>
	/// <param name="appLifetime">Notifies of application lifetime events.</param>
	/// <param name="loggerService">The logger to use within this service.</param>
	/// <param name="mainService">The main service.</param>
	public ConsoleService(IHostApplicationLifetime appLifetime, ILoggerService loggerService, IMainService mainService)
	{
		this.appLifetime = appLifetime;
		this.loggerService = loggerService;		
		this.mainService = mainService;
	}

	/// <summary>
	/// Triggered when the application host is ready to start the service.
	/// </summary>
	/// <param name="cancellationToken">Indicates that the start process has been aborted.</param>
	public Task StartAsync(CancellationToken cancellationToken)
	{
		loggerService.Debug($"Application is starting.");

		cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
		// Bail if the start process has been aborted.
		if (cancellationTokenSource.IsCancellationRequested)
			return Task.CompletedTask;

		appLifetime.ApplicationStarted.Register(() =>
		{
			string[]? args = Environment.GetCommandLineArgs();

			loggerService.Debug($"Application has started with arguments: \"{string.Join(" ", args)}\".");

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
		
		loggerService.Information($"Exiting with return code: {exitCode}");

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
		catch (TaskCanceledException)
		{
			return ExitCode.Cancelled;
		}
		catch (Exception ex)
		{
			loggerService.Critical($"{nameof(ex.Message)}: {ex.Message}\n{nameof(ex.InnerException)}: {ex.InnerException}");
			return ExitCode.UnhandledException;
		}
		finally
		{
			appLifetime.StopApplication();
		}
	}
}