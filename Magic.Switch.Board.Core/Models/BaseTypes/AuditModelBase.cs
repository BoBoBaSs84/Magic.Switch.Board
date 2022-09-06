using Magic.Switch.Board.Core.Contracts.Models.Auditing;

namespace Magic.Switch.Board.Core.Models.BaseTypes;

/// <summary>
/// The <see cref="AuditModelBase"/> class.
/// </summary>
/// <remarks>
/// The <see cref="AuditModelBase"/> class implements the members of the following interfaces:
/// <list type="bullet">
/// <item>The <see cref="IIdentityModel"/> interface.</item>
/// <item>The <see cref="IAuditedModel"/> interface.</item>
/// <item>The <see cref="IActivatableModel"/> interface.</item>
/// </list>
/// </remarks>
public abstract class AuditModelBase : IIdentityModel, IAuditedModel, IActivatableModel
{
	/// <summary>
	/// Initializes a new instance of the <see cref="AuditModelBase"/> class.
	/// </summary>
	protected AuditModelBase()
	{
		Id = Guid.NewGuid();
		CreatedAt = DateTime.Now;
	}

	/// <inheritdoc cref="IIdentityModel.Id"/>
	public Guid Id { get; private set; }
	/// <inheritdoc cref="IAuditedModel.CreatedAt"/>
	public DateTime CreatedAt { get; private set; }
	/// <inheritdoc cref="IAuditedModel.UpdatedAt"/>
	public DateTime? UpdatedAt { get; set; }
	/// <inheritdoc cref="IActivatableModel.IsActive"/>
	public bool IsActive { get; set; }
}
