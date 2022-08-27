using Magic.Switch.Board.Core.Contracts.Services;
using Magic.Switch.Board.Core.Helpers;
using Magic.Switch.Board.Core.Models.Device;
using System.Text;

namespace Magic.Switch.Board.Core.Services;

/// <summary>
/// The <see cref="DeviceConfigService"/> class implements the members of the <see cref="IDeviceConfigService"/> interface.
/// </summary>
public sealed class DeviceConfigService : IDeviceConfigService
{
	private readonly ILoggerService _logger;
	private readonly IFileService _fileService;

	/// <summary>
	/// The standard <see cref="DeviceConfigService"/> class constructor.
	/// </summary>
	/// <param name="logger"></param>
	/// <param name="fileService"></param>
	public DeviceConfigService(ILoggerService logger, IFileService fileService)
	{
		_logger = logger;
		_fileService = fileService;
	}

	/// <inheritdoc/>	
	public Configuration Create(string applicationVersion) =>
		applicationVersion is null
		? throw new ArgumentNullException(nameof(applicationVersion))
		: (new(applicationVersion));

	/// <inheritdoc/>
	public Configuration? Read(string folderPath, string fileName)
	{
		try
		{
			(bool success, string content) = _fileService.Read(folderPath, fileName);
			if (!success)
				return default;
			XmlHelper<Configuration> serializer = new();
			return serializer.Deserialize(content);
		}
		catch (Exception ex)
		{
			_logger.Error(ex.Message);
		}
		return default;
	}

	/// <inheritdoc/>
	public (bool success, string message) Write(string folderPath, string fileName, Configuration configuration, Encoding? encoding)
	{
		try
		{
			if (configuration is null)
				throw new ArgumentNullException(nameof(configuration));

			XmlHelper<Configuration> serializer = new();
			string fileContent = serializer.StringSerialize(configuration, encoding);

			(bool success, string message) result = _fileService.Save(folderPath, fileName, fileContent);
			return result;
		}
		catch (Exception ex)
		{
			_logger.Error(ex.Message);
			return (false, ex.Message);
		}
	}

	/// <inheritdoc/>
	public (bool success, string message) Write(string folderPath, string fileName, Configuration configuration) =>
		Write(folderPath, fileName, configuration, Encoding.UTF8);
}