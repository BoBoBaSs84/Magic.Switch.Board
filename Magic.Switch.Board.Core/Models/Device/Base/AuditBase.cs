using Magic.Switch.Board.Core.Properties;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using static Magic.Switch.Board.Core.Properties.Resources;

namespace Magic.Switch.Board.Core.Models.Device.Base;

/// <summary>
/// The <see cref="AuditBase"/> class.
/// </summary>

[XmlInclude(typeof(Configuration))]
[XmlInclude(typeof(Channel))]
public abstract class AuditBase
{
	/// <summary>
	/// Initializes a new parameterless instance of the <see cref="AuditBase"/> class.
	/// </summary>
	protected AuditBase()
	{
		Id = Guid.NewGuid();
		Name = string.Empty;
		Created = DateTime.Now;
		Updated = DateTime.Now;
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="AuditBase"/> class.
	/// </summary>
	/// <param name="name">The name parameter. Will throw an exception if <see langword="null"/>.</param>
	/// <exception cref="ArgumentNullException"></exception>
	protected AuditBase(string name)
	{
		Id = Guid.NewGuid();
		Name = name ?? throw new ArgumentNullException(nameof(name));
		Created = DateTime.Now;
		Updated = DateTime.Now;
	}

	/// <summary>
	/// The <see cref="Id"/> property.
	/// </summary>
	[Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = nameof(Model_Field_Required_Generic))]
	[JsonPropertyName(nameof(Id))]
	[XmlAttribute(AttributeName = nameof(Id))]
	public Guid Id { get; set; }

	/// <summary>
	/// The <see cref="Name"/> property, can not be <see langword="null"/>.
	/// </summary>
	[Required(AllowEmptyStrings = false, ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = nameof(Model_Field_Required_Generic))]
	[StringLength(50, MinimumLength = 5, ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = nameof(Model_Field_StringLength_Generic))]
	[JsonPropertyName(nameof(Name))]
	[XmlElement(ElementName = nameof(Name), IsNullable = false)]
	public string Name { get; set; }

	/// <summary>
	/// The <see cref="Description"/> property, can be <see langword="null"/>.
	/// </summary>
	[MaxLength(200, ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = nameof(Model_Field_MaxLength_Generic))]
	[JsonPropertyName(nameof(Description))]
	[XmlElement(ElementName = nameof(Description), IsNullable = false)]
	public string? Description { get; set; }

	/// <summary>
	/// The <see cref="Created"/> property.
	/// </summary>
	/// <remarks>
	/// When was the configuration created?
	/// </remarks>
	[JsonPropertyName(nameof(Created))]
	[XmlAttribute(AttributeName = nameof(Created), DataType = "date")]
	public DateTime Created { get; set; }

	/// <summary>
	/// The <see cref="Updated"/> property.
	/// </summary>
	/// <remarks>
	/// When was the configuration the last time modified?
	/// </remarks>
	[JsonPropertyName(nameof(Updated))]
	[XmlAttribute(AttributeName = nameof(Updated), DataType = "date")]
	public DateTime Updated { get; set; }
}
