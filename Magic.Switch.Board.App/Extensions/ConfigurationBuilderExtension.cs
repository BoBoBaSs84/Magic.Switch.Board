namespace Magic.Switch.Board.App.Extensions
{
	internal static class ConfigurationBuilderExtension
	{
		/// <summary>
		/// The <see cref="ConfigureCommandLine(IConfigurationBuilder, string[])"/> method should configure the command line behavior
		/// </summary>
		/// <param name="configurationBuilder"></param>
		/// <param name="args"></param>
		internal static void ConfigureCommandLine(this IConfigurationBuilder configurationBuilder, string[] args)
		{
			configurationBuilder.AddCommandLine(args, new Dictionary<string, string>
			{
				{ "-a1", "arg1" },
				{ "-a2", "arg2" }
			});
		}

		/// <summary>
		/// The <see cref="ConfigureUserSecrets(IConfigurationBuilder)"/> method should configure the user secret settings
		/// </summary>
		/// <param name="configurationBuilder"></param>
		internal static void ConfigureUserSecrets(this IConfigurationBuilder configurationBuilder)
		{
			configurationBuilder.AddUserSecrets<Program>(true, true);
		}
	}
}
