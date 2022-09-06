using Magic.Switch.Board.Core.Contracts.Models.Auditing;
using Magic.Switch.Board.Core.Models.Device.BaseTypes;
using Magic.Switch.Board.Core.Properties;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using static Magic.Switch.Board.Core.Properties.Resources;

namespace Magic.Switch.Board.Core.Models.BaseTypes.Auditing;

/// <summary>
/// The <see cref="FullAuditModel"/> class.
/// </summary>
[XmlInclude(typeof(NamingBase))]
public abstract class FullAuditModel : IIdentityModel, IAuditedModel, IActivatableModel
{
	/// <summary>
	/// Initializes a new instance of the <see cref="FullAuditModel"/> class.
	/// </summary>
	protected FullAuditModel()
	{
		Id = Guid.NewGuid();
		CreatedAt = DateTime.Now;
		IsActive = true;
	}

	/// <inheritdoc cref="IIdentityModel.Id"/>	
	[Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = nameof(Model_Field_Required_Generic))]
	[JsonPropertyName(nameof(Id))]
	[XmlAttribute(AttributeName = nameof(Id))]
	[Key]
	public Guid Id { get; set; }

	/// <inheritdoc cref="IAuditedModel.CreatedAt"/>
	[Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = nameof(Model_Field_Required_Generic))]
	[JsonPropertyName(nameof(CreatedAt))]
	[XmlAttribute(AttributeName = nameof(CreatedAt), DataType = "date")]
	public DateTime CreatedAt { get; set; }

	/// <inheritdoc cref="IAuditedModel.UpdatedAt"/>
	[JsonPropertyName(nameof(UpdatedAt))]
	[XmlAttribute(AttributeName = nameof(UpdatedAt), DataType = "date")]
	public DateTime? UpdatedAt { get; set; }

	/// <inheritdoc cref="IActivatableModel.IsActive"/>
	[Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = nameof(Model_Field_Required_Generic))]
	[JsonPropertyName(nameof(IsActive))]
	[XmlAttribute(AttributeName = nameof(IsActive))]
	public bool IsActive { get; set; }
}
