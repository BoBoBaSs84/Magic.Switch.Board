using Magic.Switch.Board.Entities.Configuration;
using System.Text;

namespace Magic.Switch.Board.Services.Configuration.Interfaces;

/// <summary>
/// The <see cref="IDeviceConfigService"/> interface exposes the public methods for reading an writing the device configuration file.
/// </summary>
public interface IDeviceConfigService
{
	/// <summary>
	/// The <see cref="Write(DeviceConfiguration, Encoding?)"/> method writes the device configuration to file.
	/// </summary>
	/// <remarks>
	/// Since encoding can be <see cref="Nullable"/>, when null, <see cref="Encoding.UTF8"/> will be used.
	/// </remarks>
	/// <param name="configuration"></param>
	/// <param name="encoding"></param>
	public void Write(DeviceConfiguration configuration, Encoding? encoding);

	/// <summary>
	/// The <see cref="Read"/> method reads the <see cref="DeviceConfiguration"/> from file.
	/// </summary>
	/// <returns><see cref="DeviceConfiguration"/></returns>
	public DeviceConfiguration? Read();

	/// <summary>
	/// The <see cref="Create"/> method creates a new <see cref="DeviceConfiguration"/>.
	/// </summary>
	/// <param name="applicationVersion">The Version of the application that creates the configuration.</param>
	/// <returns><see cref="Configuration"/></returns>
	public DeviceConfiguration Create(string applicationVersion);
}
