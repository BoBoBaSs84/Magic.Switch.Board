﻿using Magic.Switch.Board.Entities.Configuration.Base;
using System.Xml.Serialization;
using static Magic.Switch.Board.Entities.Enums;

namespace Magic.Switch.Board.Entities.Configuration;

/// <summary>
/// The <see cref="Input"/> class
/// </summary>
[XmlRoot(ElementName = nameof(Input), IsNullable = false)]
public class Input : InputOutputBase
{
	/// <summary>
	/// The empty <see cref="Input"/> contructor
	/// </summary>
	public Input() : base()
	{
	}

	/// <summary>
	/// The <see cref="Input"/> constructor
	/// </summary>
	/// <param name="midiChannel"></param>
	/// <param name="messageType"></param>
	/// <param name="number"></param>
	public Input(MidiChannel midiChannel, MidiMessageType messageType, int number) : base(midiChannel, messageType, number)
	{
	}
}