using Magic.Switch.Board.Core.Models;
using Magic.Switch.Board.Core.Properties;

namespace Magic.Switch.Board.Core.Tests;

[TestClass()]
public class EnumsTests
{
	[TestMethod()]
	public void GetEnumDescriptionTestPass()
	{
		// arrange
		string midiMessageTypeDescription = Enums.MidiMessageType.PCM.GetEnumDescription();
		// act and assert
		Assert.AreEqual(midiMessageTypeDescription, Resources.Enum_MidiMessageType_PCM_Description);
	}

	[TestMethod()]
	public void GetEnumDescriptionTestFail()
	{
		// arrange
		string midiMessageTypeDescription = Enums.MidiMessageType.PCM.GetEnumDescription();
		// act and assert
		Assert.AreNotEqual(midiMessageTypeDescription, Enums.MidiMessageType.PCM.ToString());
	}

	[TestMethod()]
	public void GetEnumNameTestPass()
	{
		// arrange
		string midiMessageTypeName = Enums.MidiMessageType.PCM.GetEnumName();
		// act and assert
		Assert.AreEqual(midiMessageTypeName, Resources.Enum_MidiMessageType_PCM_Name);
	}

	[TestMethod()]
	public void GetEnumNameTestFail()
	{
		// arrange
		string midiMessageTypeName = Enums.MidiMessageType.PCM.GetEnumName();
		// act and assert
		Assert.AreNotEqual(midiMessageTypeName, Enums.MidiMessageType.PCM.ToString());
	}

	[TestMethod()]
	public void GetEnumShortNameTestPass()
	{
		// arrange
		string midiMessageTypeShortName = Enums.MidiMessageType.PCM.GetEnumShortName();
		// act and assert
		Assert.AreEqual(midiMessageTypeShortName, Enums.MidiMessageType.PCM.ToString());
	}

	[TestMethod()]
	public void GetEnumShortNameTestFail()
	{
		// arrange
		string midiMessageTypeShortName = Enums.MidiMessageType.PCM.GetEnumShortName();
		// act and assert
		Assert.AreNotEqual(midiMessageTypeShortName, Enums.MidiMessageType.PCM.GetEnumName());
	}

	[TestMethod()]
	public void GetListFromEnumTestPass()
	{
		// arrange
		Enums.MidiMessageType enumValue = Enums.MidiMessageType.CCM;
		// act
		List<Enums.MidiMessageType> enumList = enumValue.GetListFromEnum();
		// assert
		Assert.AreEqual(enumList.Count, 2);
	}

	[TestMethod()]
	public void GetListFromEnumTestFail()
	{
		// arrange
		Enums.MidiMessageType enumValue = Enums.MidiMessageType.CCM;
		// act
		List<Enums.MidiMessageType> enumList = enumValue.GetListFromEnum();
		// assert
		Assert.AreNotEqual(enumList.Count, 1);
	}

	[TestMethod()]
	public void FlagsToListTestPass()
	{
		// arrange
		Enums.SwitchChannels switchChannels = Enums.SwitchChannels.CH01 | Enums.SwitchChannels.CH02;
		// act
		List<Enums.SwitchChannels> enumFlags = switchChannels.FlagsToList();
		// assert
		Assert.AreEqual(enumFlags.Count, 2);
	}

	[TestMethod()]
	public void FlagsToListTestFail()
	{
		// arrange
		Enums.SwitchChannels switchChannels = Enums.SwitchChannels.CH01;
		// act
		List<Enums.SwitchChannels> enumFlags = switchChannels.FlagsToList();
		// assert
		Assert.AreNotEqual(enumFlags.Count, 2);
	}

	[TestMethod()]
	public void GetEnumsWithDescriptionTestFail()
	{
		// arrange
		Enums.LogLevel enumValue = Enums.LogLevel.None;
		Dictionary<Enums.LogLevel, string> falseDict = new() { { enumValue, Resources.Enum_LogLevel_Critical_Description } };
		// act
		Dictionary<Enums.LogLevel, string> enumDict = enumValue.GetEnumsWithDescription();
		// assert
		Assert.AreNotEqual(enumDict.Count, falseDict.Count);
	}

	[TestMethod()]
	public void GetEnumsWithDescriptionTestPass()
	{
		// arrange
		Enums.LogLevel enumValue = Enums.LogLevel.Critical;
		Dictionary<Enums.LogLevel, string> rightDict = new() { { enumValue, Resources.Enum_LogLevel_Critical_Description } };
		// act
		Dictionary<Enums.LogLevel, string> enumDict = new() { { enumValue, enumValue.GetEnumDescription() } };
		// assert
		Assert.AreEqual(enumDict.Count, rightDict.Count);
	}

	[TestMethod()]
	public void GetEnumModelListTestPass()
	{
		// arrange
		Enums.MidiChannel midiChannel = Enums.MidiChannel.CH01;
		// act
		List<EnumModel<Enums.MidiChannel>> enumModel = midiChannel.GetEnumModelList();
		// assert
		Assert.IsNotNull(enumModel);
	}

	[TestMethod()]
	public void GetEnumModelListTestFail()
	{
		// arrange
		Enums.MidiChannel midiChannel = Enums.MidiChannel.CH01;
		// act
		List<EnumModel<Enums.MidiChannel>> enumModel = midiChannel.GetEnumModelList();
		enumModel = null!;
		// assert
		Assert.IsNull(enumModel);
	}
}