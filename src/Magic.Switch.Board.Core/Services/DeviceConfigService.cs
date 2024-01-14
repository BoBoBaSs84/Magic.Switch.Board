using System.Text;

using BB84.Extensions.Serialization;

using Magic.Switch.Board.Core.Contracts.Services;
using Magic.Switch.Board.Core.Exceptions;
using Magic.Switch.Board.Core.Models.Device;
using Magic.Switch.Board.Core.Properties;

namespace Magic.Switch.Board.Core.Services;

/// <summary>
/// The <see cref="DeviceConfigService"/> class implements the members of the <see cref="IDeviceConfigService"/> interface.
/// </summary>
/// <param name="logger">The logger service to use.</param>
/// <param name="fileService">The file service to use.</param>
public sealed class DeviceConfigService(ILoggerService logger, IFileService fileService) : IDeviceConfigService
{
	/// <inheritdoc/>	
	/// <exception cref="ArgumentNullException"></exception>
	/// <exception cref="ServiceException"></exception>
	public Configuration Create(string name, string applicationVersion)
	{
		try
		{
			ArgumentException.ThrowIfNullOrWhiteSpace(name, nameof(name));
			ArgumentException.ThrowIfNullOrWhiteSpace(applicationVersion, nameof(applicationVersion));

			return new(name, applicationVersion);
		}
		catch (Exception ex)
		{
			logger.Error(ex.Message);
			string message = Resources.Error_While_Creating_A_New_Device_Configuration;
			throw new ServiceException(message, ex);
		}
	}

	/// <inheritdoc/>
	/// <exception cref="ServiceException"></exception>
	public Configuration? Read(string folderPath, string fileName)
	{
		try
		{
			ArgumentException.ThrowIfNullOrWhiteSpace(folderPath, nameof(folderPath));
			ArgumentException.ThrowIfNullOrWhiteSpace(fileName, nameof(fileName));

			string content = fileService.Read(folderPath, fileName);

			return string.IsNullOrWhiteSpace(content)
				? default
				: content.FromXml<Configuration>();
		}
		catch (Exception ex)
		{
			logger.Error(ex.Message);
			string message = Resources.Error_While_Reading_A_Existing_Device_Configuration;
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
			ArgumentException.ThrowIfNullOrWhiteSpace(folderPath, nameof(folderPath));
			ArgumentException.ThrowIfNullOrWhiteSpace(fileName, nameof(fileName));
			ArgumentNullException.ThrowIfNull(configuration, nameof(configuration));

			string fileContent = configuration.ToXml();
			fileService.Save(folderPath, fileName, fileContent);
			return true;
		}
		catch (Exception ex)
		{
			logger.Error(ex.Message);
			string message = Resources.Error_While_Saving_Device_Configuration;
			throw new ServiceException(message, ex);
		}
	}

	/// <inheritdoc/>
	/// <exception cref="ArgumentNullException"></exception>
	/// <exception cref="ServiceException"></exception>
	public bool Write(string folderPath, string fileName, Configuration configuration) =>
		Write(folderPath, fileName, configuration, Encoding.UTF8);
}