using static Magic.Switch.Board.App.Enums;

namespace Magic.Switch.Board.App.Services.Interfaces;

/// <summary>
/// Main application service interface.
/// </summary>
internal interface IMainService
{
	/// <summary>
	/// Executes the main application logic.
	/// </summary>
	/// <param name="args">The command line arguments.</param>
	/// <param name="cancellationToken">The cancellation token.</param>
	/// <returns>The application exit code.</returns>
	Task<ExitCode> Main(string[] args, CancellationToken cancellationToken);
}