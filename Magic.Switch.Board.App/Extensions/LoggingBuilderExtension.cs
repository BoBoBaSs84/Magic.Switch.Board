using Microsoft.Extensions.Logging.Console;

namespace Magic.Switch.Board.App.Extensions
{
	internal static class LoggingBuilderExtension
	{
		/// <summary>
		/// The <see cref="ConfigureConsoleLogging(ILoggingBuilder)"/> method should configure the console logging behavior.
		/// </summary>
		/// <remarks>
		/// See the 'appsettings.json' file for additional options regarding the enviroment specific settings.
		/// </remarks>
		/// <param name="loggingBuilder"></param>
		internal static void ConfigureConsoleLogging(this ILoggingBuilder loggingBuilder)
		{
			loggingBuilder.AddSimpleConsole(options =>
			{
				options.SingleLine = true;
				options.ColorBehavior = LoggerColorBehavior.Enabled;
				options.IncludeScopes = true;
				options.UseUtcTimestamp = true;
			});
		}
	}
}
