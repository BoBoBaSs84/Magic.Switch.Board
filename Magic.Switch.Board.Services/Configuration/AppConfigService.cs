using Magic.Switch.Board.Entities.Configuration;
using Magic.Switch.Board.Services.Configuration.Interfaces;
using Magic.Switch.Board.Services.Helpers;
using System.Text;
using static Magic.Switch.Board.Services.Statics;

namespace Magic.Switch.Board.Services.Configuration;

/// <summary>
/// The <see cref="AppConfigService"/> class implements the members of the <see cref="IAppConfigService"/> interface
/// </summary>
public class AppConfigService : IAppConfigService
{
	/// <inheritdoc/>
	public ApplicationConfiguration Create(string applicationVersion) =>
		new(applicationVersion);

	/// <inheritdoc/>
	public ApplicationConfiguration? Read() =>
		XmlHelper<ApplicationConfiguration>.ReadFile(AppConfigFileName);

	/// <inheritdoc/>
	public void Write(ApplicationConfiguration configuration, Encoding? encoding) =>
		XmlHelper<ApplicationConfiguration>.WriteFile(AppConfigFileName, configuration, encoding);
}