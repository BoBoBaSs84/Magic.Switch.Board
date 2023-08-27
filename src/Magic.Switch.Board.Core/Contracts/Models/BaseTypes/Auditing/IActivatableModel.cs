namespace Magic.Switch.Board.Core.Contracts.Models.BaseTypes.Auditing;

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

	/// <summary>
	/// Method turns serialization of the <see cref="IsActive"/> property on/off.
	/// </summary>
	/// <remarks>
	/// If the value of <see cref="IsActive"/> equals <see langword="true"/>, <see langword="false"/> is returned.
	/// </remarks>
	/// <returns><see langword="true"/> or <see langword="false"/></returns>
	bool ShouldSerializeIsActive();
}
