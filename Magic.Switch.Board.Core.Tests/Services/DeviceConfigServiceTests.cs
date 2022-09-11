using Magic.Switch.Board.Core.Models.Device;
using System.Text;

namespace Magic.Switch.Board.Core.Tests.Services;

[TestClass()]
public class DeviceConfigServiceTests : BaseTestUnit
{
	private readonly IDeviceConfigService _deviceConfigService = GetService<IDeviceConfigService>();

	[TestMethod()]
	public void DeviceConfigServicePassTest()
	{
		IDeviceConfigService? deviceConfigService;
		deviceConfigService = GetService<IDeviceConfigService>();
		Assert.IsNotNull(deviceConfigService);
	}

	[TestMethod()]
	public void DeviceConfigServiceFailTest()
	{
		IDeviceConfigService? deviceConfigService;
		deviceConfigService = null;
		Assert.IsNull(deviceConfigService);
	}

	[TestMethod()]
	public void CreatePassTest()
	{
		Configuration? config;
		config = _deviceConfigService.Create("UnitTest", "1.0.0.0");
		Assert.IsNotNull(config);
	}

	[TestMethod()]
	public void CreateFailTest()
	{
		Configuration? config;
		config = null;
		Assert.IsNull(config);
	}

	[TestMethod()]
	public void CreateNameMissingExceptionTest()
	{
		Configuration? config;
		try
		{
			config = _deviceConfigService.Create(null!, "1.0.0.0");
		}
		catch (ServiceException ex)
		{
			Assert.IsInstanceOfType(ex.InnerException, typeof(ArgumentNullException));
		}
	}

	[TestMethod()]
	public void CreateNameMissingAppVersionExceptionTest()
	{
		Configuration? config;
		try
		{
			config = _deviceConfigService.Create("UnitTest", null!);
		}
		catch (ServiceException ex)
		{
			Assert.IsInstanceOfType(ex.InnerException, typeof(ArgumentNullException));
		}
	}

	[TestMethod()]
	public void CreateExceptionTypeTest()
	{
		Configuration? config;
		try
		{
			config = _deviceConfigService.Create("UnitTest", null!);
		}
		catch (ServiceException ex)
		{
			Assert.IsInstanceOfType(ex, typeof(ServiceException));
		}
	}

	[TestMethod()]
	public void ReadConfigurationFromFileTest()
	{
		try
		{
			Configuration? config = _deviceConfigService.Create("UnitTest", "1.0.0.0");
			bool success = _deviceConfigService.Write("D:\\", "UnitTest.xml", config);
			if (success)
			{
				Configuration? newConfig = _deviceConfigService.Read("D:\\", "UnitTest.xml");
				Assert.IsNotNull(newConfig);
			}
		}
		catch (Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}

	[TestMethod()]
	public void ReadConfigurationFromFileDoesNotExistsTest()
	{
		try
		{
			Configuration? newConfig = _deviceConfigService.Read("D:\\", "UnitTest2.xml");
			Assert.IsNotNull(newConfig);
		}
		catch (ServiceException ex)
		{
			Assert.IsInstanceOfType(ex, typeof(ServiceException));
		}
	}

	[TestMethod()]
	public void WriteConfigurationFileWhithoutEncodingTest()
	{
		try
		{
			Configuration? config = _deviceConfigService.Create("UnitTest", "1.0.0.0");
			bool success = _deviceConfigService.Write("D:\\", "UnitTest.xml", config);
			if (success)
				Assert.IsTrue(success);
		}
		catch (Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}

	[TestMethod()]
	public void WriteConfigurationFileWhithoutEncodingEncodingUtf8Test()
	{
		try
		{
			Configuration? config = _deviceConfigService.Create("UnitTest", "1.0.0.0");
			bool success = _deviceConfigService.Write("D:\\", "UnitTest.xml", config, Encoding.UTF8);
			if (success)
				Assert.IsTrue(success);
		}
		catch (Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}

	[TestMethod()]
	public void WriteConfigurationFileWhithoutEncodingEncodingUniCodeTest()
	{
		try
		{
			Configuration? config = _deviceConfigService.Create("UnitTest", "1.0.0.0");
			bool success = _deviceConfigService.Write("D:\\", "UnitTest.xml", config, Encoding.Unicode);
			if (success)
				Assert.IsTrue(success);
		}
		catch (Exception ex)
		{
			Assert.Fail(ex.Message);
		}
	}
}
