using Magic.Switch.Board.Services.Logging.Interfaces;
using System.Runtime.CompilerServices;
using System.Text;
using static Magic.Switch.Board.Services.Statics;

namespace Magic.Switch.Board.Services.Logging;

/// <summary>
/// This is the '<see cref="LoggerService"/>' class which implements the members of the '<see cref="ILoggerService"/>' interface
/// </summary>
public sealed class LoggerService : ILoggerService
{
	/// <inheritdoc/>
	public void Debug(string message, [CallerMemberName] string callerName = default!) =>
		LogToFile(nameof(Debug).ToUpper(CultureInfo), callerName, message);
	/// <inheritdoc/>
	public void Critical(string message, [CallerMemberName] string callerName = default!) =>
		LogToFile(nameof(Critical).ToUpper(CultureInfo), callerName, message);
	/// <inheritdoc/>
	public void Error(string message, [CallerMemberName] string callerName = default!) =>
		LogToFile(nameof(Error).ToUpper(CultureInfo), callerName, message);
	/// <inheritdoc/>
	public void Information(string message, [CallerMemberName] string callerName = default!) =>
		LogToFile(nameof(Information).ToUpper(CultureInfo), callerName, message);
	/// <inheritdoc/>
	public void Trace(string message, [CallerMemberName] string callerName = default!) =>
		LogToFile(nameof(Trace).ToUpper(CultureInfo), callerName, message);
	/// <inheritdoc/>
	public void Warning(string message, [CallerMemberName] string callerName = default!) =>
		LogToFile(nameof(Warning).ToUpper(CultureInfo), callerName, message);

	/// <summary>
	/// The <see cref="LogToFile(string, string, string)"/> method logs the message content to the log file.
	/// </summary>
	/// <param name="type">The logger message type.</param>
	/// <param name="caller">The logger message caller.</param>
	/// <param name="message">The logger message itself.</param>
	private static void LogToFile(string type, string caller, string message)
	{
		File.AppendAllText(
				path: LogFileName,
				contents: $"{DateTime.Now:yyyy-MM-ddTHH:mm:ss.fff} [{type}] <{caller}> {message}{Environment.NewLine}",
				encoding: Encoding.UTF8
				);
	}
}