namespace Magic.Switch.Board.Core.Contracts.Models.Auditing;

/// <summary>
/// The <see cref="IActivatableModel"/> interface.
/// </summary>
public interface IActivatableModel
{
	/// <summary>
	/// The <see cref="IsActive"/> property.
	/// </summary>
	/// <remarks>
	/// Indicates by <see langword="true"/> or <see langword="false"/> if an model entry is active or not.
	/// </remarks>
	public bool IsActive { get; }
}
