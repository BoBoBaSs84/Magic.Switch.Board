using System.Xml.Serialization;
using static Magic.Switch.Board.Models.Statics;

namespace Magic.Switch.Board.Models.Base
{
	/// <summary>
	/// The <see cref="ConfigurationBase"/> class for configurations.
	/// </summary>
	public abstract class ConfigurationBase
	{
		/// <summary>
		/// The <see cref="ConfigurationBase"/> constructor.
		/// </summary>
		public ConfigurationBase()
		{
			Id = Guid.NewGuid();
			ApplicationVersion = string.Empty;
			ConfigurationVersion = AssemblyVersion;
		}

		/// <summary>
		/// The <see cref="ConfigurationBase"/> constructor.
		/// </summary>
		/// <param name="applicationVersion">The version of the application that creates the configuration.</param>
		/// <exception cref="ArgumentNullException"></exception>
		public ConfigurationBase(string applicationVersion)
		{
			Id = Guid.NewGuid();
			ApplicationVersion = applicationVersion ?? throw new ArgumentNullException(nameof(applicationVersion));
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
	}
}
