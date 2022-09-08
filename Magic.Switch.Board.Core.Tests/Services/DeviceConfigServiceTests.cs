using Magic.Switch.Board.Core.Contracts.Services;
using Magic.Switch.Board.Core.Exceptions;
using Magic.Switch.Board.Core.Models.Device;

namespace Magic.Switch.Board.Core.Tests.Services;

[TestClass()]
public class DeviceConfigServiceTests : BaseTestUnit
{
	private readonly IDeviceConfigService _deviceConfigService = GetService<IDeviceConfigService>();

	[TestMethod()]
	public void DeviceConfigServiceTestPass()
	{
		// arrange
		IDeviceConfigService? deviceConfigService;
		// act
		deviceConfigService = GetService<IDeviceConfigService>();
		// assert
		Assert.IsNotNull(deviceConfigService);
	}

	[TestMethod()]
	public void DeviceConfigServiceTestFail()
	{
		// arrange
		IDeviceConfigService? deviceConfigService;
		// act
		deviceConfigService = null;
		// assert
		Assert.IsNull(deviceConfigService);
	}

	[TestMethod()]
	public void CreateTestPass()
	{
		// arrange
		Configuration? config;
		// act
		config = _deviceConfigService.Create("UnitTest", "1.0.0.0");
		// assert
		Assert.IsNotNull(config);
	}

	[TestMethod()]
	public void CreateTestFail()
	{
		// arrange
		Configuration? config;
		// act
		config = null;
		// assert
		Assert.IsNull(config);
	}

	[TestMethod()]
	public void CreateTestNameMissingFail()
	{
		// arrange
		Configuration? config;
		try
		{
			// act
			config = _deviceConfigService.Create(null!, "1.0.0.0");
		}
		catch (ServiceException ex)
		{
			// assert
			Assert.AreEqual(ex.InnerException!.Message, "Value cannot be null. (Parameter 'name')");
		}
	}

	[TestMethod()]
	public void CreateTestNameMissingAppVersionFail()
	{
		// arrange
		Configuration? config;
		try
		{
			// act
			config = _deviceConfigService.Create("UnitTest", null!);
		}
		catch (ServiceException ex)
		{
			// assert
			Assert.AreEqual(ex.InnerException!.Message, "Value cannot be null. (Parameter 'applicationVersion')");
		}
	}

	[TestMethod()]
	public void ReadTest()
	{
		Assert.Fail();
	}

	[TestMethod()]
	public void WriteTest()
	{
		Assert.Fail();
	}

	[TestMethod()]
	public void WriteTest1()
	{
		Assert.Fail();
	}
}