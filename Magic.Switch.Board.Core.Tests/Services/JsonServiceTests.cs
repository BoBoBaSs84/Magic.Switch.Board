using Magic.Switch.Board.Core.Models.Device;

namespace Magic.Switch.Board.Core.Tests.Services;

[TestClass()]
public class JsonServiceTests : BaseTestUnit
{
	private const string ConfigurationName = "UnitTest";
	private const string ConfigurationVersion = "1.0.0.0";
	private readonly IDeviceConfigService _deviceConfigService = GetService<IDeviceConfigService>();
	private readonly ISerializerDeserializerService _jsonService =
		GetServices<ISerializerDeserializerService>().First(x => x.GetType().Equals(typeof(JsonService)));

	[TestMethod()]
	public void JsonServiceNotNullTest() => Assert.IsNotNull(_jsonService);

	[DataTestMethod()]
	[DataRow(ConfigurationName, ConfigurationVersion)]
	[DataRow(null, ConfigurationVersion)]
	[DataRow(ConfigurationName, null)]
	public void DeserializeTest(string configurationName, string configurationVersion)
	{
		try
		{
			Configuration newConfig = _deviceConfigService.Create(configurationName, configurationVersion);
			string jsonString = _jsonService.Serialize(newConfig);
			Configuration? configFromJson = _jsonService.Deserialize<Configuration>(jsonString);
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
			string jsonString = _jsonService.Serialize(config);
			Assert.IsNotNull(jsonString);
		}
		catch (ServiceException ex)
		{
			Assert.IsInstanceOfType(ex, typeof(ServiceException));
		}
	}
}
