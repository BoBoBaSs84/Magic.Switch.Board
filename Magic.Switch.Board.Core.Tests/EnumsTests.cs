using Magic.Switch.Board.Core.Models;
using System.Diagnostics;
using static Magic.Switch.Board.Core.Enums;

namespace Magic.Switch.Board.Core.Tests;

[TestClass()]
public class EnumsTests
{
	[ClassInitialize]
	public static void ClassInitialize(TestContext context) => Debug.WriteLine(nameof(ClassInitialize));

	[DataTestMethod()]
	[DataRow(MidiMessageType.PCM)]
	[DataRow(MidiMessageType.CCM)]
	public void GetMidiMessageTypeEnumDescriptionTest(MidiMessageType midiMessageType) => 
		Assert.AreNotEqual(midiMessageType.GetEnumDescription(), midiMessageType.ToString());

	[DataTestMethod()]
	[DataRow(MidiMessageType.PCM)]
	[DataRow(MidiMessageType.CCM)]
	public void GetMidiMessageTypeEnumNameTest(MidiMessageType midiMessageType) =>
		Assert.AreNotEqual(midiMessageType.GetEnumName(), midiMessageType.ToString());

	[DataTestMethod]
	[DataRow(LogLevel.None)]
	[DataRow(LogLevel.Trace)]
	[DataRow(LogLevel.Debug)]
	[DataRow(LogLevel.Information)]
	[DataRow(LogLevel.Warning)]
	[DataRow(LogLevel.Error)]
	[DataRow(LogLevel.Critical)]
	public void GetLogLevelEnumDescriptionTest(LogLevel logLevel) =>
		Assert.AreNotEqual(logLevel.GetEnumDescription(), logLevel.ToString());

	[DataTestMethod]
	[DataRow(LoopChannels.CH01)]
	[DataRow(LoopChannels.CH02)]
	[DataRow(LoopChannels.CH03)]
	[DataRow(LoopChannels.CH04)]
	[DataRow(LoopChannels.CH05)]
	[DataRow(LoopChannels.CH06)]
	[DataRow(LoopChannels.CH07)]
	[DataRow(LoopChannels.CH08)]
	public void GetLoopChannelsEnumNameTest(LoopChannels loopChannels) =>
		Assert.AreNotEqual(loopChannels.GetEnumName(), loopChannels.ToString());

	[DataTestMethod]
	[DataRow(SwitchChannels.CH01)]
	[DataRow(SwitchChannels.CH02)]
	[DataRow(SwitchChannels.CH03)]
	[DataRow(SwitchChannels.CH04)]
	[DataRow(SwitchChannels.CH05)]
	[DataRow(SwitchChannels.CH06)]
	[DataRow(SwitchChannels.CH07)]
	[DataRow(SwitchChannels.CH08)]
	public void GetSwitchChannelsEnumNameTest(SwitchChannels switchChannels) =>
		Assert.AreNotEqual(switchChannels.GetEnumName(), switchChannels.ToString());

	[DataTestMethod()]
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

	[DataTestMethod()]
	[DataRow(MidiMessageType.PCM)]
	[DataRow(MidiMessageType.CCM)]
	public void GetListFromMidiMessageTypeEnumTest(MidiMessageType midiMessageType)
	{
		List<MidiMessageType> enumList = midiMessageType.GetListFromEnum();
		Assert.AreEqual(enumList.Count, 2);
	}

	[DataTestMethod()]
	[DataRow(SwitchChannels.CH01)]
	[DataRow(SwitchChannels.CH08)]
	public void GetListFromSwitchChannelsEnumTest(SwitchChannels switchChannels)
	{
		List<SwitchChannels> enumList = switchChannels.GetListFromEnum();
		Assert.AreEqual(enumList.Count, 8);
	}

	[DataTestMethod()]
	[DataRow(LoopChannels.CH01)]
	[DataRow(LoopChannels.CH08)]
	public void GetListFromLoopChannelsEnumTest(LoopChannels loopChannels)
	{
		List<LoopChannels> enumList = loopChannels.GetListFromEnum();
		Assert.AreEqual(enumList.Count, 8);
	}

	[DataTestMethod()]
	[DataRow(MidiChannel.CH01)]
	[DataRow(MidiChannel.CH16)]
	public void GetListFromMidiChannelEnumTest(MidiChannel midiChannel)
	{
		List<MidiChannel> enumList = midiChannel.GetListFromEnum();
		Assert.AreEqual(enumList.Count, 16);
	}

	[DataTestMethod()]
	[DataRow(SwitchChannels.CH01 | SwitchChannels.CH02)]
	[DataRow(SwitchChannels.CH03 | SwitchChannels.CH04)]
	[DataRow(SwitchChannels.CH05 | SwitchChannels.CH06)]
	[DataRow(SwitchChannels.CH07 | SwitchChannels.CH08)]
	public void FlagsToListTestPass(SwitchChannels switchChannels)
	{
		List<SwitchChannels> enumFlags = switchChannels.FlagsToList();
		Assert.AreEqual(enumFlags.Count, 2);
	}

	[DataTestMethod()]
	[DataRow(SwitchChannels.CH01)]
	[DataRow(SwitchChannels.CH02 | SwitchChannels.CH03)]
	[DataRow(SwitchChannels.CH04 | SwitchChannels.CH05 | SwitchChannels.CH06)]
	public void FlagsToListTestFail(SwitchChannels switchChannels)
	{
		List<SwitchChannels> enumFlags = switchChannels.FlagsToList();
		Assert.AreNotEqual(enumFlags.Count, 0);
	}

	[TestMethod()]
	public void GetEnumsWithDescriptionTestFail()
	{
		LogLevel enumValue = LogLevel.None;
		Dictionary<LogLevel, string> falseDict = new() { { enumValue, Resources.Enum_LogLevel_Critical_Description } };
		Dictionary<LogLevel, string> enumDict = enumValue.GetEnumsWithDescription();
		Assert.AreNotEqual(enumDict.Count, falseDict.Count);
	}

	[TestMethod()]
	public void GetEnumsWithDescriptionTestPass()
	{
		LogLevel enumValue = LogLevel.Critical;
		Dictionary<LogLevel, string> rightDict = new() { { enumValue, Resources.Enum_LogLevel_Critical_Description } };
		Dictionary<LogLevel, string> enumDict = new() { { enumValue, enumValue.GetEnumDescription() } };
		Assert.AreEqual(enumDict.Count, rightDict.Count);
	}

	[TestMethod()]
	public void GetEnumModelListTestPass()
	{
		MidiChannel midiChannel = MidiChannel.CH01;
		List<EnumModel<MidiChannel>> enumModel = midiChannel.GetEnumModelList();
		Assert.IsNotNull(enumModel);
	}

	[TestMethod()]
	public void GetEnumModelListTestFail()
	{
		MidiChannel midiChannel = MidiChannel.CH01;
		List<EnumModel<MidiChannel>>? enumModel = midiChannel.GetEnumModelList();
		enumModel = default;
		Assert.IsNull(enumModel);
	}
}
