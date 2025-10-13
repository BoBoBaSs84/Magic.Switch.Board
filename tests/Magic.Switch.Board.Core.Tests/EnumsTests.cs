using Magic.Switch.Board.Core.Models;
using Magic.Switch.Board.Core.Properties;

using static Magic.Switch.Board.Core.Enums;

namespace Magic.Switch.Board.Core.Tests;

[TestClass()]
public class EnumsTests
{
	[TestMethod]
	[DataRow(MidiMessageType.PCM)]
	[DataRow(MidiMessageType.CCM)]
	public void GetMidiMessageTypeEnumDescriptionTest(MidiMessageType midiMessageType) =>
		Assert.AreNotEqual(midiMessageType.GetEnumDescription(), midiMessageType.ToString());

	[TestMethod]
	[DataRow(MidiMessageType.PCM)]
	[DataRow(MidiMessageType.CCM)]
	public void GetMidiMessageTypeEnumNameTest(MidiMessageType midiMessageType) =>
		Assert.AreNotEqual(midiMessageType.GetEnumName(), midiMessageType.ToString());

	[TestMethod]
	[DataRow(LogLevelType.None)]
	[DataRow(LogLevelType.Trace)]
	[DataRow(LogLevelType.Debug)]
	[DataRow(LogLevelType.Information)]
	[DataRow(LogLevelType.Warning)]
	[DataRow(LogLevelType.Error)]
	[DataRow(LogLevelType.Critical)]
	public void GetLogLevelEnumDescriptionTest(LogLevelType logLevel) =>
		Assert.AreNotEqual(logLevel.GetEnumDescription(), logLevel.ToString());

	[TestMethod]
	[DataRow(LoopChannelType.CH01)]
	[DataRow(LoopChannelType.CH02)]
	[DataRow(LoopChannelType.CH03)]
	[DataRow(LoopChannelType.CH04)]
	[DataRow(LoopChannelType.CH05)]
	[DataRow(LoopChannelType.CH06)]
	[DataRow(LoopChannelType.CH07)]
	[DataRow(LoopChannelType.CH08)]
	public void GetLoopChannelsEnumNameTest(LoopChannelType loopChannels) =>
		Assert.AreNotEqual(loopChannels.GetEnumName(), loopChannels.ToString());

	[TestMethod]
	[DataRow(SwitchChannelType.CH01)]
	[DataRow(SwitchChannelType.CH02)]
	[DataRow(SwitchChannelType.CH03)]
	[DataRow(SwitchChannelType.CH04)]
	[DataRow(SwitchChannelType.CH05)]
	[DataRow(SwitchChannelType.CH06)]
	[DataRow(SwitchChannelType.CH07)]
	[DataRow(SwitchChannelType.CH08)]
	public void GetSwitchChannelsEnumNameTest(SwitchChannelType switchChannels) =>
		Assert.AreNotEqual(switchChannels.GetEnumName(), switchChannels.ToString());

	[TestMethod]
	[DataRow(MidiMessageType.PCM)]
	[DataRow(MidiMessageType.CCM)]
	public void GetMidiMessageTypeEnumShortNameTest(MidiMessageType midiMessageType) =>
		Assert.AreEqual(midiMessageType.GetEnumShortName(), midiMessageType.ToString());

	[TestMethod()]
	public void GetEnumShortNameTestFail()
	{
		string midiMessageTypeShortName = MidiMessageType.PCM.GetEnumShortName();
		Assert.AreNotEqual(midiMessageTypeShortName, MidiMessageType.PCM.GetEnumName());
	}

	[TestMethod]
	[DataRow(MidiMessageType.PCM)]
	[DataRow(MidiMessageType.CCM)]
	public void GetListFromMidiMessageTypeEnumTest(MidiMessageType midiMessageType)
	{
		List<MidiMessageType> enumList = midiMessageType.GetListFromEnum();
		Assert.HasCount(2, enumList);
	}

	[TestMethod]
	[DataRow(SwitchChannelType.CH01)]
	[DataRow(SwitchChannelType.CH08)]
	public void GetListFromSwitchChannelsEnumTest(SwitchChannelType switchChannels)
	{
		List<SwitchChannelType> enumList = switchChannels.GetListFromEnum();
		Assert.HasCount(8, enumList);
	}

	[TestMethod]
	[DataRow(LoopChannelType.CH01)]
	[DataRow(LoopChannelType.CH08)]
	public void GetListFromLoopChannelsEnumTest(LoopChannelType loopChannels)
	{
		List<LoopChannelType> enumList = loopChannels.GetListFromEnum();
		Assert.HasCount(8, enumList);
	}

	[TestMethod]
	[DataRow(MidiChannelType.CH01)]
	[DataRow(MidiChannelType.CH16)]
	public void GetListFromMidiChannelEnumTest(MidiChannelType midiChannel)
	{
		List<MidiChannelType> enumList = midiChannel.GetListFromEnum();
		Assert.HasCount(16, enumList);
	}

	[TestMethod]
	[DataRow(SwitchChannelType.CH01 | SwitchChannelType.CH02)]
	[DataRow(SwitchChannelType.CH03 | SwitchChannelType.CH04)]
	[DataRow(SwitchChannelType.CH05 | SwitchChannelType.CH06)]
	[DataRow(SwitchChannelType.CH07 | SwitchChannelType.CH08)]
	public void FlagsToListTestPass(SwitchChannelType switchChannels)
	{
		List<SwitchChannelType> enumFlags = switchChannels.FlagsToList();
		Assert.HasCount(2, enumFlags);
	}

	[TestMethod]
	[DataRow(SwitchChannelType.CH01)]
	[DataRow(SwitchChannelType.CH02 | SwitchChannelType.CH03)]
	[DataRow(SwitchChannelType.CH04 | SwitchChannelType.CH05 | SwitchChannelType.CH06)]
	public void FlagsToListTestFail(SwitchChannelType switchChannels)
	{
		List<SwitchChannelType> enumFlags = switchChannels.FlagsToList();
		Assert.AreNotEqual(0, enumFlags.Count);
	}

	[TestMethod()]
	public void GetEnumsWithDescriptionTestFail()
	{
		LogLevelType enumValue = LogLevelType.None;
		Dictionary<LogLevelType, string> falseDict = new() { { enumValue, Resources.Enum_LogLevel_Critical_Description } };
		Dictionary<LogLevelType, string> enumDict = enumValue.GetEnumsWithDescription();
		Assert.AreNotEqual(enumDict.Count, falseDict.Count);
	}

	[TestMethod()]
	public void GetEnumsWithDescriptionTestPass()
	{
		LogLevelType enumValue = LogLevelType.Critical;
		Dictionary<LogLevelType, string> rightDict = new() { { enumValue, Resources.Enum_LogLevel_Critical_Description } };
		Dictionary<LogLevelType, string> enumDict = new() { { enumValue, enumValue.GetEnumDescription() } };
		Assert.HasCount(enumDict.Count, rightDict);
	}

	[TestMethod()]
	public void GetEnumModelListTestPass()
	{
		MidiChannelType midiChannel = MidiChannelType.CH01;
		List<EnumModel<MidiChannelType>> enumModel = midiChannel.GetEnumModelList();
		Assert.IsNotNull(enumModel);
	}

	[TestMethod()]
	public void GetEnumModelListTestFail()
	{
		MidiChannelType midiChannel = MidiChannelType.CH01;
		_ = midiChannel.GetEnumModelList();
		List<EnumModel<MidiChannelType>>? enumModel = default;
		Assert.IsNull(enumModel);
	}
}
