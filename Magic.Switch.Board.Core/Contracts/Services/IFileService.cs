namespace Magic.Switch.Board.Core.Contracts.Services;

/// <summary>
/// The <see cref="IFileService"/> interface exposes the public methods for file manipulation.
/// </summary>
public interface IFileService
{
	/// <summary>
	/// The <see cref="Read(string, string)"/> method should be used for reading a file.
	/// </summary>
	/// <param name="folderPath">The path where the file is located. Will throw an exception if <see langword="null"/>.</param>
	/// <param name="fileName">The file name of the file that should be read. Will throw an exception if <see langword="null"/>.</param>
	/// <returns>The file content as string.</returns>
	string Read(string folderPath, string fileName);

	/// <summary>
	/// The <see cref="Save(string, string, string)"/> method should be used for saving a file.
	/// </summary>
	/// <param name="folderPath">The path where the file should be saved. Will throw an exception if <see langword="null"/>.</param>
	/// <param name="fileName">The file name of the file that should be saved. Will throw an exception if <see langword="null"/>.</param>
	/// <param name="fileContent">The content of the file thst should be saved. Will throw an exception if <see langword="null"/>.</param>
	void Save(string folderPath, string fileName, string fileContent);

	/// <summary>
	/// The <see cref="Delete(string, string)"/> method should be used for deleting a file.
	/// </summary>
	/// <remarks>
	/// Will throw an exception if <paramref name="fileName"/> or <paramref name="folderPath"/> is <see langword="null"/>.
	/// </remarks>
	/// <param name="folderPath">The path where the file is located. Will throw an exception if <see langword="null"/>.</param>
	/// <param name="fileName">The file name of the file that should be deleted. Will throw an exception if <see langword="null"/>.</param>
	void Delete(string folderPath, string fileName);
}