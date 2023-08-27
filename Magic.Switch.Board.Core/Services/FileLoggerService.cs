using System.Runtime.CompilerServices;
using System.Text;

using Magic.Switch.Board.Core.Contracts.Services;

using static Magic.Switch.Board.Core.Statics;

namespace Magic.Switch.Board.Core.Services;

/// <summary>
/// This is the <see cref="FileLoggerService"/> class which implements the members of the <see cref="ILoggerService"/> interface.
/// </summary>
/// <remarks>
/// As the class name suggest, the logging is done via logging the messages to file.
/// </remarks>
public sealed class FileLoggerService : ILoggerService
{
	/// <inheritdoc/>
	public void Debug(string message, [CallerMemberName] string? callerName = default) =>
		LogToFile(nameof(Debug).ToUpper(CurrentCulture), callerName, message);
	/// <inheritdoc/>
	public void Critical(string message, [CallerMemberName] string? callerName = default) =>
		LogToFile(nameof(Critical).ToUpper(CurrentCulture), callerName, message);
	/// <inheritdoc/>
	public void Error(string message, [CallerMemberName] string? callerName = default) =>
		LogToFile(nameof(Error).ToUpper(CurrentCulture), callerName, message);
	/// <inheritdoc/>
	public void Information(string message, [CallerMemberName] string? callerName = default) =>
		LogToFile(nameof(Information).ToUpper(CurrentCulture), callerName, message);
	/// <inheritdoc/>
	public void Trace(string message, [CallerMemberName] string? callerName = default) =>
		LogToFile(nameof(Trace).ToUpper(CurrentCulture), callerName, message);
	/// <inheritdoc/>
	public void Warning(string message, [CallerMemberName] string? callerName = default) =>
		LogToFile(nameof(Warning).ToUpper(CurrentCulture), callerName, message);

	/// <summary>
	/// The <see cref="LogToFile(string, string?, string)"/> method logs the message content to the log file.
	/// </summary>
	/// <param name="type">The logger message type.</param>
	/// <param name="caller">The logger message caller.</param>
	/// <param name="message">The logger message itself.</param>
	private static void LogToFile(string type, string? caller, string message) =>
		File.AppendAllText(
			path: LogFileName,
			contents: $"{DateTime.Now:yyyy-MM-ddTHH:mm:ss.fff} [{type}] <{caller}> {message}{Environment.NewLine}",
			encoding: Encoding.UTF8
			);
}