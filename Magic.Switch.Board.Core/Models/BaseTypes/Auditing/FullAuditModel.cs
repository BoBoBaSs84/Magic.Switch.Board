using Magic.Switch.Board.Core.Contracts.Models.Auditing;
using Magic.Switch.Board.Core.Models.BaseTypes.Device;
using Magic.Switch.Board.Core.Properties;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using static Magic.Switch.Board.Core.Properties.Resources;

namespace Magic.Switch.Board.Core.Models.BaseTypes.Auditing;

/// <summary>
/// The <see cref="FullAuditModel"/> class.
/// </summary>
[XmlInclude(typeof(NamedBase))]
public abstract class FullAuditModel : IIdentityModel, IAuditedModel, IActivatableModel
{
	/// <summary>
	/// Initializes a new instance of the <see cref="FullAuditModel"/> class.
	/// </summary>
	protected FullAuditModel()
	{
		Id = Guid.NewGuid();
		Created = DateTime.Now;
		IsActive = true;
	}

	/// <inheritdoc cref="IIdentityModel.Id"/>	
	[Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = nameof(Model_Field_Required_Generic))]
	[JsonPropertyName(nameof(Id))]
	[XmlAttribute(AttributeName = nameof(Id))]
	[Key]
	public Guid Id { get; set; }

	/// <inheritdoc cref="IAuditedModel.Created"/>
	[Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = nameof(Model_Field_Required_Generic))]
	[JsonPropertyName(nameof(Created))]
	[XmlAttribute(AttributeName = nameof(Created), DataType = "date")]
	public DateTime Created { get; set; }

	/// <inheritdoc cref="IAuditedModel.Updated"/>
	[JsonPropertyName(nameof(Updated))]
	[XmlAttribute(AttributeName = nameof(Updated), DataType = "date")]
	public DateTime? Updated { get; set; }

	/// <inheritdoc cref="IActivatableModel.IsActive"/>
	[Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = nameof(Model_Field_Required_Generic))]
	[JsonPropertyName(nameof(IsActive))]
	[XmlAttribute(AttributeName = nameof(IsActive))]
	public bool IsActive { get; set; }
}
