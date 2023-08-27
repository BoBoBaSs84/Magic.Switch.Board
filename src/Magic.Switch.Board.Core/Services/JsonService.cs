using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

using Magic.Switch.Board.Core.Contracts.Services;
using Magic.Switch.Board.Core.Exceptions;

namespace Magic.Switch.Board.Core.Services;

/// <summary>
/// The <see cref="JsonService"/> class.
/// </summary>
/// <remarks>
/// Implements the members of the <see cref="ISerializerDeserializerService"/> interface.
/// </remarks>
public class JsonService : ISerializerDeserializerService
{
	private readonly JsonSerializerOptions jsonSerializerOptions;

	/// <summary>
	/// Initializes a new instance of the <see cref="JsonService"/> class.
	/// </summary>
	public JsonService() =>
		jsonSerializerOptions = new JsonSerializerOptions()
		{
			DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
			IgnoreReadOnlyFields = true,
			IgnoreReadOnlyProperties = true,
			IncludeFields = false,
			PropertyNameCaseInsensitive = true,
			PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
			WriteIndented = false
		};

	/// <inheritdoc cref="ISerializerDeserializerService.Deserialize{TClass}(string)"/>
	/// <exception cref="ArgumentNullException"></exception>
	/// <exception cref="ServiceException"></exception>
	public TClass? Deserialize<TClass>(string stringValue) where TClass : class
	{
		try
		{
			return string.IsNullOrWhiteSpace(stringValue)
				? throw new ArgumentNullException(nameof(stringValue))
				: JsonSerializer.Deserialize<TClass>(stringValue, jsonSerializerOptions);
		}
		catch (Exception ex)
		{
			throw new ServiceException("Error during json deserialization.", ex);
		}
	}

	/// <inheritdoc cref="ISerializerDeserializerService.Serialize{TClass}(TClass, Encoding?)"/>
	/// <exception cref="ArgumentNullException"></exception>
	/// <exception cref="ServiceException"></exception>
	public string Serialize<TClass>(TClass value, [Optional] Encoding? encoding) where TClass : class
	{
		try
		{
			return value is null
				? throw new ArgumentNullException(nameof(value))
				: JsonSerializer.Serialize(value, jsonSerializerOptions);
		}
		catch (Exception ex)
		{
			throw new ServiceException("Error during json serialization.", ex);
		}
	}
}
