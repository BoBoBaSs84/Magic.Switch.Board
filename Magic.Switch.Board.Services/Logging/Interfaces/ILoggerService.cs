﻿namespace Magic.Switch.Board.Services.Logging.Interfaces;

/// <summary>
/// This is the '<see cref="ILoggerService"/>' interface for the logger service class '<see cref="LoggerService"/>'
/// </summary>
public interface ILoggerService
{
	/// <summary>
	/// The interface member for logging debug messages of type <see cref="string"/>
	/// </summary>
	/// <remarks>
	/// Logs that track the general flow of the application.
	/// These logs should have long-term value.
	/// </remarks>
	/// <param name="message"></param>
	void Information(string message);
	/// <summary>
	/// The interface member for logging warning messages of type <see cref="string"/>
	/// </summary>
	/// <remarks>
	/// Logs that highlight an abnormal or unexpected event in the application flow, but do not otherwise cause the application execution to stop.
	/// </remarks>
	/// <param name="message"></param>
	void Warning(string message);
	/// <summary>
	/// The interface member for logging debug messages of type <see cref="string"/>
	/// </summary>
	/// <remarks>
	/// Logs that are used for interactive investigation during development.
	/// These logs should primarily contain information useful for debugging and have no long-term value.
	/// </remarks>
	/// <param name="message"></param>
	void Debug(string message);
	/// <summary>
	/// The interface member for logging error messages of type <see cref="string"/>
	/// </summary>
	/// <remarks>
	/// Logs that highlight when the current flow of execution is stopped due to a failure.
	/// These should indicate a failure in the current activity, not an application-wide failure.
	/// </remarks>
	/// <param name="message"></param>
	void Error(string message);
	/// <summary>
	/// The interface member for logging trace messages of type <see cref="string"/>
	/// </summary>
	/// <remarks>
	/// Logs that contain the most detailed messages. 
	/// These messages may contain sensitive application data. 
	/// These messages are disabled by default and should never be enabled in a production environment.
	/// </remarks>
	/// <param name="message"></param>
	void Trace(string message);
	/// <summary>
	/// The interface member for logging critical messages of type <see cref="string"/>
	/// </summary>
	/// <remarks>
	/// Logs that describe an unrecoverable application or system crash, or a catastrophic failure that requires immediate attention.
	/// </remarks>
	/// <param name="message"></param>
	void Critical(string message);
}
