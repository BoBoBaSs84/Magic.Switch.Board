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
		public Configuration Create(string softwareVersion) =>
			new(softwareVersion);

		/// <inheritdoc/>
		public Configuration? Read() =>
			XmlSerializerDeserializer<Configuration>.ReadFile(DeviceConfigFileName);

		/// <inheritdoc/>
		public void Write(Configuration configuration, Encoding? encoding) =>
			XmlSerializerDeserializer<Configuration>.WriteFile(DeviceConfigFileName, configuration, encoding);
	}
}
