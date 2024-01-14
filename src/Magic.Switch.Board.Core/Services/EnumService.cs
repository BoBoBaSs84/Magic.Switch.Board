using Magic.Switch.Board.Core.Contracts.Services;
using Magic.Switch.Board.Core.Exceptions;
using Magic.Switch.Board.Core.Models;

using static Magic.Switch.Board.Core.Enums;

namespace Magic.Switch.Board.Core.Services;

/// <summary>
/// The <see cref="EnumService"/> class implements the members of the <see cref="IEnumService"/> interface.
/// </summary>
public class EnumService : IEnumService
{
	/// <inheritdoc cref="IEnumService.GetLogLevels"/>
	/// <exception cref="ServiceException"></exception>
	public IEnumerable<EnumModel<LogLevelType>> GetLogLevels()
		=> LogLevelType.None.GetEnumModelList();

	/// <inheritdoc cref="IEnumService.GetLoopChannels"/>
	/// <exception cref="ServiceException"></exception>
	public IEnumerable<EnumModel<LoopChannelType>> GetLoopChannels()
		=> LoopChannelType.CH01.GetEnumModelList();

	/// <inheritdoc cref="IEnumService.GetMidiChannels"/>
	/// <exception cref="ServiceException"></exception>
	public IEnumerable<EnumModel<MidiChannelType>> GetMidiChannels()
		=> MidiChannelType.CH01.GetEnumModelList();

	/// <inheritdoc cref="IEnumService.GetMidiMessageTypes"/>
	/// <exception cref="ServiceException"></exception>
	public IEnumerable<EnumModel<MidiMessageType>> GetMidiMessageTypes()
		=> MidiMessageType.PCM.GetEnumModelList();

	/// <inheritdoc cref="IEnumService.GetSwitchChannels"/>
	/// <exception cref="ServiceException"></exception>
	public IEnumerable<EnumModel<SwitchChannelType>> GetSwitchChannels()
		=> SwitchChannelType.CH01.GetEnumModelList();
}
