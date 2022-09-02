namespace Magic.Switch.Board.Core.Contracts.Models.Auditing;

/// <summary>
/// The <see cref="IAuditedModel"/> interface.
/// </summary>
public interface IAuditedModel
{
	/// <summary>
	/// The <see cref="CreatedAt"/> property.
	/// </summary>
	/// <remarks>
	/// Of type <see cref="DateTime"/>, defines when the entry was created.
	/// </remarks>
	public DateTime CreatedAt { get; }

	/// <summary>
	///The <see cref="UpdatedAt"/> property.
	/// </summary>
	/// <remarks>
	/// Of type <see cref="DateTime"/>, defines when the entry was updated.
	/// Since no update has to be performed, can be <see langword="null"/>.
	/// </remarks>
	public DateTime? UpdatedAt { get; set; }
}
