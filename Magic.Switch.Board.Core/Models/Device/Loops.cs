using System.Text.Json.Serialization;
using System.Xml.Serialization;
using static Magic.Switch.Board.Core.Enums;

namespace Magic.Switch.Board.Core.Models.Device;

/// <summary>
/// The <see cref="Loops"/> class.
/// </summary>
[XmlRoot(ElementName = nameof(Loops), IsNullable = false)]
public class Loops
{
	/// <summary>
	/// The empty <see cref="Loops"/> class constructor.
	/// </summary>
	public Loops() => Channels = default;

	/// <summary>
	/// The standard <see cref="Loops"/> class constructor.
	/// </summary>
	/// <param name="channels"></param>
	public Loops(LoopChannels channels) => Channels = channels;

	/// <summary>
	/// The <see cref="Channels"/> property.
	/// </summary>
	[JsonPropertyName(nameof(Channels))]
	[XmlAttribute(AttributeName = nameof(Channels))]
	public LoopChannels Channels { get; set; }
}