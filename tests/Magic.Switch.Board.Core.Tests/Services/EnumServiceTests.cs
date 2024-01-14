using Magic.Switch.Board.Core.Contracts.Services;
using Magic.Switch.Board.Core.Models;

using static Magic.Switch.Board.Core.Enums;

namespace Magic.Switch.Board.Core.Tests.Services;

[TestClass()]
public class EnumServiceTests : BaseTestUnit
{
	private readonly IEnumService _enumService = GetService<IEnumService>();

	[TestMethod]
	public void EnumServiceIsNotNullTest()
		=> Assert.IsNotNull(_enumService);

	[TestMethod]
	public void GetLogLevelsTestPass()
	{
		IEnumerable<EnumModel<LogLevelType>>? levelTypes;

		levelTypes = _enumService.GetLogLevels();

		Assert.IsNotNull(levelTypes);
		Assert.IsTrue(levelTypes.Any());
	}

	[TestMethod]
	public void GetLoopChannelsTestPass()
	{
		IEnumerable<EnumModel<LoopChannelType>>? loopChannelTypes;

		loopChannelTypes = _enumService.GetLoopChannels();

		Assert.IsNotNull(loopChannelTypes);
		Assert.IsTrue(loopChannelTypes.Any());
	}

	[TestMethod]
	public void GetMidiChannelsTestPass()
	{
		IEnumerable<EnumModel<MidiChannelType>>? midiChannelList;
		midiChannelList = _enumService.GetMidiChannels();
		Assert.IsNotNull(midiChannelList);
	}

	[TestMethod]
	public void GetMidiMessageTypesTestPass()
	{
		IEnumerable<EnumModel<MidiMessageType>>? midiMessageTypes;

		midiMessageTypes = _enumService.GetMidiMessageTypes();

		Assert.IsNotNull(midiMessageTypes);
		Assert.IsTrue(midiMessageTypes.Any());
	}

	[TestMethod()]
	public void GetSwitchChannelsTestPass()
	{
		IEnumerable<EnumModel<SwitchChannelType>>? switchChannelList;

		switchChannelList = _enumService.GetSwitchChannels();

		Assert.IsNotNull(switchChannelList);
		Assert.IsTrue(switchChannelList.Any());
	}
}
