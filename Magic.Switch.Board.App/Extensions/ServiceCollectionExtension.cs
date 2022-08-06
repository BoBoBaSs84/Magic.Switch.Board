using Magic.Switch.Board.App.Services;
using Magic.Switch.Board.App.Services.Interfaces;
using Magic.Switch.Board.Services.Configuration;
using Magic.Switch.Board.Services.Configuration.Interfaces;
using Magic.Switch.Board.Services.Logging;
using Magic.Switch.Board.Services.Logging.Interfaces;

namespace Magic.Switch.Board.App.Extensions
{
	internal static class ServiceCollectionExtension
	{
		/// <summary>
		/// The <see cref="ConfigureConsoleService(IServiceCollection)"/> method should add an hosted service for the given type
		/// </summary>
		/// <param name="services"></param>
		internal static void ConfigureConsoleService(this IServiceCollection services) =>
			services.AddHostedService<ConsoleService>();

		/// <summary>
		/// The <see cref="ConfigureScopedServices(IServiceCollection)"/> method should add scoped services of the type specified
		/// </summary>
		/// <param name="services"></param>
		internal static void ConfigureScopedServices(this IServiceCollection services)
		{
			services.AddScoped<IAppConfigService, AppConfigService>();
			services.AddScoped<IDeviceConfigService, DeviceConfigService>();
		}

		/// <summary>
		/// The <see cref="ConfigureTransientServices(IServiceCollection)"/> method should add transient services of the type specified
		/// </summary>
		/// <param name="services"></param>
		internal static void ConfigureTransientServices(this IServiceCollection services)
		{
			services.AddTransient<IMainService, MainService>();			
		}

		/// <summary>
		/// The <see cref="ConfigureSingletonServices(IServiceCollection)"/> method should add transient services of the type specified
		/// </summary>
		/// <param name="services"></param>
		internal static void ConfigureSingletonServices(this IServiceCollection services)
		{
			services.AddSingleton<ILoggerService, LoggerService>();
		}
	}
}
