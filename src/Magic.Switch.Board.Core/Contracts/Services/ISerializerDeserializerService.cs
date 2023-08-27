using System.Runtime.InteropServices;
using System.Text;

namespace Magic.Switch.Board.Core.Contracts.Services;

/// <summary>
/// The <see cref="ISerializerDeserializerService"/> interface.
/// </summary>
public interface ISerializerDeserializerService
{
	/// <summary>
	/// Deserializes the provided string into an object of the given type.
	/// </summary>
	/// <remarks>
	/// Will throw an exception if <paramref name="stringValue"/> is <see langword="null"/> or empty.
	/// </remarks>
	/// <typeparam name="TClass">The object to transform.</typeparam>
	/// <param name="stringValue">The desired object as string value.</param>
	/// <returns>The string deserialized into an object.</returns>
	TClass? Deserialize<TClass>(string stringValue) where TClass : class;

	/// <summary>
	/// Serializes the object into an string.
	/// </summary>
	/// <remarks>
	/// Will throw an exception if <paramref name="value"/> is <see langword="null"/>.
	/// Since <paramref name="encoding"/> can be <see langword="null"/> if not set <see cref="Encoding.UTF8"/> is used.
	/// </remarks>
	/// <typeparam name="TClass">The object to transform.</typeparam>
	/// <param name="value">The object that should be serialized.</param>
	/// <param name="encoding">The desired encoding type, can be <see langword="null"/>.</param>
	/// <returns>The object serialized into a string.</returns>
	string Serialize<TClass>(TClass value, [Optional] Encoding? encoding) where TClass : class;
}
