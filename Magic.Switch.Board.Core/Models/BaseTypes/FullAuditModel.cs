using Magic.Switch.Board.Core.Contracts.Models.Auditing;

namespace Magic.Switch.Board.Core.Models.BaseTypes;

/// <summary>
/// The <see cref="FullAuditModel"/> class.
/// </summary>
public abstract class FullAuditModel : IIdentityModel, IAuditedModel, IActivatableModel
{
	/// <inheritdoc cref="IIdentityModel"/>
	public Guid Id => throw new NotImplementedException();
	/// <inheritdoc cref="IAuditedModel"/>
	public DateTime CreatedAt => throw new NotImplementedException();
	/// <inheritdoc cref="IAuditedModel"/>
	public DateTime? UpdatedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
	/// <inheritdoc cref="IActivatableModel"/>
	public bool IsActive => throw new NotImplementedException();
}
