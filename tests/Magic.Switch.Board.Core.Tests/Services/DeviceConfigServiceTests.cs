using System.Text;

using Magic.Switch.Board.Core.Contracts.Services;
using Magic.Switch.Board.Core.Exceptions;
using Magic.Switch.Board.Core.Models.Device;

namespace Magic.Switch.Board.Core.Tests.Services;

[TestClass()]
public class DeviceConfigServiceTests : BaseTestUnit
{
	private readonly IDeviceConfigService _deviceConfigService = GetService<IDeviceConfigService>();
	private const string ConfigurationFileName = "DeviceConfiguration.xml";
	private const string ConfigurationName = "UnitTest";
	private const string ConfigurationVersion = "1.0.0.0";
	private const string FolderPath = "D:\\";

	[TestMethod()]
	public void DeviceConfigServiceNotNullTest() => Assert.IsNotNull(_deviceConfigService);

	[DataTestMethod()]
	[DataRow(ConfigurationName, ConfigurationVersion)]
	[DataRow(null, ConfigurationVersion)]
	[DataRow(ConfigurationName, null)]
	public void CreateConfigurationTest(string configurationName, string configurationVersinon)
	{
		try
		{
			Configuration? config;
			config = _deviceConfigService.Create(configurationName, configurationVersinon);
			Assert.IsNotNull(config);
		}
		catch (ServiceException ex)
		{
			Assert.IsInstanceOfType(ex, typeof(ServiceException));
		}
	}

	[DataTestMethod()]
	[DataRow(ConfigurationName, ConfigurationVersion, ConfigurationFileName)]
	[DataRow(null, ConfigurationVersion, ConfigurationFileName)]
	[DataRow(ConfigurationName, null, ConfigurationFileName)]
	[DataRow(ConfigurationName, ConfigurationVersion, null)]
	public void ReadConfigurationTest(string configuratioName, string configurationVersion, string configurationFileName)
	{
		try
		{
			Configuration? config = _deviceConfigService.Create(configuratioName, configurationVersion);
			bool success = _deviceConfigService.Write(FolderPath, configurationFileName, config);
			if (success)
			{
				Configuration? newConfig = _deviceConfigService.Read(FolderPath, configurationFileName);
				Assert.IsNotNull(newConfig);
			}
		}
		catch (ServiceException ex)
		{
			Assert.IsInstanceOfType(ex, typeof(ServiceException));
		}
	}

	[DataTestMethod()]
	[DataRow(ConfigurationName, ConfigurationVersion, ConfigurationFileName)]
	[DataRow(null, ConfigurationVersion, ConfigurationFileName)]
	[DataRow(ConfigurationName, null, ConfigurationFileName)]
	[DataRow(ConfigurationName, ConfigurationVersion, null)]
	public void WriteConfigurationWhithoutEncodingTest(string configuratioName, string configurationVersion, string configurationFileName)
	{
		try
		{
			Configuration? config = _deviceConfigService.Create(configuratioName, configurationVersion);
			bool success = _deviceConfigService.Write(FolderPath, configurationFileName, config);
			if (success)
				Assert.IsTrue(success);
		}
		catch (ServiceException ex)
		{
			Assert.IsInstanceOfType(ex, typeof(ServiceException));
		}
	}

	[DataTestMethod()]
	[DataRow(ConfigurationName, ConfigurationVersion, ConfigurationFileName, "Utf-8")]
	[DataRow(ConfigurationName, ConfigurationVersion, ConfigurationFileName, "UniCode")]
	[DataRow(ConfigurationName, ConfigurationVersion, ConfigurationFileName, "Utf-16")]
	[DataRow(ConfigurationName, ConfigurationVersion, ConfigurationFileName, "Utf-32")]
	public void WriteConfigurationWithEncodingTest(string configuratioName, string configurationVersion, string configurationFileName, string encoding)
	{
		try
		{
			Configuration? config = _deviceConfigService.Create(configuratioName, configurationVersion);
			bool success = _deviceConfigService.Write(FolderPath, configurationFileName, config, Encoding.GetEncoding(encoding));
			if (success)
				Assert.IsTrue(success);
		}
		catch (ServiceException ex)
		{
			Assert.IsInstanceOfType(ex, typeof(ServiceException));
		}
	}

	[TestCleanup()]
	public void CleanUp()
	{
		string filePath = Path.Combine(FolderPath, ConfigurationFileName);
		if (File.Exists(filePath))
			File.Delete(filePath);
	}
}
