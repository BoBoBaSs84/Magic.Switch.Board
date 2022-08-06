using Magic.Switch.Board.Services.Logging.Interfaces;
using NLog;

namespace Magic.Switch.Board.Services.Logging;

/// <summary>
/// This is the '<see cref="LoggerService"/>' class which implements the members of the '<see cref="ILoggerService"/>' interface
/// </summary>
public sealed class LoggerService : ILoggerService
{
	private readonly ILogger logger;
	/// <summary>
	/// The <see cref="LoggerService"/> constructor
	/// </summary>
	public LoggerService() => logger = LogManager.GetCurrentClassLogger();

	/// <inheritdoc/>
	public void LogDebug(string message) => logger.Debug(message);
	/// <inheritdoc/>
	public void LogError(string message) => logger.Error(message);
	/// <inheritdoc/>
	public void LogInfo(string message) => logger.Info(message);
	/// <inheritdoc/>
	public void LogTrace(string message) => logger.Trace(message);
	/// <inheritdoc/>
	public void LogWarn(string message) => logger.Warn(message);
}
