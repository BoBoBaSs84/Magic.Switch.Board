using Magic.Switch.Board.Core.Properties;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using static Magic.Switch.Board.Core.Enums;
using static Magic.Switch.Board.Core.Properties.Resources;

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
	[Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = nameof(Model_Field_Required_Generic))]
	[JsonPropertyName(nameof(Channels))]
	[XmlAttribute(AttributeName = nameof(Channels))]
	public LoopChannels Channels { get; set; }
}