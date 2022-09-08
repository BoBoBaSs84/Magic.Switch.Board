using Magic.Switch.Board.Core.Contracts.Services;
using Magic.Switch.Board.Core.Services;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Magic.Switch.Board.Core.Tests;

[TestClass]
public class BaseTestUnit
{
	public static IHost? TestHost { get; set; }

	[AssemblyInitialize]
	public static void ClassInitialize(TestContext context)
	{
		TestHost = AssemblyInit(context);
	}

	public static IHost AssemblyInit(TestContext context)
	{
		IHostBuilder host = Host.CreateDefaultBuilder()
			.ConfigureServices(services =>
			{
				services.AddSingleton<ILoggerService, ConsoleLoggerService>();
				services.AddSingleton<IFileService, FileService>();
				services.AddSingleton<ISerializerDeserializerService, JsonService>();
				services.AddSingleton<ISerializerDeserializerService, XmlService>();
				services.AddSingleton<IEnumService, EnumService>();
				services.AddSingleton<IDeviceConfigService, DeviceConfigService>();
			});
		return host.Start();
	}

	public static T GetService<T>() => (T)TestHost.Services.GetService(typeof(T));
}
