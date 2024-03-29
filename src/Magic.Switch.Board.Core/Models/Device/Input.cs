﻿using System.Xml.Serialization;

using Magic.Switch.Board.Core.Models.BaseTypes.Device;

using static Magic.Switch.Board.Core.Enums;

namespace Magic.Switch.Board.Core.Models.Device;

/// <summary>
/// The <see cref="Input"/> class.
/// </summary>
/// <remarks>
/// Inherits from the <see cref="InputOutputBase"/> class.
/// </remarks>
[XmlRoot(ElementName = nameof(Input), IsNullable = false)]
public class Input : InputOutputBase
{
	/// <summary>
	/// Initializes a new instance of the <see cref="Input"/> class.
	/// </summary>
	public Input() : base()
	{
	}

	/// <summary>
	/// The standard <see cref="Input"/> class constructor.
	/// </summary>
	/// <param name="midiChannel"></param>
	/// <param name="messageType"></param>
	/// <param name="number"></param>
	public Input(MidiChannelType midiChannel, MidiMessageType messageType, int number) : base(midiChannel, messageType, number)
	{
	}
}