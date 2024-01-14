using System.Text;

using BB84.Extensions;

using Magic.Switch.Board.Core.Contracts.Services;
using Magic.Switch.Board.Core.Exceptions;

using static Magic.Switch.Board.Core.Properties.Resources;

namespace Magic.Switch.Board.Core.Services;

/// <summary>
/// The <see cref="FileService"/> class implements the mebers of the <see cref="IFileService"/> interface.
/// </summary>
/// <param name="logger">The logger service instance to use.</param>
public sealed class FileService(ILoggerService logger) : IFileService
{
	/// <inheritdoc/>
	/// <exception cref="ServiceException"></exception>
	public void Delete(string folderPath, string fileName)
	{
		string message, fullpath = string.Empty;
		try
		{
			ArgumentException.ThrowIfNullOrWhiteSpace(folderPath, nameof(folderPath));
			ArgumentException.ThrowIfNullOrWhiteSpace(fileName, nameof(fileName));

			fullpath = Path.Combine(folderPath, fileName);

			if (!FileExists(fullpath))
				throw new IOException(File_Service_Error_File);

			File.Delete(fullpath);
			message = File_Service_File_Deleted.Format(Culture, fullpath);
			logger.Information(message);
		}
		catch (Exception ex)
		{
			logger.Error(ex.Message);
			message = Error_While_Deleting_File.Format(Culture, fullpath);
			throw new ServiceException(message, ex);
		}
	}

	/// <inheritdoc/>
	/// <exception cref="ServiceException"></exception>
	public string Read(string folderPath, string fileName)
	{
		string content, fullpath = string.Empty;
		try
		{
			ArgumentException.ThrowIfNullOrWhiteSpace(folderPath, nameof(folderPath));
			ArgumentException.ThrowIfNullOrWhiteSpace(fileName, nameof(fileName));

			fullpath = Path.Combine(folderPath, fileName);

			if (!FileExists(fullpath))
				throw new IOException(File_Service_Error_File);

			content = File.ReadAllText(fullpath);
			logger.Information(File_Service_File_Read.Format(Culture, fullpath));
			return content;
		}
		catch (Exception ex)
		{
			logger.Error(ex.Message);
			content = Error_While_Reading_File.Format(Culture, fullpath);
			throw new ServiceException(content, ex);
		}
	}

	/// <inheritdoc/>
	/// <exception cref="ServiceException"></exception>
	public void Save(string folderPath, string fileName, string fileContent)
	{
		string message;
		string fullpath = string.Empty;
		try
		{
			ArgumentException.ThrowIfNullOrWhiteSpace(folderPath, nameof(folderPath));
			ArgumentException.ThrowIfNullOrWhiteSpace(fileName, nameof(fileName));
			ArgumentException.ThrowIfNullOrWhiteSpace(fileContent, nameof(fileContent));

			if (!DirectoryExists(folderPath))
				throw new IOException(File_Service_Error_Directory);

			fullpath = Path.Combine(folderPath, fileName);

			File.WriteAllText(fullpath, fileContent, Encoding.UTF8);
			message = File_Service_File_Created.Format(Culture, fullpath);
			logger.Information(message);
		}
		catch (Exception ex)
		{
			logger.Error(ex.Message);
			message = Error_While_Creating_File.Format(Culture, fullpath);
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