﻿using static Configurator.Enums;

namespace Configurator.Services.Interfaces
{
	/// <summary>
	/// Main application service interface.
	/// </summary>
	public interface IMainService
	{
		/// <summary>
		/// Executes the main application logic.
		/// </summary>
		/// <param name="args">The command line arguments.</param>
		/// <param name="cancellationToken">The cancellation token.</param>
		/// <returns>The application exit code.</returns>
		Task<ExitCode> Main(string[] args, CancellationToken cancellationToken);
	}
}
