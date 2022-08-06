using System.Xml.Serialization;
using static Magic.Switch.Board.Entities.Enums;

namespace Magic.Switch.Board.Entities.Configuration.Base;

/// <summary>
/// The <see cref="InputOutputBase"/> class
/// </summary>
public abstract class InputOutputBase
{
	/// <summary>
	/// The empty <see cref="InputOutputBase"/> constructor
	/// </summary>
	public InputOutputBase()
	{
		MidiChannel = default;
		MessageType = default;
		Number = default;
	}

	/// <summary>
	/// The <see cref="InputOutputBase"/> constructor
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

	/// The <see cref="MidiChannel"/> property
	/// </summary>
	[XmlAttribute(AttributeName = nameof(MidiChannel))]
	public MidiChannel MidiChannel { get; set; }

	/// <summary>
	/// The <see cref="MessageType"/> property
	/// </summary>
	[XmlAttribute(AttributeName = nameof(MessageType))]
	public MidiMessageType MessageType { get; set; }

	/// <summary>
	/// The <see cref="Number"/> property
	/// </summary>
	[XmlAttribute(AttributeName = nameof(Number))]
	public int Number { get; set; }
}
