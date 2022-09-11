using Magic.Switch.Board.Core.Models.Device;
using System.Text;

namespace Magic.Switch.Board.Core.Tests.Services;

[TestClass()]
public class XmlServiceTests : BaseTestUnit
{
	private const string ConfigurationName = "UnitTest";
	private const string ConfigurationVersion = "1.0.0.0";
	private readonly IDeviceConfigService _deviceConfigService = GetService<IDeviceConfigService>();
	private readonly ISerializerDeserializerService _xmlService =
		GetServices<ISerializerDeserializerService>().First(x => x.GetType().Equals(typeof(XmlService)));

	[TestMethod()]
	public void JsonServiceNotNullTest() => Assert.IsNotNull(_xmlService);

	[DataTestMethod()]
	[DataRow(ConfigurationName, ConfigurationVersion)]
	[DataRow(ConfigurationName, ConfigurationVersion, "Utf-8")]
	[DataRow(ConfigurationName, ConfigurationVersion, "Utf-16")]
	[DataRow(ConfigurationName, ConfigurationVersion)]
	[DataRow(null, ConfigurationVersion)]
	[DataRow(ConfigurationName, null)]
	public void DeserializeTest(string configurationName, string configurationVersion, string? encoding = null)
	{
		try
		{
			Configuration newConfig = _deviceConfigService.Create(configurationName, configurationVersion);
			string xmlString = _xmlService.Serialize(newConfig, string.IsNullOrWhiteSpace(encoding) ? null : Encoding.GetEncoding(encoding));
			Configuration? configFromJson = _xmlService.Deserialize<Configuration>(xmlString);
			Assert.IsNotNull(configFromJson);
		}
		catch (ServiceException ex)
		{
			Assert.IsInstanceOfType(ex, typeof(ServiceException));
		}
	}

	[DataTestMethod()]
	[DataRow(ConfigurationName, ConfigurationVersion)]
	[DataRow(null, ConfigurationVersion)]
	[DataRow(ConfigurationName, null)]
	public void SerializeTest(string configurationName, string configurationVersion)
	{
		try
		{
			Configuration config = _deviceConfigService.Create(configurationName, configurationVersion);
			string xmlString = _xmlService.Serialize(config);
			Assert.IsNotNull(xmlString);
		}
		catch (ServiceException ex)
		{
			Assert.IsInstanceOfType(ex, typeof(ServiceException));
		}
	}
}