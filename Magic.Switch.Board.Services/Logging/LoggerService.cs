using Magic.Switch.Board.Services.Logging.Interfaces;
using System.Text;
using static Magic.Switch.Board.Services.Statics;

namespace Magic.Switch.Board.Services.Logging;

/// <summary>
/// This is the '<see cref="LoggerService"/>' class which implements the members of the '<see cref="ILoggerService"/>' interface
/// </summary>
public sealed class LoggerService : ILoggerService
{
	/// <inheritdoc/>
	public void Debug(string message) => LogToFile(nameof(Debug).ToUpper(CultureInfo), message);
	/// <inheritdoc/>
	public void Error(string message) => LogToFile(nameof(Error).ToUpper(CultureInfo), message);
	/// <inheritdoc/>
	public void Info(string message) => LogToFile(nameof(Info).ToUpper(CultureInfo), message);
	/// <inheritdoc/>
	public void Trace(string message) => LogToFile(nameof(Trace).ToUpper(CultureInfo), message);
	/// <inheritdoc/>
	public void Warn(string message) => LogToFile(nameof(Warn).ToUpper(CultureInfo), message);
	/// <inheritdoc/>
	public void Status(string message) => LogToFile(nameof(Status).ToUpper(CultureInfo), message);

	/// <summary>
	/// The <see cref="LogToFile(string, string)"/> method logs the message content to the log file.
	/// </summary>
	/// <param name="type">The logger message type.</param>
	/// <param name="message">The logger message itself.</param>
	private static void LogToFile(string type, string message)
	{
		File.AppendAllText(
				path: LogFileName,
				contents: $"{DateTime.Now:yyyy-MM-ddTHH:mm:ss.fff} [{type}] {message}{Environment.NewLine}",
				encoding: Encoding.UTF8
				);
	}
}
