using System.Text.Json.Serialization;
using System.Xml.Serialization;
using static Magic.Switch.Board.Core.Enums;

namespace Magic.Switch.Board.Core.Models.Device.Base;

/// <summary>
/// The <see cref="InputOutputBase"/> class.
/// </summary>
[XmlInclude(typeof(Input))]
[XmlInclude(typeof(Output))]
public abstract class InputOutputBase
{
	/// <summary>
	/// The empty <see cref="InputOutputBase"/> class constructor.
	/// </summary>
	public InputOutputBase()
	{
		MidiChannel = MidiChannel.Ch1;
		MessageType = MidiMessageType.PCM;
		Number = default;
	}

	/// <summary>
	/// The standard <see cref="InputOutputBase"/> class constructor.
	/// </summary>
	/// <param name="midiChannel"></param>
	/// <param name="messageType"></param>
	/// <param name="number"></param>
	public InputOutputBase(MidiChannel midiChannel, MidiMessageType messageType, int number)
	{
		MidiChannel = midiChannel;
		MessageType = messageType;
		Number = number;
	}

	/// <summary>
	/// The <see cref="MidiChannel"/> property
	/// </summary>
	[JsonPropertyName(nameof(MidiChannel))]
	[XmlAttribute(AttributeName = nameof(MidiChannel))]
	public MidiChannel MidiChannel { get; set; }

	/// <summary>
	/// The <see cref="MessageType"/> property
	/// </summary>
	[JsonPropertyName(nameof(MessageType))]
	[XmlAttribute(AttributeName = nameof(MessageType))]
	public MidiMessageType MessageType { get; set; }

	/// <summary>
	/// The <see cref="Number"/> property
	/// </summary>
	[JsonPropertyName(nameof(Number))]
	[XmlAttribute(AttributeName = nameof(Number))]
	public int Number { get; set; }
}