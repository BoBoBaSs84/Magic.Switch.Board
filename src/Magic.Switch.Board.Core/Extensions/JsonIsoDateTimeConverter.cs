using System.Globalization;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Magic.Switch.Board.Core.Extensions;

/// <inheritdoc/>
/// <remarks>
/// The <see cref="JsonIsoDateTimeConverter"/> class converts from and to "yyyy-MM-dd".
/// </remarks>
public sealed class JsonIsoDateTimeConverter : JsonConverter<DateTime>
{
	/// <inheritdoc/>
	public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
		DateTime.ParseExact(reader.GetString()!, "G", CultureInfo.InvariantCulture);

	/// <inheritdoc/>
	public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options) =>
		writer.WriteStringValue(value.ToString("G", CultureInfo.InvariantCulture));
}
