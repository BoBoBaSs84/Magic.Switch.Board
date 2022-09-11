using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Magic.Switch.Board.Core.Tests;

[TestClass]
public class BaseTestUnit
{
	public static IHost? TestHost { get; set; }

	[AssemblyInitialize]
	public static void ClassInitialize(TestContext context) => TestHost = AssemblyInit(context);

	public static IHost AssemblyInit(TestContext context)
	{
		IHostBuilder host = Host.CreateDefaultBuilder()
			.ConfigureServices(services =>
			{
				_ = services.AddSingleton<ILoggerService, ConsoleLoggerService>();
				_ = services.AddSingleton<IFileService, FileService>();
				_ = services.AddSingleton<ISerializerDeserializerService, JsonService>();
				_ = services.AddSingleton<ISerializerDeserializerService, XmlService>();
				_ = services.AddSingleton<IEnumService, EnumService>();
				_ = services.AddSingleton<IDeviceConfigService, DeviceConfigService>();
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
