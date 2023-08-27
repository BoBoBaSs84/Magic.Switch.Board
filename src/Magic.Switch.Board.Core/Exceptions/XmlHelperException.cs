using System.Xml;

namespace Magic.Switch.Board.Core.Exceptions;

/// <summary>
/// The <see cref="XmlHelperException"/> class.
/// </summary>
/// <remarks>
/// This exception should only be thrown by the xml helper.
/// Inherits from <see cref="XmlException"/> class.
/// </remarks>
public sealed class XmlHelperException : XmlException
{
	/// <summary>
	/// Initializes a new instance of the <see cref="XmlHelperException"/> class.
	/// </summary>
	/// <param name="message">The exception message.</param>
	public XmlHelperException(string message) : base(message)
	{
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="XmlHelperException"/> class.
	/// </summary>
	/// <param name="message">The exception message.</param>
	/// <param name="innerException">The inner exception.</param>
	public XmlHelperException(string message, Exception innerException) : base(message, innerException)
	{
	}
}
