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
	/// The model entry identifier of type <see cref="Guid"/>.
	/// </remarks>	
	public Guid Id { get; }
}
