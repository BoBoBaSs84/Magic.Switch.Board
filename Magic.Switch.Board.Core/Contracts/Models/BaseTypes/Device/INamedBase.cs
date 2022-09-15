namespace Magic.Switch.Board.Core.Contracts.Models.BaseTypes.Device;

/// <summary>
/// The <see cref="INamedBase"/> interface.
/// </summary>
/// <remarks>
/// Exposes all public properties.
/// </remarks>
public interface INamedBase
{
	/// <summary>
	/// The <see cref="Name"/> property, cannot be <see langword="null"/>.
	/// </summary>
	string Name { get; }

	/// <summary>
	/// The <see cref="Description"/> property, can be <see langword="null"/>.
	/// </summary>
	string? Description { get; }
}
