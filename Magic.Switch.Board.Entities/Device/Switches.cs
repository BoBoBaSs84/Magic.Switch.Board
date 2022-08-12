using System.Xml.Serialization;
using static Magic.Switch.Board.Models.Enums;

namespace Magic.Switch.Board.Models.Device;

/// <summary>
/// The <see cref="Switches"/> class
/// </summary>
[XmlRoot(ElementName = nameof(Switches), IsNullable = false)]
public class Switches
{
	/// <summary>
	/// The empty <see cref="Switches"/> constructor
	/// </summary>
	public Switches()
	{
		Channels = default;
	}

	/// <summary>
	/// The <see cref="Switches"/> constructor
	/// </summary>
	/// <param name="channels"></param>
	public Switches(SwitchChannels channels)
	{
		Channels = channels;
	}

	/// <summary>
	/// The <see cref="Channels"/> property
	/// </summary>
	[XmlAttribute(AttributeName = nameof(Channels))]
	public SwitchChannels Channels { get; set; }
}
