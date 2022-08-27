using Magic.Switch.Board.Models.Device;
using Magic.Switch.Board.Services.Device.Interfaces;
using Magic.Switch.Board.Services.Helpers;
using Magic.Switch.Board.Services.Logging.Interfaces;
using System.Text;
using static Magic.Switch.Board.Services.Statics;

namespace Magic.Switch.Board.Services.Device;

/// <summary>
/// The <see cref="DeviceConfigService"/> class implements the members of the <see cref="IDeviceConfigService"/> interface.
/// </summary>
public sealed class DeviceConfigService : IDeviceConfigService
{
	private readonly ILoggerService logger;

	/// <summary>
	/// The <see cref="DeviceConfigService"/> class constructor.
	/// </summary>
	/// <param name="logger"></param>
	public DeviceConfigService(ILoggerService logger) => this.logger = logger;

	/// <inheritdoc/>	
	public Configuration Create(string applicationVersion)
	{
		if (applicationVersion is null)
			throw new ArgumentNullException(nameof(applicationVersion));
		return new(applicationVersion);
	}

	/// <inheritdoc/>
	public Configuration? Read()
	{
		Configuration? configuration = default;
		try
		{
			configuration = XmlHelper<Configuration>.ReadFile(DeviceConfigFileName);
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
		if (configuration is null)
			throw new ArgumentNullException(nameof(configuration));

		bool success = false;
		try
		{
			success = XmlHelper<Configuration>.WriteFile(DeviceConfigFileName, configuration, encoding);
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
		if (configuration is null)
			throw new ArgumentNullException(nameof(configuration));

		bool success = false;
		try
		{
			success = XmlHelper<Configuration>.WriteFile(DeviceConfigFileName, configuration, Encoding.UTF8);
		}
		catch (Exception ex)
		{
			logger.Error($"{ex.Message} | {ex.InnerException} | {ex.StackTrace}");
		}
		return success;
	}
}