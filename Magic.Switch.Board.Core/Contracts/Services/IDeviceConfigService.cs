using Magic.Switch.Board.Core.Models.Device;
using System.Text;

namespace Magic.Switch.Board.Core.Contracts.Services;

/// <summary>
/// The <see cref="IDeviceConfigService"/> interface exposes the public methods for reading an writing the device configuration file.
/// </summary>
public interface IDeviceConfigService
{
	/// <summary>
	/// The <see cref="Create"/> method should create a new device configuration.
	/// </summary>
	/// <param name="applicationVersion">The Version of the application that creates the device configuration.</param>
	/// <returns>A device configurastion of type <see cref="Configuration"/>.</returns>
	/// <exception cref="ArgumentNullException"></exception>
	public Configuration Create(string applicationVersion);

	/// <summary>
	/// The <see cref="Read(string, string)"/> method should read the device configuration from file.
	/// </summary>
	/// <param name="folderPath"></param>
	/// <param name="fileName"></param>
	/// <returns>The device configuration or <see langword="null"/>.</returns>
	public Configuration? Read(string folderPath, string fileName);

	/// <summary>
	/// The <see cref="Write(string, string, Configuration)"/> method writes the device configuration to file.
	/// </summary>
	/// <remarks>
	/// This method will enforce to use <see cref="Encoding.UTF8"/>.
	/// Will throw an exception if <paramref name="folderPath"/> or <paramref name="fileName"/> or <paramref name="configuration"/> is <see langword="null"/>.
	/// </remarks>
	/// <param name="folderPath"></param>
	/// <param name="fileName"></param>
	/// <param name="configuration">The device configuration.</param>
	/// <returns><see langword="true"/> or <see langword="false"/> as success message.</returns>
	/// <exception cref="ArgumentNullException"></exception>
	public (bool success, string message) Write(string folderPath, string fileName, Configuration configuration);

	/// <summary>
	/// The <see cref="Write(string, string, Configuration, Encoding?)"/> method writes the device configuration to file.
	/// </summary>
	/// <remarks>
	/// Since encoding can be <see langword="null"/>, when null, <see cref="Encoding.UTF8"/> will be used.
	/// Will throw an exception if <paramref name="folderPath"/> or <paramref name="fileName"/> or <paramref name="configuration"/> is <see langword="null"/>.
	/// </remarks>
	/// <param name="folderPath"></param>
	/// <param name="fileName"></param>
	/// <param name="configuration">The device configuration.</param>
	/// <param name="encoding">The desired encoding type.</param>
	/// <returns><see langword="true"/> or <see langword="false"/> as success message.</returns>
	/// <exception cref="ArgumentNullException"></exception>
	public (bool success, string message) Write(string folderPath, string fileName, Configuration configuration, Encoding? encoding);
}
