using static Magic.Switch.Board.Core.Enums;

namespace Magic.Switch.Board.Core.Contracts.Models.Device;

/// <summary>
/// The <see cref="ISwitches"/> interface.
/// </summary>
/// <remarks>
/// Exposes all public properties.
/// </remarks>
public interface ISwitches
{
	/// <summary>
	/// The <see cref="Channels"/> property, cannot be <see langword="null"/>.
	/// </summary>
	SwitchChannels Channels { get; }
}
