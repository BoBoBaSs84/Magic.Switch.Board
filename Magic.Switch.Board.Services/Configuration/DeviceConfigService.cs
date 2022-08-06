using Magic.Switch.Board.Entities.Configuration;
using Magic.Switch.Board.Services.Configuration.Interfaces;
using Magic.Switch.Board.Services.Helpers;
using System.Text;
using static Magic.Switch.Board.Services.Statics;

namespace Magic.Switch.Board.Services.Configuration;

/// <summary>
/// The <see cref="DeviceConfigService"/> class implements the members of the <see cref="IDeviceConfigService"/> interface
/// </summary>
public class DeviceConfigService : IDeviceConfigService
{
	/// <inheritdoc/>
	public DeviceConfiguration Create(string softwareVersion) =>
		new(softwareVersion);

	/// <inheritdoc/>
	public DeviceConfiguration? Read() =>
		XmlHelper<DeviceConfiguration>.ReadFile(DeviceConfigFileName);

	/// <inheritdoc/>
	public void Write(DeviceConfiguration configuration, Encoding? encoding) =>
		XmlHelper<DeviceConfiguration>.WriteFile(DeviceConfigFileName, configuration, encoding);
}
