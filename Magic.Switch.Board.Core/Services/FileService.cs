using Magic.Switch.Board.Core.Contracts.Services;
using System.Text;
using static Magic.Switch.Board.Core.Properties.Resources;

namespace Magic.Switch.Board.Core.Services;

/// <summary>
/// The <see cref="FileService"/> class implements the mebers of the <see cref="IFileService"/> interface.
/// </summary>
public sealed class FileService : IFileService
{
	private readonly ILoggerService _logger;

	/// <summary>
	/// The <see cref="FileService"/> class constructor.
	/// </summary>
	/// <param name="logger"></param>
	public FileService(ILoggerService logger) => _logger = logger;

	/// <inheritdoc/>
	public (bool success, string message) Delete(string folderPath, string fileName)
	{
		string message;
		try
		{
			if (folderPath is null)
				throw new ArgumentNullException(nameof(folderPath));

			if (fileName is null)
				throw new ArgumentNullException(nameof(fileName));

			string fullpath = Path.Combine(folderPath, fileName);

			if (!FileExists(fullpath))
				throw new ArgumentException(string.Format(Culture, File_Service_Error_File));

			File.Delete(fullpath);
			message = string.Format(Culture, File_Service_File_Deleted, fullpath);
			_logger.Information(message);
			return (true, message);
		}
		catch (Exception ex)
		{
			message = ex.Message;
			_logger.Error(message);
			return (false, message);
		}
	}

	/// <inheritdoc/>
	public (bool success, string content) Read(string folderPath, string fileName)
	{
		string content;
		try
		{
			if (folderPath is null)
				throw new ArgumentNullException(nameof(folderPath));

			if (fileName is null)
				throw new ArgumentNullException(nameof(fileName));

			string fullpath = Path.Combine(folderPath, fileName);

			if (!FileExists(fullpath))
				throw new ArgumentException(string.Format(Culture, File_Service_Error_File));

			content = File.ReadAllText(fullpath);
			_logger.Information(string.Format(Culture, File_Service_File_Read, fullpath));
			return (true, content);
		}
		catch (Exception ex)
		{
			content = ex.Message;
			_logger.Error(content);
			return (false, content);
		}
	}

	/// <inheritdoc/>
	public (bool success, string message) Save(string folderPath, string fileName, string fileContent)
	{
		string message;
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

			string fullpath = Path.Combine(folderPath, fileName);

			File.WriteAllText(fullpath, fileContent, Encoding.UTF8);
			message = string.Format(Culture, File_Service_File_Deleted, fullpath);
			_logger.Information(message);
			return (true, message);
		}
		catch (Exception ex)
		{
			message = ex.Message;
			_logger.Error(message);
			return (false, message);
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