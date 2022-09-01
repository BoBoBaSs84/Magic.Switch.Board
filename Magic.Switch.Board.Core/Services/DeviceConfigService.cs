using Magic.Switch.Board.Core.Contracts.Services;
using Magic.Switch.Board.Core.Exceptions;
using Magic.Switch.Board.Core.Helpers;
using Magic.Switch.Board.Core.Models.Device;
using System.Text;
using static Magic.Switch.Board.Core.Properties.Resources;

namespace Magic.Switch.Board.Core.Services;

/// <summary>
/// The <see cref="DeviceConfigService"/> class implements the members of the <see cref="IDeviceConfigService"/> interface.
/// </summary>
public sealed class DeviceConfigService : IDeviceConfigService
{
	private readonly ILoggerService _logger;
	private readonly IFileService _fileService;

	/// <summary>
	/// Initializes a new instance of the <see cref="DeviceConfigService"/> class.
	/// </summary>
	/// <param name="logger">The logger service.</param>
	/// <param name="fileService">The file service.</param>
	public DeviceConfigService(ILoggerService logger, IFileService fileService)
	{
		_logger = logger;
		_fileService = fileService;
	}

	/// <inheritdoc/>	
	/// <exception cref="ArgumentNullException"></exception>
	/// <exception cref="ServiceException"></exception>
	public Configuration Create(string name, string applicationVersion)
	{
		try
		{
			if (name is null)
				throw new ArgumentNullException(nameof(name));
			if (applicationVersion is null)
				throw new ArgumentNullException(nameof(applicationVersion));
			return new(name, applicationVersion);
		}
		catch (Exception ex)
		{
			_logger.Error(ex.Message);
			string message = string.Format(Culture, Error_While_Creating_A_New_Device_Configuration);
			throw new ServiceException(message, ex);
		}
	}

	/// <inheritdoc/>
	/// <exception cref="ServiceException"></exception>
	public Configuration? Read(string folderPath, string fileName)
	{
		try
		{
			string content = _fileService.Read(folderPath, fileName);
			if (string.IsNullOrWhiteSpace(content))
				return default;

			XmlHelper<Configuration> serializer = new();
			return serializer.Deserialize(content);
		}
		catch (Exception ex)
		{
			_logger.Error(ex.Message);
			string message = string.Format(Culture, Error_While_Reading_A_Existing_Device_Configuration);
			throw new ServiceException(message, ex);
		}
	}

	/// <inheritdoc/>
	/// <exception cref="ArgumentNullException"></exception>
	/// <exception cref="ServiceException"></exception>
	public bool Write(string folderPath, string fileName, Configuration configuration, Encoding? encoding)
	{
		try
		{
			if (configuration is null)
				throw new ArgumentNullException(nameof(configuration));

			XmlHelper<Configuration> serializer = new();
			string fileContent = serializer.StringSerialize(configuration, encoding);

			_fileService.Save(folderPath, fileName, fileContent);
			return true;
		}
		catch (Exception ex)
		{
			_logger.Error(ex.Message);
			string message = string.Format(Culture, Error_While_Saving_Device_Configuration);
			throw new ServiceException(message, ex);
		}
	}

	/// <inheritdoc/>
	/// <exception cref="ArgumentNullException"></exception>
	/// <exception cref="ServiceException"></exception>
	public bool Write(string folderPath, string fileName, Configuration configuration) =>
		Write(folderPath, fileName, configuration, Encoding.UTF8);
}