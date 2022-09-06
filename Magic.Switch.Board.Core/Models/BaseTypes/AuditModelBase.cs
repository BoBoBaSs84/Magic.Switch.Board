using Magic.Switch.Board.Core.Contracts.Models.Auditing;
using Magic.Switch.Board.Core.Models.BaseTypes.Device;
using Magic.Switch.Board.Core.Properties;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using static Magic.Switch.Board.Core.Properties.Resources;

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
[XmlInclude(typeof(NamedBase))]
public abstract class AuditModelBase : IIdentityModel, IAuditedModel, IActivatableModel
{
	/// <summary>
	/// Initializes a new instance of the <see cref="AuditModelBase"/> class.
	/// </summary>
	protected AuditModelBase()
	{
		Id = Guid.NewGuid();
		Created = DateTime.Now;
	}

	/// <inheritdoc cref="IIdentityModel.Id"/>
	[Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = nameof(Model_Field_Required_Generic))]
	[JsonPropertyName(nameof(Id))]
	[XmlAttribute(AttributeName = nameof(Id))]
	public Guid Id { get; private set; }

	/// <inheritdoc cref="IAuditedModel.Created"/>
	[Required(ErrorMessageResourceType = typeof(Resources),
		ErrorMessageResourceName = nameof(Model_Field_Required_Generic))]
	[JsonPropertyName(nameof(Created))]
	[XmlAttribute(AttributeName = nameof(Created), DataType = "date")]
	public DateTime Created { get; private set; }

	/// <inheritdoc cref="IAuditedModel.Updated"/>
	[JsonPropertyName(nameof(Updated))]
	[XmlAttribute(AttributeName = nameof(Updated), DataType = "date")]
	public DateTime? Updated { get; set; }

	/// <inheritdoc cref="IActivatableModel.IsActive"/>
	[JsonPropertyName(nameof(IsActive))]
	[XmlAttribute(AttributeName = nameof(IsActive))]
	public bool IsActive { get; set; }
}
