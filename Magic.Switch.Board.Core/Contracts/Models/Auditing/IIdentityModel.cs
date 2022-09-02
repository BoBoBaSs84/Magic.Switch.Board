using System.ComponentModel.DataAnnotations;

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
	/// Of type <see cref="Guid"/>.
	/// </remarks>
	[Key]
	public Guid Id { get; }
}
