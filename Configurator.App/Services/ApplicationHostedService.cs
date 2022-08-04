using Configurator.Helpers;
using Configurator.Services.Interfaces;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using static Configurator.Enums;

namespace Configurator.Services
{
	/// <summary>
	/// Hosted service that handles the application lifetime events and invokes the main application service.
	/// </summary>
	public sealed class ApplicationHostedService : IHostedService
	{
		private readonly IHostApplicationLifetime hostApplicationLifetime;
		private readonly ILogger<ApplicationHostedService> logger;
		private readonly IMainService mainService;
		private CancellationTokenSource? cancellationTokenSource;
		private Task<ExitCode>? mainTask;

		/// <summary>
		/// Initialises the <see cref="ApplicationHostedService" /> using the specified dependencies.
		/// </summary>
		/// <param name="hostApplicationLifetime">Notifies of application lifetime events.</param>
		/// <param name="logger">The logger to use within this service.</param>
		/// <param name="mainService">The main service.</param>
		public ApplicationHostedService(IHostApplicationLifetime hostApplicationLifetime, ILogger<ApplicationHostedService> logger, IMainService mainService)
		{
			this.hostApplicationLifetime = hostApplicationLifetime;
			this.logger = logger;
			this.mainService = mainService;
		}

		/// <summary>
		/// Triggered when the application host is ready to start the service.
		/// </summary>
		/// <param name="cancellationToken">Indicates that the start process has been aborted.</param>
		public Task StartAsync(CancellationToken cancellationToken)
		{
			logger.LogApplicationStarting();

			cancellationTokenSource = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);

			// Bail if the start process has been aborted.
			if (cancellationTokenSource.IsCancellationRequested)
				return Task.CompletedTask;

			//
			// Register callbacks to handle the application lifetime events.
			//

			// ApplicationStarted
			hostApplicationLifetime.ApplicationStarted.Register(() =>
			{
				string[]? args = Environment.GetCommandLineArgs();

				logger.LogApplicationStarted(args);

				// Execute the main service but do not await it here. The task will be awaited in StopAsync().
				mainTask = ExecuteMainAsync(args, cancellationTokenSource.Token);
			});

			// ApplicationStopping
			hostApplicationLifetime.ApplicationStopping.Register(logger.LogApplicationStopping);

			// ApplicationStopped
			hostApplicationLifetime.ApplicationStopped.Register(logger.LogApplicationStopped);

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

			Environment.ExitCode = (int)exitCode;

			logger.LogApplicationExiting(exitCode, (int)exitCode);
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
				// This means the application is shutting down, so just swallow this exception.
				logger.LogApplicationCancelled();

				return ExitCode.Cancelled;
			}
			catch (Exception ex)
			{
				logger.LogUnhandledException(ex);

				return ExitCode.UnhandledException;
			}
			finally
			{
				// Stop the application once the work is done.
				hostApplicationLifetime.StopApplication();
			}
		}
	}
}