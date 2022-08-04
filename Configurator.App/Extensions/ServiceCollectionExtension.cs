using Configurator.Core.Services;
using Configurator.Core.Services.Interfaces;
using Configurator.Services;
using Configurator.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Configurator.Extensions
{
	/// <summary>
	/// The service collection extension class 
	/// </summary>
	public static class ServiceCollectionExtension
	{
		/// <summary>
		/// The <see cref="ConfigureHostedService(IServiceCollection)"/> method should add an hosted service for the given type
		/// </summary>
		/// <param name="services"></param>
		public static void ConfigureHostedService(this IServiceCollection services)
		{
			services.AddHostedService<ApplicationHostedService>();
		}

		/// <summary>
		/// The <see cref="ConfigureScopedServices(IServiceCollection)"/> method should add scoped services of the type specified
		/// </summary>
		/// <param name="services"></param>
		public static void ConfigureScopedServices(this IServiceCollection services)
		{
			services.AddScoped<IDeviceConfigService, DeviceConfigService>();
			services.AddScoped<IAppConfigService, AppConfigService>();
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
			services.AddSingleton<IUserNotificationService, UserNotificationService>();
		}
	}
}