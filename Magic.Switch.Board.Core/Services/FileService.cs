using System.Text;

using Magic.Switch.Board.Core.Contracts.Services;
using Magic.Switch.Board.Core.Exceptions;

using static Magic.Switch.Board.Core.Properties.Resources;

namespace Magic.Switch.Board.Core.Services;

/// <summary>
/// The <see cref="FileService"/> class implements the mebers of the <see cref="IFileService"/> interface.
/// </summary>
public sealed class FileService : IFileService
{
	private readonly ILoggerService _logger;

	/// <summary>
	/// Initializes a new instance of the <see cref="FileService"/> class.
	/// </summary>
	/// <param name="logger"></param>
	public FileService(ILoggerService logger) => _logger = logger;

	/// <inheritdoc/>
	/// <exception cref="ArgumentNullException"></exception>
	/// <exception cref="ArgumentException"></exception>
	/// <exception cref="ServiceException"></exception>
	public void Delete(string folderPath, string fileName)
	{
		string message;
		string fullpath = string.Empty;
		try
		{
			if (folderPath is null)
				throw new ArgumentNullException(nameof(folderPath));

			if (fileName is null)
				throw new ArgumentNullException(nameof(fileName));

			fullpath = Path.Combine(folderPath, fileName);

			if (!FileExists(fullpath))
				throw new ArgumentException(string.Format(Culture, File_Service_Error_File));

			File.Delete(fullpath);
			message = string.Format(Culture, File_Service_File_Deleted, fullpath);
			_logger.Information(message);
		}
		catch (Exception ex)
		{
			_logger.Error(ex.Message);
			message = string.Format(Culture, Error_While_Deleting_File, fullpath);
			throw new ServiceException(message, ex);
		}
	}

	/// <inheritdoc/>
	/// <exception cref="ArgumentNullException"></exception>
	/// <exception cref="ArgumentException"></exception>
	/// <exception cref="ServiceException"></exception>
	public string Read(string folderPath, string fileName)
	{
		string content;
		string fullpath = string.Empty;
		try
		{
			if (folderPath is null)
				throw new ArgumentNullException(nameof(folderPath));

			if (fileName is null)
				throw new ArgumentNullException(nameof(fileName));

			fullpath = Path.Combine(folderPath, fileName);

			if (!FileExists(fullpath))
				throw new ArgumentException(string.Format(Culture, File_Service_Error_File));

			content = File.ReadAllText(fullpath);
			_logger.Information(string.Format(Culture, File_Service_File_Read, fullpath));
			return content;
		}
		catch (Exception ex)
		{
			_logger.Error(ex.Message);
			content = string.Format(Culture, Error_While_Reading_File, fullpath);
			throw new ServiceException(content, ex);
		}
	}

	/// <inheritdoc/>
	/// <exception cref="ArgumentNullException"></exception>
	/// <exception cref="ArgumentException"></exception>
	/// <exception cref="ServiceException"></exception>
	public void Save(string folderPath, string fileName, string fileContent)
	{
		string message;
		string fullpath = string.Empty;
		try
		{
			if (folderPath is null)
				throw new ArgumentNullException(nameof(folderPath));

			if (fileName is null)
				throw new ArgumentNullException(nameof(fileName));

			if (fileContent is null)
				throw new ArgumentNullException(nameof(fileContent));

			if (!DirectoryExists(folderPath))
				throw new ArgumentException(string.Format(Culture, File_Service_Error_Directory));

			fullpath = Path.Combine(folderPath, fileName);

			File.WriteAllText(fullpath, fileContent, Encoding.UTF8);
			message = string.Format(Culture, File_Service_File_Created, fullpath);
			_logger.Information(message);
		}
		catch (Exception ex)
		{
			_logger.Error(ex.Message);
			message = string.Format(Culture, Error_While_Creating_File, fullpath);
			throw new ServiceException(message, ex);
		}
	}

	/// <summary>
	/// The <see cref="DirectoryExists(string)"/> method check if the directory exists.
	/// </summary>
	/// <param name="folderPath"></param>
	/// <returns><see langword="true"/> or <see langword="false"/> depending on the outcome.</returns>
	private static bool DirectoryExists(string folderPath) =>
		Directory.Exists(folderPath);

	/// <summary>
	/// The <see cref="FileExists(string)"/> method checks if the file exists.
	/// </summary>
	/// <param name="fullFilePath">The full file path is folder name and file name.</param>
	/// <returns><see langword="true"/> or <see langword="false"/> depending on the outcome.</returns>
	private static bool FileExists(string fullFilePath) =>
		File.Exists(fullFilePath);
}