using Magic.Switch.Board.Services.Logging.Interfaces;
using System.Runtime.CompilerServices;
using static Magic.Switch.Board.Services.Statics;

namespace Magic.Switch.Board.Services.Logging;

/// <summary>
/// This is the <see cref="ConsoleLoggerService"/> class which implements the members of the <see cref="ILoggerService"/> interface.
/// </summary>
/// <remarks>
/// As the class name suggest, the logging is done via the vs console.
/// </remarks>
public sealed class ConsoleLoggerService : ILoggerService
{
	/// <inheritdoc/>
	public void Debug(string message, [CallerMemberName] string? callerName = default) =>
		LogToConsole(nameof(Debug).ToUpper(CurrentCulture), callerName, message);
	/// <inheritdoc/>
	public void Critical(string message, [CallerMemberName] string? callerName = default) =>
		LogToConsole(nameof(Critical).ToUpper(CurrentCulture), callerName, message);
	/// <inheritdoc/>
	public void Error(string message, [CallerMemberName] string? callerName = default) =>
		LogToConsole(nameof(Error).ToUpper(CurrentCulture), callerName, message);
	/// <inheritdoc/>
	public void Information(string message, [CallerMemberName] string? callerName = default) =>
		LogToConsole(nameof(Information).ToUpper(CurrentCulture), callerName, message);
	/// <inheritdoc/>
	public void Trace(string message, [CallerMemberName] string? callerName = default) =>
		LogToConsole(nameof(Trace).ToUpper(CurrentCulture), callerName, message);
	/// <inheritdoc/>
	public void Warning(string message, [CallerMemberName] string? callerName = default) =>
		LogToConsole(nameof(Warning).ToUpper(CurrentCulture), callerName, message);

	/// <summary>
	/// The <see cref="LogToConsole(string, string?, string)"/> method logs the message content to the console.
	/// </summary>
	/// <param name="type">The logger message type.</param>
	/// <param name="caller">The logger message caller.</param>
	/// <param name="message">The logger message itself.</param>
	private static void LogToConsole(string type, string? caller, string message) =>
		System.Diagnostics.Trace.WriteLine($"{DateTime.Now:yyyy-MM-ddTHH:mm:ss.fff} [{type}] <{caller}> {message}");
}