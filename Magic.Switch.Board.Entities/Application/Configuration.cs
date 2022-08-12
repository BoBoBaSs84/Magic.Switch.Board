using Magic.Switch.Board.Models.Base;
using System.Xml.Serialization;
using static Magic.Switch.Board.Models.Constants;
using static Magic.Switch.Board.Models.Enums;

namespace Magic.Switch.Board.Models.Application;

/// <summary>
/// The <see cref="Configuration"/> class is the root element of the configuration file.
/// </summary>
[XmlRoot(ElementName = ConfigurationRootElementName, IsNullable = false, Namespace = ApplicationNamespace)]
public class Configuration : ConfigurationBase
{
	/// <summary>
	/// The empty <see cref="Configuration"/> constructor.
	/// </summary>
	public Configuration() : base()
	{
		LogLevel = LogLevel.Warning;
	}

	/// <summary>
	/// The <see cref="Configuration"/> constructor.
	/// </summary>
	/// <param name="applicationVersion">The version of the application that creates the configuration.</param>
	/// <exception cref="ArgumentNullException"></exception>
	public Configuration(string applicationVersion) : base(applicationVersion)
	{
		LogLevel = LogLevel.Warning;
	}

	/// <summary>
	/// The <see cref="LogLevel"/> property
	/// </summary>
	[XmlElement(ElementName = nameof(LogLevel), IsNullable = false)]
	public LogLevel LogLevel { get; set; }
}