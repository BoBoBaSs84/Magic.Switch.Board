using Magic.Switch.Board.Core.Contracts.Models.Device;
using Magic.Switch.Board.Core.Properties;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using static Magic.Switch.Board.Core.Enums;
using static Magic.Switch.Board.Core.Properties.Resources;

namespace Magic.Switch.Board.Core.Models.Device;

/// <summary>
/// The <see cref="Switches"/> class
/// </summary>
/// <remarks>
/// Implements the properties if the <see cref="ISwitches"/> interface.
/// </remarks>
[XmlRoot(ElementName = nameof(Switches), IsNullable = false)]
public class Switches : ISwitches
{
	/// <summary>
	/// Initializes a new instance of the <see cref="Switches"/> class.
	/// </summary>
	public Switches() => Channels = default;

	/// <summary>
	/// Initializes a new instance of the <see cref="Switches"/> class.
	/// </summary>
	/// <param name="channels"></param>
	public Switches(SwitchChannels channels) => Channels = channels;

	/// <inheritdoc cref="ISwitches.Channels"/>
	[Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = nameof(Model_Field_Required_Generic))]
	[JsonPropertyName(nameof(Channels))]
	[XmlAttribute(AttributeName = nameof(Channels))]
	public SwitchChannels Channels { get; set; }
}
