using Magic.Switch.Board.Core.Models;
using System.Diagnostics;
using static Magic.Switch.Board.Core.Enums;

namespace Magic.Switch.Board.Core.Tests;

[TestClass()]
public class EnumsTests
{
	[ClassInitialize]
	public static void ClassInitialize(TestContext context) => Debug.WriteLine(nameof(ClassInitialize));

	[TestMethod()]
	public void GetEnumDescriptionTestPass()
	{
		string midiMessageTypeDescription = MidiMessageType.PCM.GetEnumDescription();
		Assert.AreEqual(midiMessageTypeDescription, Resources.Enum_MidiMessageType_PCM_Description);
	}

	[TestMethod()]
	public void GetEnumDescriptionTestFail()
	{
		string midiMessageTypeDescription = MidiMessageType.PCM.GetEnumDescription();
		Assert.AreNotEqual(midiMessageTypeDescription, MidiMessageType.PCM.ToString());
	}

	[TestMethod()]
	public void GetEnumNameTestPass()
	{
		string midiMessageTypeName = MidiMessageType.PCM.GetEnumName();
		Assert.AreEqual(midiMessageTypeName, Resources.Enum_MidiMessageType_PCM_Name);
	}

	[TestMethod()]
	public void GetEnumNameTestFail()
	{
		string midiMessageTypeName = MidiMessageType.PCM.GetEnumName();
		Assert.AreNotEqual(midiMessageTypeName, MidiMessageType.PCM.ToString());
	}

	[TestMethod()]
	public void GetEnumShortNameTestPass()
	{
		string midiMessageTypeShortName = MidiMessageType.PCM.GetEnumShortName();
		Assert.AreEqual(midiMessageTypeShortName, MidiMessageType.PCM.ToString());
	}

	[TestMethod()]
	public void GetEnumShortNameTestFail()
	{
		string midiMessageTypeShortName = MidiMessageType.PCM.GetEnumShortName();
		Assert.AreNotEqual(midiMessageTypeShortName, MidiMessageType.PCM.GetEnumName());
	}

	[DataTestMethod()]
	[DataRow(MidiMessageType.PCM)]
	[DataRow(MidiMessageType.CCM)]
	public void GetListFromEnumTestPass(MidiMessageType midiMessageType)
	{
		MidiMessageType enumValue = midiMessageType;
		List<MidiMessageType> enumList = enumValue.GetListFromEnum();
		Assert.AreEqual(enumList.Count, 2);
	}

	[DataTestMethod()]
	[DataRow(MidiMessageType.PCM)]
	[DataRow(MidiMessageType.CCM)]
	public void GetListFromEnumTestFail(MidiMessageType midiMessageType)
	{
		MidiMessageType enumValue = midiMessageType;
		List<MidiMessageType> enumList = enumValue.GetListFromEnum();
		Assert.AreNotEqual(enumList.Count, 1);
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
