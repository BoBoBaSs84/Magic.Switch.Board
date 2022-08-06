using System.Xml.Serialization;
using static Magic.Switch.Board.Entities.Constants;
using static Magic.Switch.Board.Entities.Statics;

namespace Magic.Switch.Board.Entities.Configuration;

/// <summary>
/// The <see cref="DeviceConfiguration"/> class is the root element of the configuration file
/// </summary>
[XmlRoot(ElementName = ConfigurationRootElementName, IsNullable = false, Namespace = DeviceNamespace)]
public class DeviceConfiguration
{
	/// <summary>
	/// The <see cref="DeviceConfiguration"/> constructor
	/// </summary>
	public DeviceConfiguration()
	{
		Id = Guid.NewGuid();
		Channels = new();
		ApplicationVersion = string.Empty;
		ConfigurationVersion = AssemblyVersion;
	}

	/// <summary>
	/// The <see cref="DeviceConfiguration"/> constructor
	/// </summary>
	/// <param name="applicationVersion"></param>
	/// <exception cref="ArgumentNullException"></exception>
	public DeviceConfiguration(string applicationVersion)
	{
		Id = Guid.NewGuid();
		Channels = new();
		ApplicationVersion = applicationVersion ?? throw new ArgumentNullException(nameof(applicationVersion));
		ConfigurationVersion = AssemblyVersion;
	}

	/// <summary>
	/// Constructor
	/// </summary>
	/// <param name="applicationVersion"></param>
	/// <param name="channels"></param>
	/// <exception cref="ArgumentNullException"></exception>
	public DeviceConfiguration(string applicationVersion, List<Channel> channels)
	{
		Id = Guid.NewGuid();
		ApplicationVersion = applicationVersion ?? throw new ArgumentNullException(nameof(applicationVersion));
		Channels = channels ?? throw new ArgumentNullException(nameof(channels));
		ConfigurationVersion = AssemblyVersion;
	}

	/// <summary>
	/// The <see cref="Id"/> property
	/// </summary>
	[XmlAttribute(AttributeName = nameof(Id))]
	public Guid Id { get; set; }

	/// <summary>
	/// The <see cref="ApplicationVersion"/> property
	/// </summary>
	[XmlAttribute(AttributeName = nameof(ApplicationVersion))]
	public string ApplicationVersion { get; set; }

	/// <summary>
	/// <see cref="ConfigurationVersion"/> property
	/// </summary>
	[XmlAttribute(AttributeName = nameof(ConfigurationVersion))]
	public string ConfigurationVersion { get; set; }

	/// <summary>
	/// The <see cref="Channels"/> property
	/// </summary>
	[XmlArray(ElementName = nameof(Channels), IsNullable = true)]
	[XmlArrayItem(ElementName = nameof(Channel), IsNullable = false)]
	public List<Channel> Channels { get; set; }
}