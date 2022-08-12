using Magic.Switch.Board.Models.Application;
using Magic.Switch.Board.Services.Application.Interfaces;
using Magic.Switch.Board.Services.Helpers;
using Magic.Switch.Board.Services.Logging.Interfaces;
using System.Text;
using static Magic.Switch.Board.Services.Statics;

namespace Magic.Switch.Board.Services.Application;

/// <summary>
/// The <see cref="ConfigurationService"/> class implements the members of the <see cref="IConfigurationService"/> interface
/// </summary>
public sealed class ConfigurationService : IConfigurationService
{
	private readonly ILoggerService logger;

	/// <summary>
	/// The <see cref="ConfigurationService"/> class constructor.
	/// </summary>
	/// <param name="logger"></param>
	public ConfigurationService(ILoggerService logger) => this.logger = logger;

	/// <inheritdoc/>
	public Configuration Create(string applicationVersion) => new(applicationVersion);

	/// <inheritdoc/>
	public Configuration? Read()
	{
		Configuration configuration = default!;
		try
		{
			configuration = XmlHelper<Configuration>.ReadFile(AppConfigFileName)!;
		}
		catch (Exception ex)
		{
			logger.Error($"{ex.Message} | {ex.InnerException} | {ex.StackTrace}");
		}
		return configuration;
	}

	/// <inheritdoc/>
	public bool Write(Configuration configuration, Encoding? encoding)
	{
		bool success = false;
		try
		{
			success = XmlHelper<Configuration>.WriteFile(AppConfigFileName, configuration, encoding);
		}
		catch (Exception ex)
		{
			logger.Error($"{ex.Message} | {ex.InnerException} | {ex.StackTrace}");
		}
		return success;
	}

	/// <inheritdoc/>
	public bool Write(Configuration configuration)
	{
		bool success = false;
		try
		{
			success = XmlHelper<Configuration>.WriteFile(AppConfigFileName, configuration, Encoding.UTF8);
		}
		catch (Exception ex)
		{
			logger.Error($"{ex.Message} | {ex.InnerException} | {ex.StackTrace}");
		}
		return success;
	}
}