namespace Magic.Switch.Board.Core.Contracts.Services;

/// <summary>
/// The <see cref="IFileService"/> interface.
/// </summary>
public interface IFileService
{
	/// <summary>
	/// The <see cref="Read(string, string)"/> method should be used for reading a file.
	/// </summary>
	/// <remarks>
	/// Will throw an exception if <paramref name="fileName"/> or <paramref name="folderPath"/> is <see langword="null"/>.
	/// </remarks>
	/// <param name="folderPath"></param>
	/// <param name="fileName"></param>
	/// <returns><see langword="true"/> or <see langword="false"/> depending on the outcome.</returns>
	/// <exception cref="ArgumentNullException"></exception>
	/// <exception cref="ArgumentException"></exception>
	(bool success, string content) Read(string folderPath, string fileName);

	/// <summary>
	/// The <see cref="Save(string, string, string)"/> method should be used for saving a file.
	/// </summary>
	/// <remarks>
	/// Will throw an exception if <paramref name="fileName"/> or <paramref name="folderPath"/> or <paramref name="fileContent"/> is <see langword="null"/>.
	/// </remarks>
	/// <param name="folderPath">The path where the file should be saved.</param>
	/// <param name="fileName">The file name of the file that should be saved.</param>
	/// <param name="fileContent">The content of the file thst should be saved.</param>
	/// <returns><see langword="true"/> or <see langword="false"/> depending on the outcome.</returns>
	/// <exception cref="ArgumentNullException"></exception>
	/// <exception cref="ArgumentException"></exception>
	(bool success, string message) Save(string folderPath, string fileName, string fileContent);

	/// <summary>
	/// The <see cref="Delete(string, string)"/> method should be used for deleting a file.
	/// </summary>
	/// <remarks>
	/// Will throw an exception if <paramref name="fileName"/> or <paramref name="folderPath"/> is <see langword="null"/>.
	/// </remarks>
	/// <param name="folderPath"></param>
	/// <param name="fileName"></param>
	/// <returns><see langword="true"/> or <see langword="false"/> depending on the outcome.</returns>
	/// <exception cref="ArgumentNullException"></exception>
	/// <exception cref="ArgumentException"></exception>
	(bool success, string message) Delete(string folderPath, string fileName);
}