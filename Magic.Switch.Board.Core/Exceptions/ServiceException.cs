namespace Magic.Switch.Board.Core.Exceptions;

/// <summary>
/// The <see cref="ServiceException"/> class.
/// </summary>
/// <remarks>
/// This exception should only be thrown by services.
/// </remarks>
public sealed class ServiceException : Exception
{
	/// <summary>
	/// Initializes a new parameterless instance of the <see cref="ServiceException"/> class.
	/// </summary>
	/// <param name="message">The exception message.</param>
	/// <param name="innerException">The inner exception.</param>
	public ServiceException(string message, Exception innerException) : base(message, innerException)
	{
	}
}
