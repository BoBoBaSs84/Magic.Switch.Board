namespace Magic.Switch.Board.Core.Contracts.Models.Auditing;

/// <summary>
/// The <see cref="IAuditedModel"/> interface.
/// </summary>
public interface IAuditedModel
{
	/// <summary>
	/// The <see cref="Created"/> property.
	/// </summary>
	/// <remarks>
	/// Of type <see cref="DateTime"/>, defines when the record entry was created.
	/// </remarks>
	public DateTime Created { get; }

	/// <summary>
	///The <see cref="Updated"/> property.
	/// </summary>
	/// <remarks>
	/// Of type <see cref="DateTime"/>, defines when the record entry was updated.
	/// Since no update has to be performed, can be <see langword="null"/>.
	/// </remarks>
	public DateTime? Updated { get; set; }
}
