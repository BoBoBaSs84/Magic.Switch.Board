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
	/// Defines when the record entry was created.
	/// Cannot be <see langword="null"/>.
	/// </remarks>
	public DateTime Created { get; }

	/// <summary>
	/// The <see cref="Updated"/> property.
	/// </summary>
	/// <remarks>
	/// Defines when the record entry was updated.
	/// Cannot be <see langword="null"/>.
	/// </remarks>
	public DateTime Updated { get; set; }

	/// <summary>
	/// Method turns serialization of the <see cref="Updated"/> property on/off.
	/// </summary>
	/// <remarks>
	/// If value of <see cref="Updated"/> equals <see cref="DateTime.MinValue"/>, <see langword="false"/> is returned.
	/// </remarks>
	/// <returns><see langword="true"/> or <see langword="false"/></returns>
	bool ShouldSerializeUpdated();
}
