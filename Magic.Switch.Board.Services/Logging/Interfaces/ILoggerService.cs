namespace Magic.Switch.Board.Services.Logging.Interfaces;

/// <summary>
/// This is the '<see cref="ILoggerService"/>' interface for the logger service class '<see cref="LoggerService"/>'
/// </summary>
public interface ILoggerService
{
	/// <summary>
	/// Interface member for logging debug messages of type <see cref="string"/>
	/// </summary>
	/// <param name="message"></param>
	void Info(string message);
	/// <summary>
	/// Interface member for logging warning messages of type <see cref="string"/>
	/// </summary>
	/// <param name="message"></param>
	void Warn(string message);
	/// <summary>
	/// Interface member for logging debug messages of type <see cref="string"/>
	/// </summary>
	/// <param name="message"></param>
	void Debug(string message);
	/// <summary>
	/// Interface member for logging error messages of type <see cref="string"/>
	/// </summary>
	/// <param name="message"></param>
	void Error(string message);
	/// <summary>
	/// Interface member for logging trace messages of type <see cref="string"/>
	/// </summary>
	/// <param name="message"></param>
	void Trace(string message);
	/// <summary>
	/// Interface member for logging status messages of type <see cref="string"/>
	/// </summary>
	/// <param name="message"></param>
	void Status(string message);
}
