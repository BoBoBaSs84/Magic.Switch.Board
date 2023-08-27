using Magic.Switch.Board.Core.Models.Device;

namespace Magic.Switch.Board.Core.Contracts.Models.Device;

/// <summary>
/// The <see cref="IChannel"/> interface.
/// </summary>
/// <remarks>
/// Exposes all public properties.
/// </remarks>
public interface IChannel
{
	/// <summary>
	/// The <see cref="Input"/> property, can not be <see langword="null"/>.
	/// </summary>
	Input Input { get; }

	/// <summary>
	/// The <see cref="Output"/> property, can be <see langword="null"/>.
	/// </summary>
	Output? Output { get; }

	/// <summary>
	/// The <see cref="Switches"/> property, can be <see langword="null"/>.
	/// </summary>
	Switches? Switches { get; }

	/// <summary>
	/// The <see cref="Loops"/> property, can be <see langword="null"/>.
	/// </summary>
	Loops? Loops { get; }
}
