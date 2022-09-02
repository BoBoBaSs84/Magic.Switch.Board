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
	/// Of type <see cref="bool"/>, will be used to see if a record is active or not.
	/// </remarks>
	public bool IsActive { get; }
}
