namespace Magic.Switch.Board.App.Extensions
{
	internal static class ServiceCollectionExtension
	{
		/// <summary>
		/// The <see cref="ConfigureApplicationHost(IServiceCollection)"/> method should add an hosted service for the given type
		/// </summary>
		/// <param name="services"></param>
		public static void ConfigureApplicationHost(this IServiceCollection services) =>
			services.AddHostedService<ApplicationHost>();

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
		}

		/// <summary>
		/// The <see cref="ConfigureSingletonServices(IServiceCollection)"/> method should add transient services of the type specified
		/// </summary>
		/// <param name="services"></param>
		public static void ConfigureSingletonServices(this IServiceCollection services)
		{
		}
	}
}
