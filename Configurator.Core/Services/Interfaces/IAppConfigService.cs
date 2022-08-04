using Configurator.Core.Models.Application;
using System.Text;

namespace Configurator.Core.Services.Interfaces
{
	/// <summary>
	/// The <see cref="IAppConfigService"/> interface exposes the public methods for reading an writing the application configuration file
	/// </summary>
	public interface IAppConfigService
	{
		/// <summary>
		/// The <see cref="Write(Configuration, Encoding?)"/> method writes the application configuration to file
		/// </summary>
		/// <remarks>
		/// Since encoding can be <see cref="Nullable"/>, when null, <see cref="Encoding.UTF8"/> will be used.
		/// </remarks>
		/// <param name="configuration"></param>
		/// <param name="encoding"></param>
		public void Write(Configuration configuration, Encoding? encoding);

		/// <summary>
		/// The <see cref="Read"/> method reads the application <see cref="Configuration"/> from file
		/// </summary>
		/// <returns><see cref="Configuration"/></returns>
		public Configuration? Read();

		/// <summary>
		/// The <see cref="Create"/> method creates a new application <see cref="Configuration"/>
		/// </summary>
		/// <param name="applicationVersion">The Version of the software that creates the configuration</param>
		/// <returns><see cref="Configuration"/></returns>
		public Configuration Create(string applicationVersion);
	}
}
