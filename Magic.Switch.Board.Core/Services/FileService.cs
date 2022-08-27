using Magic.Switch.Board.Core.Contracts.Services;
using System.Text;

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
				throw new ArgumentException($"File does not exists.");

			File.Delete(fullpath);
			message = "File deleted.";
			_logger.Information($"{message} {fullpath}");
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
				throw new ArgumentException($"File does not exists.");

			content = File.ReadAllText(fullpath);
			_logger.Information($"File read. {fullpath}");
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
				throw new ArgumentException($"Directory does not exists.");

			File.WriteAllText(Path.Combine(folderPath, fileName), fileContent, Encoding.UTF8);
			message = "File created.";
			_logger.Information($"{message} {Path.Combine(folderPath, fileName)}");
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