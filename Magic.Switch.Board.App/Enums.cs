namespace Magic.Switch.Board.App;

/// <summary>
/// The <see cref="Enums"/> class holds all the required enumerations
/// </summary>
internal static class Enums
{
	/// <summary>
	/// Exit codes used in this application.
	/// </summary>
	internal enum ExitCode
	{
		/// <summary>
		/// Indicates that the application succeeded.
		/// </summary>
		Success = 0,
		/// <summary>
		/// Indicates that the application was cancelled.
		/// </summary>
		Cancelled = 1,
		/// <summary>
		/// Indicates that there was an unhandled exception.
		/// </summary>
		UnhandledException = 2,
		/// <summary>
		/// Indicates that the application was aborted.
		/// </summary>
		Aborted = 3
	}
}
