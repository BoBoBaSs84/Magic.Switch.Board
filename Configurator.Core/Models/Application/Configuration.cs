using System.Xml.Serialization;
using static Configurator.Core.Constants;
using static Configurator.Core.Statics;

namespace Configurator.Core.Models.Application
{
	/// <summary>
	/// The <see cref="Configuration"/> class is the root element of the configuration file
	/// </summary>
	[XmlRoot(ElementName = nameof(Configuration), IsNullable = false, Namespace = ApplicationNamespace)]
	public class Configuration
	{
		/// <summary>
		/// The <see cref="Configuration"/> constructor
		/// </summary>
		public Configuration()
		{
			ApplicationVersion = string.Empty;
			ConfigurationVersion = AssemblyVersion;
		}

		/// <summary>
		/// The <see cref="Configuration"/> constructor
		/// </summary>
		/// <param name="softwareVersion"></param>
		/// <exception cref="ArgumentNullException"></exception>
		public Configuration(string softwareVersion)
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
}