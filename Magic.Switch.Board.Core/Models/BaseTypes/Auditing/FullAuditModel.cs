using Magic.Switch.Board.Core.Contracts.Models.BaseTypes.Auditing;
using Magic.Switch.Board.Core.Extensions;
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
	private DateTime created;
	private DateTime updated;

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
	public Guid Id { get; set; }

	/// <inheritdoc cref="IAuditedModel.Created"/>
	[Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = nameof(Model_Field_Required_Generic))]
	[JsonPropertyName(nameof(Created))]
	[JsonConverter(typeof(JsonIsoDateTimeConverter))]
	[XmlAttribute(AttributeName = nameof(Created))]
	public DateTime Created
	{
		get => created.AddTicks(-(created.Ticks % TimeSpan.TicksPerSecond));
		set => created = DateTime.SpecifyKind(value, DateTimeKind.Unspecified);
	}

	/// <inheritdoc cref="IAuditedModel.Updated"/>
	[JsonPropertyName(nameof(Updated))]
	[JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
	[JsonConverter(typeof(JsonIsoDateTimeConverter))]
	[XmlAttribute(AttributeName = nameof(Updated))]
	public DateTime Updated
	{
		get => updated.AddTicks(-(updated.Ticks % TimeSpan.TicksPerSecond));
		set => updated = DateTime.SpecifyKind(value, DateTimeKind.Unspecified);
	}

	/// <inheritdoc cref="IActivatableModel.IsActive"/>
	[Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = nameof(Model_Field_Required_Generic))]
	[JsonPropertyName(nameof(IsActive))]
	[XmlAttribute(AttributeName = nameof(IsActive))]
	public bool IsActive { get; set; }

	/// <inheritdoc cref="IActivatableModel.ShouldSerializeIsActive"/>
	public bool ShouldSerializeIsActive() => !Equals(IsActive, true);

	/// <inheritdoc cref="IAuditedModel.ShouldSerializeUpdated"/>
	public bool ShouldSerializeUpdated() => !Equals(Updated, DateTime.MinValue);
}
