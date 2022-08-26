using Magic.Switch.Board.Models.Device;
using System.Text;

namespace Magic.Switch.Board.Services.Device.Interfaces;

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
	/// The <see cref="Read"/> method reads the <see cref="Configuration"/> from file.
	/// </summary>
	/// <returns><see cref="Configuration"/></returns>
	public Configuration? Read();

	/// <summary>
	/// The <see cref="Write(Configuration)"/> method writes the device configuration to file.
	/// </summary>
	/// <remarks>
	/// This method will enforce to use <see cref="Encoding.UTF8"/>.
	/// Will throw an exception is <paramref name="configuration"/> is <see langword="null"/>.
	/// </remarks>
	/// <param name="configuration">The device configuration.</param>
	/// <returns><see langword="true"/> or <see langword="false"/> as success message.</returns>
	/// <exception cref="ArgumentNullException"></exception>
	public bool Write(Configuration configuration);

	/// <summary>
	/// The <see cref="Write(Configuration, Encoding?)"/> method writes the device configuration to file.
	/// </summary>
	/// <remarks>
	/// Since encoding can be <see cref="Nullable"/>, when null, <see cref="Encoding.UTF8"/> will be used.
	/// Will throw an exception is <paramref name="configuration"/> is <see langword="null"/>.
	/// </remarks>
	/// <param name="configuration">The device configuration.</param>
	/// <param name="encoding">The desired encoding type.</param>
	/// <returns><see langword="true"/> or <see langword="false"/> as success message.</returns>
	/// <exception cref="ArgumentNullException"></exception>
	public bool Write(Configuration configuration, Encoding? encoding);
}