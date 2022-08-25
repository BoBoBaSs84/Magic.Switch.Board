using Magic.Switch.Board.Models.Base;
using System.Xml.Serialization;
using static Magic.Switch.Board.Models.Constants;

namespace Magic.Switch.Board.Models.Device;

/// <summary>
/// The <see cref="Configuration"/> class is the root element of the configuration file
/// </summary>
[XmlRoot(ElementName = ConfigurationRootElementName, IsNullable = false, Namespace = DeviceNamespace)]
public class Configuration : ConfigurationBase
{
	/// <summary>
	/// The <see cref="Configuration"/> constructor
	/// </summary>
	public Configuration() : base()
	{
		Channels = new();
	}

	/// <summary>
	/// The <see cref="Configuration"/> constructor
	/// </summary>
	/// <param name="applicationVersion">The version of the application that creates the configuration.</param>
	/// <exception cref="ArgumentNullException"></exception>
	public Configuration(string applicationVersion) : base(applicationVersion)
	{
		Channels = new();
	}

	/// <summary>
	/// The <see cref="Configuration"/> constructor
	/// </summary>
	/// <param name="applicationVersion">The version of the application that creates the configuration.</param>
	/// <param name="channels">The list of channels that should be added.</param>
	/// <exception cref="ArgumentNullException"></exception>
	public Configuration(string applicationVersion, List<Channel> channels) : base(applicationVersion)
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