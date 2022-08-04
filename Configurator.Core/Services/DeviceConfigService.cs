using Configurator.Core.Helpers;
using Configurator.Core.Models.Device;
using Configurator.Core.Services.Interfaces;
using System.Text;
using static Configurator.Core.Constants;

namespace Configurator.Core.Services
{
	/// <summary>
	/// The <see cref="DeviceConfigService"/> class implements the members of the <see cref="IDeviceConfigService"/> interface
	/// </summary>
	public class DeviceConfigService : IDeviceConfigService
	{
		/// <inheritdoc/>
		public Configuration Create(string softwareVersion) => new(softwareVersion);

		/// <inheritdoc/>
		public Configuration? Read()
		{
			if (!File.Exists(DeviceConfigFileName))
				return null;

			string readText = File.ReadAllText(DeviceConfigFileName);
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
			File.WriteAllText(DeviceConfigFileName, content, encoding);
		}
	}
}
