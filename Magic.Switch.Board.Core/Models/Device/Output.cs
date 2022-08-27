using Magic.Switch.Board.Core.Models.Device.Base;
using System.Xml.Serialization;
using static Magic.Switch.Board.Core.Enums;

namespace Magic.Switch.Board.Core.Models.Device;

/// <summary>
/// The <see cref="Output"/> class.
/// </summary>
/// <remarks>
/// Inherits from the <see cref="InputOutputBase"/> class.
/// </remarks>
[XmlRoot(ElementName = nameof(Output), IsNullable = false)]
public class Output : InputOutputBase
{
	/// <summary>
	/// The empty <see cref="Output"/> class contructor.
	/// </summary>
	public Output() : base()
	{
	}

	/// <summary>
	/// The standard <see cref="Output"/> class constructor.
	/// </summary>
	/// <param name="midiChannel"></param>
	/// <param name="messageType"></param>
	/// <param name="number"></param>
	public Output(MidiChannel midiChannel, MidiMessageType messageType, int number) : base(midiChannel, messageType, number)
	{
	}
}
