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
[XmlRoot(ElementName = nameof(Switches), IsNullable = false)]
public class Switches
{
	/// <summary>
	/// The empty <see cref="Switches"/> class constructor.
	/// </summary>
	public Switches() => Channels = default;

	/// <summary>
	/// The standard <see cref="Switches"/> class constructor.
	/// </summary>
	/// <param name="channels"></param>
	public Switches(SwitchChannels channels) => Channels = channels;

	/// <summary>
	/// The <see cref="Channels"/> property
	/// </summary>
	[Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = nameof(Model_Field_Required_Generic))]
	[JsonPropertyName(nameof(Channels))]
	[XmlAttribute(AttributeName = nameof(Channels))]
	public SwitchChannels Channels { get; set; }
}
