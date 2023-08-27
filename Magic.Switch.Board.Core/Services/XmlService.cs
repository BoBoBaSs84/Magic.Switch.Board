using System.Runtime.InteropServices;
using System.Text;

using Magic.Switch.Board.Core.Contracts.Services;
using Magic.Switch.Board.Core.Exceptions;
using Magic.Switch.Board.Core.Helpers;

namespace Magic.Switch.Board.Core.Services;

/// <summary>
/// The <see cref="XmlService"/> class.
/// </summary>
/// <remarks>
/// Implements the members of the <see cref="ISerializerDeserializerService"/> interface.
/// </remarks>
public class XmlService : ISerializerDeserializerService
{
	/// <inheritdoc cref="ISerializerDeserializerService.Deserialize{TClass}(string)"/>
	/// <exception cref="ArgumentNullException"></exception>
	/// <exception cref="ServiceException"></exception>
	public TClass? Deserialize<TClass>(string stringValue) where TClass : class
	{
		try
		{
			if (string.IsNullOrWhiteSpace(stringValue))
				throw new ArgumentNullException(nameof(stringValue));

			XmlHelper<TClass> xmlHelper = new();
			return xmlHelper.Deserialize(stringValue);
		}
		catch (Exception ex)
		{
			throw new ServiceException("Error during xml deserialization.", ex);
		}
	}

	/// <inheritdoc cref="ISerializerDeserializerService.Serialize{TClass}(TClass, Encoding?)"/>
	/// <exception cref="ArgumentNullException"></exception>
	/// <exception cref="ServiceException"></exception>
	public string Serialize<TClass>(TClass value, [Optional] Encoding? encoding) where TClass : class
	{
		try
		{
			if (value is null)
				throw new ArgumentNullException(nameof(value));

			XmlHelper<TClass> xmlHelper = new();
			return xmlHelper.Serialize(value, encoding ??= Encoding.UTF8).OuterXml;
		}
		catch (Exception ex)
		{
			throw new ServiceException("Error during xml serialization.", ex);
		}
	}
}
