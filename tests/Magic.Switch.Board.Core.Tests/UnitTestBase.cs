using Magic.Switch.Board.Core.Contracts.Services;
using Magic.Switch.Board.Core.Services;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Magic.Switch.Board.Core.Tests;

[TestClass]
public abstract class UnitTestBase
{
	private static ServiceProvider? s_serviceProvider;

	[AssemblyInitialize]
	public static void AssemblyInitialize(TestContext context)
	{
		s_serviceProvider = CreateServiceProvider();
	}

	private static ServiceProvider CreateServiceProvider()
	{
		IServiceCollection services = new ServiceCollection();

		services.TryAddSingleton<ILoggerService, ConsoleLoggerService>();
		services.TryAddSingleton<IFileService, FileService>();
		services.TryAddSingleton<IEnumService, EnumService>();
		services.TryAddSingleton<IDeviceConfigService, DeviceConfigService>();

		return services.BuildServiceProvider();
	}

	/// <summary>
	/// Returns the requested service if it was registered within the service collection.
	/// </summary>
	/// <typeparam name="TService">The type of service we are operating on.</typeparam>
	/// <returns>The requested service.</returns>
	/// <exception cref="ArgumentException">If the requested service is not registered.</exception>
	protected static TService GetService<TService>() where TService : class =>
		s_serviceProvider?.GetService(typeof(TService)) is not TService service
		? throw new ArgumentException($"{typeof(TService)} needs to be registered service.")
		: service;
}
