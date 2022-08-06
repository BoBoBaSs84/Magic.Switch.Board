using System.Xml.Serialization;
using static Magic.Switch.Board.Entities.Constants;
using static Magic.Switch.Board.Entities.Statics;

namespace Magic.Switch.Board.Entities.Configuration;

/// <summary>
/// The <see cref="ApplicationConfiguration"/> class is the root element of the configuration file
/// </summary>
[XmlRoot(ElementName = nameof(ConfigurationRootElementName), IsNullable = false, Namespace = ApplicationNamespace)]
public class ApplicationConfiguration
{
	/// <summary>
	/// The empty <see cref="ApplicationConfiguration"/> constructor
	/// </summary>
	public ApplicationConfiguration()
	{
		ApplicationVersion = string.Empty;
		ConfigurationVersion = AssemblyVersion;
	}

	/// <summary>
	/// The <see cref="ApplicationConfiguration"/> constructor
	/// </summary>
	/// <param name="softwareVersion"></param>
	/// <exception cref="ArgumentNullException"></exception>
	public ApplicationConfiguration(string softwareVersion)
	{
		ApplicationVersion = softwareVersion ?? throw new ArgumentNullException(nameof(softwareVersion));
		ConfigurationVersion = AssemblyVersion;
	}

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
}