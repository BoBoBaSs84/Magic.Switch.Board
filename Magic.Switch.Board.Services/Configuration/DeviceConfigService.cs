using Magic.Switch.Board.Entities.Configuration;
using Magic.Switch.Board.Services.Configuration.Interfaces;
using Magic.Switch.Board.Services.Helpers;
using System.Text;
using static Magic.Switch.Board.Services.Statics;

namespace Magic.Switch.Board.Services.Configuration;

/// <summary>
/// The <see cref="DeviceConfigService"/> class implements the members of the <see cref="IDeviceConfigService"/> interface
/// </summary>
public sealed class DeviceConfigService : IDeviceConfigService
{
	/// <inheritdoc/>
	public DeviceConfiguration Create(string applicationVersion) =>
		new(applicationVersion);
	/// <inheritdoc/>
	public DeviceConfiguration? Read() =>
		XmlHelper<DeviceConfiguration>.ReadFile(DeviceConfigFileName);
	/// <inheritdoc/>
	public bool Write(DeviceConfiguration configuration, Encoding? encoding) =>
		XmlHelper<DeviceConfiguration>.WriteFile(DeviceConfigFileName, configuration, encoding);
	/// <inheritdoc/>
	public bool Write(DeviceConfiguration configuration) =>
		XmlHelper<DeviceConfiguration>.WriteFile(DeviceConfigFileName, configuration, Encoding.UTF8);
}