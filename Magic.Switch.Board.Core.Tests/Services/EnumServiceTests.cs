using Magic.Switch.Board.Core.Contracts.Services;
using Magic.Switch.Board.Core.Models;

namespace Magic.Switch.Board.Core.Tests.Services;

[TestClass()]
public class EnumServiceTests : BaseTestUnit
{
	private readonly IEnumService _enumService = GetService<IEnumService>();

	[TestMethod()]
	public void EnumServiceTestPass()
	{
		// arrange
		IEnumService? enumService;
		// act
		enumService = GetService<IEnumService>();
		// assert
		Assert.IsNotNull(enumService);
	}

	[TestMethod()]
	public void EnumServiceTestFail()
	{
		// arrange
		IEnumService? enumService;
		// act
		enumService = null;
		// assert
		Assert.IsNull(enumService);
	}

	[TestMethod()]
	public void GetLogLevelsTestPass()
	{
		// arrange
		IReadOnlyList<EnumModel<Enums.LogLevel>>? logLevelList;
		// act
		logLevelList = _enumService.GetLogLevels();
		// assert
		Assert.IsNotNull(logLevelList);
	}

	[TestMethod()]
	public void GetLogLevelsTestFail()
	{
		// arrange
		IReadOnlyList<EnumModel<Enums.LogLevel>>? logLevelList;
		// act
		logLevelList = null;
		// assert
		Assert.IsNull(logLevelList);
	}

	[TestMethod()]
	public void GetLoopChannelsTestPass()
	{
		// arrange
		IReadOnlyList<EnumModel<Enums.LoopChannels>>? loopChannelList;
		// act
		loopChannelList = _enumService.GetLoopChannels();
		// assert
		Assert.IsNotNull(loopChannelList);
	}

	[TestMethod()]
	public void GetLoopChannelsTestFail()
	{
		// arrange
		IReadOnlyList<EnumModel<Enums.LoopChannels>>? loopChannelList;
		// act
		loopChannelList = null;
		// assert
		Assert.IsNull(loopChannelList);
	}

	[TestMethod()]
	public void GetMidiChannelsTestPass()
	{
		// arrange
		IReadOnlyList<EnumModel<Enums.MidiChannel>>? midiChannelList;
		// act
		midiChannelList = _enumService.GetMidiChannels();
		// assert
		Assert.IsNotNull(midiChannelList);
	}

	[TestMethod()]
	public void GetMidiChannelsTestFail()
	{
		// arrange
		IReadOnlyList<EnumModel<Enums.MidiChannel>>? midiChannelList;
		// act
		midiChannelList = null;
		// assert
		Assert.IsNull(midiChannelList);
	}

	[TestMethod()]
	public void GetMidiMessageTypesTestPass()
	{
		// arrange
		IReadOnlyList<EnumModel<Enums.MidiMessageType>>? midiMessageTypeList;
		// act
		midiMessageTypeList = _enumService.GetMidiMessageTypes();
		// assert
		Assert.IsNotNull(midiMessageTypeList);
	}

	[TestMethod()]
	public void GetMidiMessageTypesTestFail()
	{
		// arrange
		IReadOnlyList<EnumModel<Enums.MidiMessageType>>? midiMessageTypeList;
		// act
		midiMessageTypeList = null;
		// assert
		Assert.IsNull(midiMessageTypeList);
	}

	[TestMethod()]
	public void GetSwitchChannelsTestPass()
	{
		// arrange
		IReadOnlyList<EnumModel<Enums.SwitchChannels>>? switchChannelList;
		// act
		switchChannelList = _enumService.GetSwitchChannels();
		// assert
		Assert.IsNotNull(switchChannelList);
	}

	[TestMethod()]
	public void GetSwitchChannelsTestFail()
	{
		// arrange
		IReadOnlyList<EnumModel<Enums.SwitchChannels>>? switchChannelList;
		// act
		switchChannelList = null;
		// assert
		Assert.IsNull(switchChannelList);
	}
}