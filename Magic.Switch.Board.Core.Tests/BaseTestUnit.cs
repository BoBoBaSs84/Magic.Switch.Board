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

	/// <summary>
	/// The method should return the requested service.
	/// </summary>
	/// <typeparam name="TService">The requested service.</typeparam>
	/// <returns>The registered service.</returns>
	/// <exception cref="ArgumentException">If the requested service is not registered.</exception>
	public static TService GetService<TService>() where TService : class =>
		TestHost!.Services.GetService(typeof(TService)) is not TService service
		? throw new ArgumentException($"{typeof(TService)} needs to be registered service.")
		: service;
}
