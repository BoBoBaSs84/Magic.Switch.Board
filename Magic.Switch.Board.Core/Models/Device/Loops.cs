using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

using Magic.Switch.Board.Core.Contracts.Models.Device;
using Magic.Switch.Board.Core.Properties;

using static Magic.Switch.Board.Core.Enums;
using static Magic.Switch.Board.Core.Properties.Resources;

namespace Magic.Switch.Board.Core.Models.Device;

/// <summary>
/// The <see cref="Loops"/> class.
/// </summary>
/// <remarks>
/// Implements the properties if the <see cref="ILoops"/> interface.
/// </remarks>
[XmlRoot(ElementName = nameof(Loops), IsNullable = false)]
public class Loops : ILoops
{
	/// <summary>
	/// Initializes a new instance of the <see cref="Loops"/> class.
	/// </summary>
	public Loops() => Channels = default;

	/// <summary>
	/// Initializes a new instance of the <see cref="Loops"/> class.
	/// </summary>
	/// <param name="channels"></param>
	public Loops(LoopChannels channels) => Channels = channels;

	/// <inheritdoc cref="ILoops.Channels"/>
	[Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = nameof(Model_Field_Required_Generic))]
	[JsonPropertyName(nameof(Channels))]
	[XmlAttribute(AttributeName = nameof(Channels))]
	public LoopChannels Channels { get; set; }
}