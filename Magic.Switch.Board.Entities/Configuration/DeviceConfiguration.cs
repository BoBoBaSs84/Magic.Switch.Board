using Magic.Switch.Board.Entities.Configuration.Base;
using System.Xml.Serialization;
using static Magic.Switch.Board.Entities.Constants;

namespace Magic.Switch.Board.Entities.Configuration;

/// <summary>
/// The <see cref="DeviceConfiguration"/> class is the root element of the configuration file
/// </summary>
[XmlRoot(ElementName = ConfigurationRootElementName, IsNullable = false, Namespace = DeviceNamespace)]
public class DeviceConfiguration : ConfigurationBase
{
	/// <summary>
	/// The <see cref="DeviceConfiguration"/> constructor
	/// </summary>
	public DeviceConfiguration() : base()
	{
		Channels = new();
	}

	/// <summary>
	/// The <see cref="DeviceConfiguration"/> constructor
	/// </summary>
	/// <param name="applicationVersion">The version of the application that creates the configuration.</param>
	/// <exception cref="ArgumentNullException"></exception>
	public DeviceConfiguration(string applicationVersion) : base(applicationVersion)
	{
		Channels = new();
	}

	/// <summary>
	/// The <see cref="DeviceConfiguration"/> constructor
	/// </summary>
	/// <param name="applicationVersion">The version of the application that creates the configuration.</param>
	/// <param name="channels">The list of channels that should be added.</param>
	/// <exception cref="ArgumentNullException"></exception>
	public DeviceConfiguration(string applicationVersion, List<Channel> channels) : base(applicationVersion)
	{
		Channels = channels ?? throw new ArgumentNullException(nameof(channels));
	}

	/// <summary>
	/// The <see cref="Channels"/> property
	/// </summary>
	[XmlArray(ElementName = nameof(Channels), IsNullable = true)]
	[XmlArrayItem(ElementName = nameof(Channel), IsNullable = false)]
	public List<Channel> Channels { get; set; }
}