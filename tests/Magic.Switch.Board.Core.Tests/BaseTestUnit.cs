using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Magic.Switch.Board.Core.Tests;

[TestClass]
public class BaseTestUnit
{
	protected static IHost? TestHost { get; set; }

	[AssemblyInitialize]
	public static void AssemblyInitialize(TestContext context)
	{
		Debug.WriteLine(nameof(AssemblyInitialize));
		TestHost = AssemblyInit(context);
	}

	[ClassInitialize]
	public static void ClassInitialize(TestContext context) => Debug.WriteLine(nameof(ClassInitialize));

	private static IHost AssemblyInit(TestContext context)
	{
		Debug.WriteLine(context.TestName);

		IHostBuilder host = Host.CreateDefaultBuilder()
			.ConfigureServices(services =>
			{
				_ = services.AddSingleton<ILoggerService, ConsoleLoggerService>();
				_ = services.AddSingleton<IFileService, FileService>();
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
	protected static TService GetService<TService>() where TService : class =>
		TestHost!.Services.GetService(typeof(TService)) is not TService service
		? throw new ArgumentException($"{typeof(TService)} needs to be registered service.")
		: service;

	/// <summary>
	/// The method should return the requested services.
	/// </summary>
	/// <typeparam name="TService">The requested service.</typeparam>
	/// <returns>The registered services.</returns>
	/// <exception cref="ArgumentException">If the requested service is not registered.</exception>
	protected static IEnumerable<TService> GetServices<TService>() where TService : class =>
		TestHost!.Services.GetServices<TService>() is not IEnumerable<TService> services
		? throw new ArgumentException($"{typeof(TService)} needs to be registered service.")
		: services;
}
