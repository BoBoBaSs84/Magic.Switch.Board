using Magic.Switch.Board.Core.Models;

using static Magic.Switch.Board.Core.Enums;

namespace Magic.Switch.Board.Core.Contracts.Services;

/// <summary>
/// The <see cref="IEnumService"/> interface exposes the public methods for to obtain all enumerator types.
/// </summary>
public interface IEnumService
{
	/// <summary>
	/// The <see cref="GetMidiMessageTypes"/> method should return a read only list for the enum type <see cref="MidiMessageType"/>.
	/// </summary>
	/// <returns>A read only list of type <see cref="EnumModel{T}"/>.</returns>
	IEnumerable<EnumModel<MidiMessageType>> GetMidiMessageTypes();

	/// <summary>
	/// The <see cref="GetMidiChannels"/> method should return a read only list for the enum type <see cref="MidiChannelType"/>.
	/// </summary>
	/// <returns>A read only list of type <see cref="EnumModel{T}"/>.</returns>
	IEnumerable<EnumModel<MidiChannelType>> GetMidiChannels();

	/// <summary>
	/// The <see cref="GetLoopChannels"/> method should return a read only list for the enum type <see cref="LoopChannelType"/>.
	/// </summary>
	/// <returns>A read only list of type <see cref="EnumModel{T}"/>.</returns>
	IEnumerable<EnumModel<LoopChannelType>> GetLoopChannels();

	/// <summary>
	/// The <see cref="GetSwitchChannels"/> method should return a read only list for the enum type <see cref="SwitchChannelType"/>.
	/// </summary>
	/// <returns>A read only list of type <see cref="EnumModel{T}"/>.</returns>
	IEnumerable<EnumModel<SwitchChannelType>> GetSwitchChannels();

	/// <summary>
	/// The <see cref="GetLogLevels"/> method should return a read only list for the enum type <see cref="LogLevelType"/>.
	/// </summary>
	/// <returns>A read only list of type <see cref="EnumModel{T}"/>.</returns>
	IEnumerable<EnumModel<LogLevelType>> GetLogLevels();
}
