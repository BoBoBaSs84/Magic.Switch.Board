using Magic.Switch.Board.Core.Models.Device;

namespace Magic.Switch.Board.Core.Contracts.Models.Device;

/// <summary>
/// The <see cref="IConfiguration"/> interface.
/// </summary>
/// <remarks>
/// Exposes all public properties.
/// </remarks>
public interface IConfiguration
{
	/// <summary>
	/// The <see cref="ApplicationVersion"/> property, can not be <see langword="null"/>.
	/// </summary>
	string ApplicationVersion { get; }

	/// <summary>
	/// <see cref="ConfigurationVersion"/> property, can not be <see langword="null"/>.
	/// </summary>
	string ConfigurationVersion { get; }

	/// <summary>
	/// The <see cref="Channels"/> property, the collection of channel configurations.
	/// </summary>
	List<Channel> Channels { get; }
}
