﻿using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

using Magic.Switch.Board.Core.Contracts.Models.BaseTypes.Device;
using Magic.Switch.Board.Core.Models.Device;
using Magic.Switch.Board.Core.Properties;

using static Magic.Switch.Board.Core.Enums;
using static Magic.Switch.Board.Core.Properties.Resources;

namespace Magic.Switch.Board.Core.Models.BaseTypes.Device;

/// <summary>
/// The <see cref="InputOutputBase"/> class.
/// </summary>
[XmlInclude(typeof(Input))]
[XmlInclude(typeof(Output))]
public abstract class InputOutputBase : IInputOutputBase
{
	/// <summary>
	/// Initializes a new instance of the <see cref="InputOutputBase"/> class.
	/// </summary>
	protected InputOutputBase()
	{
		MidiChannel = MidiChannelType.CH01;
		MessageType = MidiMessageType.PCM;
		Number = 1;
	}

	/// <summary>
	/// The standard <see cref="InputOutputBase"/> class constructor.
	/// </summary>
	/// <param name="midiChannel"></param>
	/// <param name="messageType"></param>
	/// <param name="number"></param>
	protected InputOutputBase(MidiChannelType midiChannel, MidiMessageType messageType, int number)
	{
		MidiChannel = midiChannel;
		MessageType = messageType;
		Number = number;
	}

	/// <inheritdoc cref="IInputOutputBase.MidiChannel"/>
	[Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = nameof(Model_Field_Required_Generic))]
	[JsonPropertyName(nameof(MidiChannel))]
	[XmlAttribute(AttributeName = nameof(MidiChannel))]
	public MidiChannelType MidiChannel { get; set; }

	/// <inheritdoc cref="IInputOutputBase.MessageType"/>
	[Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = nameof(Model_Field_Required_Generic))]
	[JsonPropertyName(nameof(MessageType))]
	[XmlAttribute(AttributeName = nameof(MessageType))]
	public MidiMessageType MessageType { get; set; }

	/// <inheritdoc cref="IInputOutputBase.Number"/>
	[Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = nameof(Model_Field_Required_Generic))]
	[Range(0, 127, ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = nameof(Model_Field_Range_Generic))]
	[JsonPropertyName(nameof(Number))]
	[XmlAttribute(AttributeName = nameof(Number))]
	public int Number { get; set; }
}