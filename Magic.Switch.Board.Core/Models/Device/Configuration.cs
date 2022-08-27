using System.Text.Json.Serialization;
using System.Xml.Serialization;
using static Magic.Switch.Board.Core.Statics;

namespace Magic.Switch.Board.Core.Models.Device;

/// <summary>
/// The <see cref="Configuration"/> class is the root element of the device configuration file.
/// </summary>
[XmlRoot(ElementName = nameof(Configuration), IsNullable = false, Namespace = DeviceNamespace)]
public class Configuration
{
	private const string DeviceNamespace = "http://magic.switch.board.com/configuration/device";

	/// <summary>
	/// The empty <see cref="Configuration"/> class constructor.
	/// </summary>
	public Configuration()
	{
		Id = Guid.NewGuid();
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
	/// <param name="applicationVersion">The version of the application that creates the configuration.</param>
	/// <exception cref="ArgumentNullException"></exception>
	public Configuration(string applicationVersion)
	{
		Id = Guid.NewGuid();
		ApplicationVersion = applicationVersion ?? throw new ArgumentNullException(nameof(applicationVersion));
		Channels = new();
		ConfigurationVersion = AssemblyVersion;
	}

	/// <summary>
	/// The advanced <see cref="Configuration"/> class constructor.
	/// </summary>
	/// <remarks>
	/// Will throw an exception if <paramref name="applicationVersion"/> is <see langword="null"/>.
	/// Will throw an exception if <paramref name="channels"/> is <see langword="null"/>.
	/// </remarks>	
	/// <param name="applicationVersion">The version of the application that creates the configuration.</param>
	/// <param name="channels">The list of channels that should be added.</param>
	/// <exception cref="ArgumentNullException"></exception>
	public Configuration(string applicationVersion, List<Channel> channels)
	{
		Id = Guid.NewGuid();
		ApplicationVersion = applicationVersion ?? throw new ArgumentNullException(nameof(applicationVersion));
		Channels = channels ?? throw new ArgumentNullException(nameof(channels));
		ConfigurationVersion = AssemblyVersion;
	}

	/// <summary>
	/// The <see cref="Id"/> property.
	/// </summary>
	[JsonPropertyName(nameof(Id))]
	[XmlAttribute(AttributeName = nameof(Id))]
	public Guid Id { get; set; }

	/// <summary>
	/// The <see cref="ApplicationVersion"/> property, can not be <see langword="null"/>.
	/// </summary>
	[JsonPropertyName(nameof(ApplicationVersion))]
	[XmlAttribute(AttributeName = nameof(ApplicationVersion))]
	public string ApplicationVersion { get; set; }

	/// <summary>
	/// <see cref="ConfigurationVersion"/> property, can not be <see langword="null"/>.
	/// </summary>
	[JsonPropertyName(nameof(ConfigurationVersion))]
	[XmlAttribute(AttributeName = nameof(ConfigurationVersion))]
	public string ConfigurationVersion { get; set; }

	/// <summary>
	/// The <see cref="Channels"/> property.
	/// </summary>
	[JsonPropertyName(nameof(Channels))]
	[XmlArray(ElementName = nameof(Channels), IsNullable = true)]
	[XmlArrayItem(ElementName = nameof(Channel), IsNullable = false)]
	public List<Channel> Channels { get; set; }
}