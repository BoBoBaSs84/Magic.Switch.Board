using static Magic.Switch.Board.Core.Enums;

namespace Magic.Switch.Board.Core.Contracts.Models.BaseTypes.Device;

/// <summary>
/// The <see cref="IInputOutputBase"/> interface.
/// </summary>
/// <remarks>
/// Exposes all the public properties that are relevant for the input and output class.
/// </remarks>
public interface IInputOutputBase
{
	/// <summary>
	/// The <see cref="MidiChannel"/> property, cannot be <see langword="null"/>.
	/// </summary>
	MidiChannelType MidiChannel { get; }

	/// <summary>
	/// The <see cref="MessageType"/> property, cannot be <see langword="null"/>.
	/// </summary>
	MidiMessageType MessageType { get; }

	/// <summary>
	/// The <see cref="Number"/> property.
	/// </summary>
	int Number { get; }
}
