using Magic.Switch.Board.Services.Device;
using Magic.Switch.Board.Services.Device.Interfaces;
using Magic.Switch.Board.Services.Logging;
using Magic.Switch.Board.Services.Logging.Interfaces;
using Magic.Switch.Board.Views;
using Microsoft.Extensions.DependencyInjection;

namespace Magic.Switch.Board.Extensions;

internal static class ServiceCollectionExtension
{
	/// <summary>
	/// The <see cref="ConfigureScopedServices(IServiceCollection)"/> method should add scoped services of the type specified
	/// </summary>
	/// <param name="services"></param>
	public static void ConfigureScopedServices(this IServiceCollection services)
	{
		services.AddSingleton<IDeviceConfigService, DeviceConfigService>();
	}

	/// <summary>
	/// The <see cref="ConfigureTransientServices(IServiceCollection)"/> method should add transient services of the type specified
	/// </summary>
	/// <param name="services"></param>
	public static void ConfigureTransientServices(this IServiceCollection services)
	{
	}

	/// <summary>
	/// The <see cref="ConfigureSingletonServices(IServiceCollection)"/> method should add transient services of the type specified
	/// </summary>
	/// <param name="services"></param>
	public static void ConfigureSingletonServices(this IServiceCollection services)
	{
		services.AddSingleton<ILoggerService, FileLoggerService>();
	}

	public static void ConfigureViewsModels(this IServiceCollection services)
	{
		services.AddTransient<MainWindow>();
	}
}
