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
		IEnumService? enumService;
		enumService = GetService<IEnumService>();
		Assert.IsNotNull(enumService);
	}

	[TestMethod()]
	public void EnumServiceTestFail()
	{
		IEnumService? enumService;
		enumService = null;
		Assert.IsNull(enumService);
	}

	[TestMethod()]
	public void GetLogLevelsTestPass()
	{
		IReadOnlyList<EnumModel<Enums.LogLevel>>? logLevelList;
		logLevelList = _enumService.GetLogLevels();
		Assert.IsNotNull(logLevelList);
	}

	[TestMethod()]
	public void GetLogLevelsTestFail()
	{
		IReadOnlyList<EnumModel<Enums.LogLevel>>? logLevelList;
		logLevelList = null;
		Assert.IsNull(logLevelList);
	}

	[TestMethod()]
	public void GetLoopChannelsTestPass()
	{
		IReadOnlyList<EnumModel<Enums.LoopChannels>>? loopChannelList;
		loopChannelList = _enumService.GetLoopChannels();
		Assert.IsNotNull(loopChannelList);
	}

	[TestMethod()]
	public void GetLoopChannelsTestFail()
	{
		IReadOnlyList<EnumModel<Enums.LoopChannels>>? loopChannelList;
		loopChannelList = null;
		Assert.IsNull(loopChannelList);
	}

	[TestMethod()]
	public void GetMidiChannelsTestPass()
	{
		IReadOnlyList<EnumModel<Enums.MidiChannel>>? midiChannelList;
		midiChannelList = _enumService.GetMidiChannels();
		Assert.IsNotNull(midiChannelList);
	}

	[TestMethod()]
	public void GetMidiChannelsTestFail()
	{
		IReadOnlyList<EnumModel<Enums.MidiChannel>>? midiChannelList;
		midiChannelList = null;
		Assert.IsNull(midiChannelList);
	}

	[TestMethod()]
	public void GetMidiMessageTypesTestPass()
	{
		IReadOnlyList<EnumModel<Enums.MidiMessageType>>? midiMessageTypeList;
		midiMessageTypeList = _enumService.GetMidiMessageTypes();
		Assert.IsNotNull(midiMessageTypeList);
	}

	[TestMethod()]
	public void GetMidiMessageTypesTestFail()
	{
		IReadOnlyList<EnumModel<Enums.MidiMessageType>>? midiMessageTypeList;
		midiMessageTypeList = null;
		Assert.IsNull(midiMessageTypeList);
	}

	[TestMethod()]
	public void GetSwitchChannelsTestPass()
	{
		IReadOnlyList<EnumModel<Enums.SwitchChannels>>? switchChannelList;
		switchChannelList = _enumService.GetSwitchChannels();
		Assert.IsNotNull(switchChannelList);
	}

	[TestMethod()]
	public void GetSwitchChannelsTestFail()
	{
		IReadOnlyList<EnumModel<Enums.SwitchChannels>>? switchChannelList;
		switchChannelList = null;
		Assert.IsNull(switchChannelList);
	}
}