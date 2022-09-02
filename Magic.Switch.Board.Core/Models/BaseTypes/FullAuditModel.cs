using Magic.Switch.Board.Core.Contracts.Models.Auditing;

namespace Magic.Switch.Board.Core.Models.BaseTypes;

/// <summary>
/// The <see cref="FullAuditModel"/> class.
/// </summary>
public abstract class FullAuditModel : IIdentityModel, IAuditedModel, IActivatableModel
{
	public Guid Id => throw new NotImplementedException();

	public DateTime CreatedAt => throw new NotImplementedException();

	public DateTime? UpdatedAt { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

	public bool IsActive => throw new NotImplementedException();
}
