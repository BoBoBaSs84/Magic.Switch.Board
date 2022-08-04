using Configurator.Core.Helpers;
using Configurator.Core.Models.Application;
using Configurator.Core.Services.Interfaces;
using System.Text;
using static Configurator.Core.Constants;

namespace Configurator.Core.Services
{
	/// <summary>
	/// The <see cref="AppConfigService"/> class implements the members of the <see cref="IAppConfigService"/> interface
	/// </summary>
	public class AppConfigService : IAppConfigService
	{
		/// <inheritdoc/>
		public Configuration Create(string applicationVersion) => new(applicationVersion);
		/// <inheritdoc/>
		public Configuration? Read()
		{
			if (!File.Exists(AppConfigFileName))
				return null;

			string readText = File.ReadAllText(AppConfigFileName);
			if (readText is null)
				return null;

			XmlSerializerDeserializer<Configuration> xmlSerializerDeserializer = new();
			Configuration? obj = xmlSerializerDeserializer.Deserialize(readText);
			return obj;
		}
		/// <inheritdoc/>
		public void Write(Configuration configuration, Encoding? encoding)
		{
			encoding ??= Encoding.UTF8;
			XmlSerializerDeserializer<Configuration> xmlSerializerDeserializer = new();
			string content = xmlSerializerDeserializer.Serialize(configuration, encoding);
			File.WriteAllText(AppConfigFileName, content, encoding);
		}
	}
}
