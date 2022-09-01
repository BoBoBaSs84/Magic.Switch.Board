using Magic.Switch.Board.Core.Models;

namespace Magic.Switch.Board.Core.Contracts.Services;

public interface IEnumService
{
	IReadOnlyList<EnumModel<Enums.MidiMessageType>> GetMidiMessageTypes();
	IReadOnlyList<EnumModel<Enums.MidiChannel>> GetMidiChannels();
	IReadOnlyList<EnumModel<Enums.LoopChannels>> GetLoopChannels();
	IReadOnlyList<EnumModel<Enums.SwitchChannels>> GetSwitchChannels();
	IReadOnlyList<EnumModel<Enums.LogLevel>> GetLogLevels();
}
