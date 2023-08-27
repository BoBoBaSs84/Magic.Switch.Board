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
	IReadOnlyList<EnumModel<MidiMessageType>> GetMidiMessageTypes();
	/// <summary>
	/// The <see cref="GetMidiChannels"/> method should return a read only list for the enum type <see cref="MidiChannel"/>.
	/// </summary>
	/// <returns>A read only list of type <see cref="EnumModel{T}"/>.</returns>
	IReadOnlyList<EnumModel<MidiChannel>> GetMidiChannels();
	/// <summary>
	/// The <see cref="GetLoopChannels"/> method should return a read only list for the enum type <see cref="LoopChannels"/>.
	/// </summary>
	/// <returns>A read only list of type <see cref="EnumModel{T}"/>.</returns>
	IReadOnlyList<EnumModel<LoopChannels>> GetLoopChannels();
	/// <summary>
	/// The <see cref="GetSwitchChannels"/> method should return a read only list for the enum type <see cref="SwitchChannels"/>.
	/// </summary>
	/// <returns>A read only list of type <see cref="EnumModel{T}"/>.</returns>
	IReadOnlyList<EnumModel<SwitchChannels>> GetSwitchChannels();
	/// <summary>
	/// The <see cref="GetLogLevels"/> method should return a read only list for the enum type <see cref="LogLevel"/>.
	/// </summary>
	/// <returns>A read only list of type <see cref="EnumModel{T}"/>.</returns>
	IReadOnlyList<EnumModel<LogLevel>> GetLogLevels();
}
