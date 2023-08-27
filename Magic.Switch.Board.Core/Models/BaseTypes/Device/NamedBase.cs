using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

using Magic.Switch.Board.Core.Contracts.Models.BaseTypes.Device;
using Magic.Switch.Board.Core.Models.BaseTypes.Auditing;
using Magic.Switch.Board.Core.Models.Device;
using Magic.Switch.Board.Core.Properties;

using static Magic.Switch.Board.Core.Properties.Resources;

namespace Magic.Switch.Board.Core.Models.BaseTypes.Device;

/// <summary>
/// The <see cref="NamedBase"/> class.
/// </summary>
[XmlInclude(typeof(Configuration))]
[XmlInclude(typeof(Channel))]
public abstract class NamedBase : FullAuditModel, INamedBase
{
	/// <summary>
	/// Initializes a new instance of the <see cref="NamedBase"/> class.
	/// </summary>
	protected NamedBase() => Name = string.Empty;

	/// <summary>
	/// Initializes a new instance of the <see cref="NamedBase"/> class.
	/// </summary>
	/// <param name="name">The name parameter. Will throw an exception if <see langword="null"/>.</param>
	/// <exception cref="ArgumentNullException"></exception>
	protected NamedBase(string name) => Name = name ?? throw new ArgumentNullException(nameof(name));

	/// <inheritdoc cref="INamedBase.Name"/>
	[Required(AllowEmptyStrings = false, ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = nameof(Model_Field_Required_Generic))]
	[StringLength(50, MinimumLength = 5, ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = nameof(Model_Field_StringLength_Generic))]
	[JsonPropertyName(nameof(Name))]
	[XmlElement(ElementName = nameof(Name), IsNullable = false)]
	public string Name { get; set; }

	/// <inheritdoc cref="INamedBase.Description"/>
	[MaxLength(200, ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = nameof(Model_Field_MaxLength_Generic))]
	[JsonPropertyName(nameof(Description))]
	[XmlElement(ElementName = nameof(Description), IsNullable = false)]
	public string? Description { get; set; }
}
