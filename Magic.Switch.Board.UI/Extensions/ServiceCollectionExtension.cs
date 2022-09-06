using Magic.Switch.Board.Core.Contracts.Services;
using Magic.Switch.Board.Core.Services;
using Magic.Switch.Board.UI.Logic.ViewModels;
using Magic.Switch.Board.UI.Views;
using Microsoft.Extensions.DependencyInjection;

namespace Magic.Switch.Board.UI.Extensions;

internal static class ServiceCollectionExtension
{
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
		_ = services.AddSingleton<ILoggerService, FileLoggerService>();
		_ = services.AddSingleton<IFileService, FileService>();
		_ = services.AddSingleton<IDeviceConfigService, DeviceConfigService>();
		_ = services.AddSingleton<IEnumService, EnumService>();
		_ = services.AddSingleton<ISerializerDeserializerService, XmlService>();
	}

	public static void ConfigureViewsModels(this IServiceCollection services)
	{
		services.AddTransient<MainViewModel>();
		//services.AddTransient<ConfigurationVM>();
		//services.AddTransient<ChannelVM>();
	}

	public static void ConfigureViews(this IServiceCollection services)
	{
		services.AddTransient<MainWindow>();
	}
}
