using Magic.Switch.Board.Entities.Configuration.Base;
using System.Xml.Serialization;
using static Magic.Switch.Board.Entities.Enums;

namespace Magic.Switch.Board.Entities.Configuration;

/// <summary>
/// The <see cref="Output"/> class
/// </summary>
[XmlRoot(ElementName = nameof(Output), IsNullable = false)]
public class Output : InputOutputBase
{
	/// <summary>
	/// The empty <see cref="Output"/> contructor
	/// </summary>
	public Output() : base()
	{
	}

	/// <summary>
	/// The <see cref="Output"/> constructor
	/// </summary>
	/// <param name="midiChannel"></param>
	/// <param name="messageType"></param>
	/// <param name="number"></param>
	public Output(MidiChannel midiChannel, MidiMessageType messageType, int number) : base(midiChannel, messageType, number)
	{
	}
}
