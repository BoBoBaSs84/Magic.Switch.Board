using static Magic.Switch.Board.Core.Enums;

namespace Magic.Switch.Board.Core.Contracts.Models.Device;

/// <summary>
/// The <see cref="ILoops"/> interface.
/// </summary>
/// <remarks>
/// Exposes all public properties.
/// </remarks>
public interface ILoops
{
	/// <summary>
	/// The <see cref="Channels"/> property, cannot be <see langword="null"/>.
	/// </summary>
	LoopChannels Channels { get; }
}
