using Magic.Switch.Board.Core.Models;
using static Magic.Switch.Board.Core.Enums;

namespace Magic.Switch.Board.Core.Tests.Services;

[TestClass()]
public class EnumServiceTests : BaseTestUnit
{
	private readonly IEnumService _enumService = GetService<IEnumService>();

	[TestMethod()]
	public void EnumServiceNotNullTest() => Assert.IsNotNull(_enumService);

	[TestMethod()]
	public void GetLogLevelsTestPass()
	{
		IReadOnlyList<EnumModel<LogLevel>>? logLevelList;
		logLevelList = _enumService.GetLogLevels();
		Assert.IsNotNull(logLevelList);
	}

	[TestMethod()]
	public void GetLogLevelsTestFail()
	{
		IReadOnlyList<EnumModel<LogLevel>>? logLevelList;
		logLevelList = null;
		Assert.IsNull(logLevelList);
	}

	[TestMethod()]
	public void GetLoopChannelsTestPass()
	{
		IReadOnlyList<EnumModel<LoopChannels>>? loopChannelList;
		loopChannelList = _enumService.GetLoopChannels();
		Assert.IsNotNull(loopChannelList);
	}

	[TestMethod()]
	public void GetLoopChannelsTestFail()
	{
		IReadOnlyList<EnumModel<LoopChannels>>? loopChannelList;
		loopChannelList = null;
		Assert.IsNull(loopChannelList);
	}

	[TestMethod()]
	public void GetMidiChannelsTestPass()
	{
		IReadOnlyList<EnumModel<MidiChannel>>? midiChannelList;
		midiChannelList = _enumService.GetMidiChannels();
		Assert.IsNotNull(midiChannelList);
	}

	[TestMethod()]
	public void GetMidiChannelsTestFail()
	{
		IReadOnlyList<EnumModel<MidiChannel>>? midiChannelList;
		midiChannelList = null;
		Assert.IsNull(midiChannelList);
	}

	[TestMethod()]
	public void GetMidiMessageTypesTestPass()
	{
		IReadOnlyList<EnumModel<MidiMessageType>>? midiMessageTypeList;
		midiMessageTypeList = _enumService.GetMidiMessageTypes();
		Assert.IsNotNull(midiMessageTypeList);
	}

	[TestMethod()]
	public void GetMidiMessageTypesTestFail()
	{
		IReadOnlyList<EnumModel<MidiMessageType>>? midiMessageTypeList;
		midiMessageTypeList = null;
		Assert.IsNull(midiMessageTypeList);
	}

	[TestMethod()]
	public void GetSwitchChannelsTestPass()
	{
		IReadOnlyList<EnumModel<SwitchChannels>>? switchChannelList;
		switchChannelList = _enumService.GetSwitchChannels();
		Assert.IsNotNull(switchChannelList);
	}

	[TestMethod()]
	public void GetSwitchChannelsTestFail()
	{
		IReadOnlyList<EnumModel<SwitchChannels>>? switchChannelList;
		switchChannelList = null;
		Assert.IsNull(switchChannelList);
	}
}