using Magic.Switch.Board.Entities.Configuration.Base;
using System.Xml.Serialization;
using static Magic.Switch.Board.Entities.Constants;
using static Magic.Switch.Board.Entities.Enums;

namespace Magic.Switch.Board.Entities.Configuration;

/// <summary>
/// The <see cref="ApplicationConfiguration"/> class is the root element of the configuration file.
/// </summary>
[XmlRoot(ElementName = ConfigurationRootElementName, IsNullable = false, Namespace = ApplicationNamespace)]
public class ApplicationConfiguration : ConfigurationBase
{
	/// <summary>
	/// The empty <see cref="ApplicationConfiguration"/> constructor.
	/// </summary>
	public ApplicationConfiguration() : base()
	{
		LogLevel = LogLevel.Warning;
	}

	/// <summary>
	/// The <see cref="ApplicationConfiguration"/> constructor.
	/// </summary>
	/// <param name="applicationVersion">The version of the application that creates the configuration.</param>
	/// <exception cref="ArgumentNullException"></exception>
	public ApplicationConfiguration(string applicationVersion) : base(applicationVersion)
	{
		LogLevel = LogLevel.Warning;
	}

	/// <summary>
	/// The <see cref="LogLevel"/> property
	/// </summary>
	[XmlElement(ElementName = nameof(LogLevel), IsNullable = false)]
	public LogLevel LogLevel { get; set; }
}