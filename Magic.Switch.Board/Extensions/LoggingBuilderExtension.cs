using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;

namespace Magic.Switch.Board.Extensions
{
	internal static class LoggingBuilderExtension
	{
		/// <summary>
		/// The <see cref="ConfigureConsoleLogging(ILoggingBuilder)"/> method should configure the console logging behavior.
		/// </summary>
		/// <remarks>
		/// See the 'appsettings.json' file for additional options regarding the enviroment specific settings.
		/// </remarks>
		/// <param name="logging"></param>
		public static void ConfigureConsoleLogging(this ILoggingBuilder logging)
		{
			logging.AddSimpleConsole(options =>
			{
				options.SingleLine = true;
				options.ColorBehavior = LoggerColorBehavior.Enabled;
				options.IncludeScopes = true;
				options.UseUtcTimestamp = true;
			});
		}
	}
}
