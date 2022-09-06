namespace Magic.Switch.Board.Core.Contracts.Models.Auditing;

/// <summary>
/// The <see cref="IIdentityModel"/> interface.
/// </summary>
public interface IIdentityModel
{
	/// <summary>
	/// The <see cref="Id"/> property.
	/// </summary>
	/// <remarks>
	/// Of type <see cref="Guid"/>, serves as the identifier of a record set.
	/// </remarks>
	public Guid Id { get; }
}
