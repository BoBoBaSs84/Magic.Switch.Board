using Microsoft.Extensions.Configuration;

namespace Magic.Switch.Board.Extensions;

internal static class ConfigurationBuilderExtension
{
	/// <summary>
	/// The <see cref="ConfigureUserSecrets(IConfigurationBuilder)"/> method should configure the user secret settings
	/// </summary>
	/// <param name="configuration"></param>
	public static void ConfigureUserSecrets(this IConfigurationBuilder configuration) =>
		configuration.AddUserSecrets<App>(true, true);
}
