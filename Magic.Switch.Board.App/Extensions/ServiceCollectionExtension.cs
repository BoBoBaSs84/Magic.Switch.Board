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
		public static void ConfigureConsoleService(this IServiceCollection services) =>
			services.AddHostedService<ConsoleService>();

		/// <summary>
		/// The <see cref="ConfigureScopedServices(IServiceCollection)"/> method should add scoped services of the type specified
		/// </summary>
		/// <param name="services"></param>
		public static void ConfigureScopedServices(this IServiceCollection services)
		{			
		}

		/// <summary>
		/// The <see cref="ConfigureTransientServices(IServiceCollection)"/> method should add transient services of the type specified
		/// </summary>
		/// <param name="services"></param>
		public static void ConfigureTransientServices(this IServiceCollection services)
		{
			services.AddTransient<IMainService, MainService>();			
		}

		/// <summary>
		/// The <see cref="ConfigureSingletonServices(IServiceCollection)"/> method should add transient services of the type specified
		/// </summary>
		/// <param name="services"></param>
		public static void ConfigureSingletonServices(this IServiceCollection services)
		{
			services.AddSingleton<ILoggerService, LoggerService>();
			services.AddSingleton<IDeviceConfigService, DeviceConfigService>();
			services.AddSingleton<IAppConfigService, AppConfigService>();
		}
	}
}
