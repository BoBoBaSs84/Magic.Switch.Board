using Magic.Switch.Board.Core.Contracts.Services;
using Magic.Switch.Board.Core.Models;

namespace Magic.Switch.Board.Core.Services;

public class EnumService : IEnumService
{
	public IReadOnlyList<EnumModel<Enums.LogLevel>> GetLogLevels() =>
		Enums.LogLevel.None.GetEnumModelList();

	public IReadOnlyList<EnumModel<Enums.LoopChannels>> GetLoopChannels() =>
		Enums.LoopChannels.CH01.GetEnumModelList();

	public IReadOnlyList<EnumModel<Enums.MidiChannel>> GetMidiChannels() =>
		Enums.MidiChannel.CH01.GetEnumModelList();

	public IReadOnlyList<EnumModel<Enums.MidiMessageType>> GetMidiMessageTypes() =>
		Enums.MidiMessageType.PCM.GetEnumModelList();

	public IReadOnlyList<EnumModel<Enums.SwitchChannels>> GetSwitchChannels() =>
		Enums.SwitchChannels.CH01.GetEnumModelList();
}
