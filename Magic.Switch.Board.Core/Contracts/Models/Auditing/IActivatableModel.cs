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
	/// Indicates with <see langword="true"/> or <see langword="false"/> if a record is active or not, can be used as soft delete.
	/// </remarks>
	public bool IsActive { get; set; }
}
