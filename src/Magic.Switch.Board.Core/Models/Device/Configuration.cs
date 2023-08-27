using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

using Magic.Switch.Board.Core.Contracts.Models.Device;
using Magic.Switch.Board.Core.Models.BaseTypes.Device;
using Magic.Switch.Board.Core.Properties;

using static Magic.Switch.Board.Core.Properties.Resources;
using static Magic.Switch.Board.Core.Statics;

namespace Magic.Switch.Board.Core.Models.Device;

/// <summary>
/// The <see cref="Configuration"/> class is the root element of the device configuration file.
/// </summary>
/// <remarks>
/// Inherits the properties from <see cref="NamedBase"/> class.
/// Implements the properties if the <see cref="IConfiguration"/> interface.
/// </remarks>
[XmlRoot(ElementName = nameof(Configuration), IsNullable = false, Namespace = DeviceNamespace)]
public class Configuration : NamedBase, IConfiguration
{
	private const string DeviceNamespace = "http://magic.switch.board.com/configuration/device";

	/// <summary>
	/// The empty <see cref="Configuration"/> class constructor.
	/// </summary>
	public Configuration() : base()
	{
		ApplicationVersion = string.Empty;
		Channels = new();
		ConfigurationVersion = AssemblyVersion;
	}

	/// <summary>
	/// The standard <see cref="Configuration"/> class constructor.
	/// </summary>
	/// <remarks>
	/// Will throw an exception if <paramref name="applicationVersion"/> is <see langword="null"/>.
	/// </remarks>
	/// <param name="name">The name of the configuration. Will throw an exception if <see langword="null"/>.</param>
	/// <param name="applicationVersion">The version of the application that creates the configuration. Will throw an exception if <see langword="null"/>.</param>
	/// <exception cref="ArgumentNullException"></exception>
	public Configuration(string name, string applicationVersion) : base(name)
	{
		ApplicationVersion = applicationVersion ?? throw new ArgumentNullException(nameof(applicationVersion));
		Channels = new();
		ConfigurationVersion = AssemblyVersion;
	}

	/// <summary>
	/// The advanced <see cref="Configuration"/> class constructor.
	/// </summary>
	/// <param name="name">The name of the configuration. Will throw an exception if <see langword="null"/>.</param>
	/// <param name="applicationVersion">The version of the application that creates the configuration. Will throw an exception if <see langword="null"/>.</param>
	/// <param name="channels">The list of channels that should be added. Will throw an exception if <see langword="null"/>.</param>
	/// <exception cref="ArgumentNullException"></exception>
	public Configuration(string name, string applicationVersion, List<Channel> channels) : base(name)
	{
		ApplicationVersion = applicationVersion ?? throw new ArgumentNullException(nameof(applicationVersion));
		Channels = channels ?? throw new ArgumentNullException(nameof(channels));
		ConfigurationVersion = AssemblyVersion;
	}


	/// <inheritdoc cref="IConfiguration.ApplicationVersion"/>
	[Required(AllowEmptyStrings = false, ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = nameof(Model_Field_Required_Generic))]
	[StringLength(25, MinimumLength = 8, ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = nameof(Model_Field_StringLength_Generic))]
	[JsonPropertyName(nameof(ApplicationVersion))]
	[XmlAttribute(AttributeName = nameof(ApplicationVersion))]
	public string ApplicationVersion { get; set; }

	/// <inheritdoc cref="IConfiguration.ConfigurationVersion"/>
	[Required(AllowEmptyStrings = false, ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = nameof(Model_Field_Required_Generic))]
	[StringLength(25, MinimumLength = 8, ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = nameof(Model_Field_StringLength_Generic))]
	[JsonPropertyName(nameof(ConfigurationVersion))]
	[XmlAttribute(AttributeName = nameof(ConfigurationVersion))]
	public string ConfigurationVersion { get; set; }

	/// <inheritdoc cref="IConfiguration.Channels"/>
	[Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = nameof(Model_Field_Required_Generic))]
	[JsonPropertyName(nameof(Channels))]
	[XmlArray(ElementName = nameof(Channels), IsNullable = true)]
	[XmlArrayItem(ElementName = nameof(Channel), IsNullable = true)]
	public List<Channel> Channels { get; set; }
}
