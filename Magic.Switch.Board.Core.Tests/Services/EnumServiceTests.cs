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
		IEnumService enumService;
		// act
		enumService = GetService<IEnumService>();
		// assert
		Assert.IsNotNull(enumService);
	}

	[TestMethod()]
	public void EnumServiceTestFail()
	{
		// arrange
		IEnumService enumService;
		// act
		enumService = null!;
		// assert
		Assert.IsNull(enumService);
	}

	[TestMethod()]
	public void GetLogLevelsTestPass()
	{
		// arrange
		IReadOnlyList<EnumModel<Enums.LogLevel>> logLevelList;
		// act
		logLevelList = _enumService.GetLogLevels();
		// assert
		Assert.IsNotNull(logLevelList);
	}

	[TestMethod()]
	public void GetLogLevelsTestFail()
	{
		// arrange
		IReadOnlyList<EnumModel<Enums.LogLevel>> logLevelList;
		// act
		logLevelList = null!;
		// assert
		Assert.IsNull(logLevelList);
	}

	[TestMethod()]
	public void GetLoopChannelsTest()
	{
		Assert.Fail();
	}

	[TestMethod()]
	public void GetMidiChannelsTest()
	{
		Assert.Fail();
	}

	[TestMethod()]
	public void GetMidiMessageTypesTest()
	{
		Assert.Fail();
	}

	[TestMethod()]
	public void GetSwitchChannelsTest()
	{
		Assert.Fail();
	}
}