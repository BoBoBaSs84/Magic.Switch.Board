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
		public Configuration Create(string applicationVersion) =>
			new(applicationVersion);
		
		/// <inheritdoc/>
		public Configuration? Read() =>
			XmlSerializerDeserializer<Configuration>.ReadFile(AppConfigFileName);
		
		/// <inheritdoc/>
		public void Write(Configuration configuration, Encoding? encoding) =>
			XmlSerializerDeserializer<Configuration>.WriteFile(AppConfigFileName, configuration, encoding);
	}
}
