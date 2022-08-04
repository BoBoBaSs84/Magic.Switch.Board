using Configurator.Core.Models.Device;
using System.Text;

namespace Configurator.Core.Services.Interfaces
{
	/// <summary>
	/// The <see cref="IDeviceConfigService"/> interface exposes the public methods for reading an writing the device configuration file
	/// </summary>
	public interface IDeviceConfigService
	{
		/// <summary>
		/// Writes configuration to file
		/// </summary>
		/// <param name="configuration"></param>
		/// <param name="encoding"></param>
		public void Write(Configuration configuration, Encoding? encoding);

		/// <summary>
		/// Reads configuration from file
		/// </summary>
		/// <returns><see cref="Configuration"/></returns>
		public Configuration? Read();

		/// <summary>
		/// The <see cref="Create"/> method creates a new <see cref="Configuration"/>
		/// </summary>
		/// <param name="softwareVersion">The Version of the software that creates the configuration</param>
		/// <returns><see cref="Configuration"/></returns>
		public Configuration Create(string softwareVersion);
	}
}
