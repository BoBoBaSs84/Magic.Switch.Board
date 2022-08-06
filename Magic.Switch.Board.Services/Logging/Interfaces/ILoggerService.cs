﻿using Magic.Switch.Board.Services.Logging;

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
	void LogInfo(string message);
	/// <summary>
	/// Interface member for logging warning messages of type <see cref="string"/>
	/// </summary>
	/// <param name="message"></param>
	void LogWarn(string message);
	/// <summary>
	/// Interface member for logging debug messages of type <see cref="string"/>
	/// </summary>
	/// <param name="message"></param>
	void LogDebug(string message);
	/// <summary>
	/// Interface member for logging error messages of type <see cref="string"/>
	/// </summary>
	/// <param name="message"></param>
	void LogError(string message);
	/// <summary>
	/// Interface member for logging trace messages of type <see cref="string"/>
	/// </summary>
	/// <param name="message"></param>
	void LogTrace(string message);
}