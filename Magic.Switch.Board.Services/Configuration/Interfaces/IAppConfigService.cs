using Magic.Switch.Board.Entities.Configuration;
using System.Text;

namespace Magic.Switch.Board.Services.Configuration.Interfaces;

/// <summary>
/// The <see cref="IAppConfigService"/> interface exposes the public methods for reading an writing the application configuration file
/// </summary>
public interface IAppConfigService
{
	/// <summary>
	/// The <see cref="Write(ApplicationConfiguration)"/> method writes the application configuration to file.
	/// </summary>
	/// <remarks>
	/// This method will enforce to use <see cref="Encoding.UTF8"/>.
	/// </remarks>
	/// <param name="configuration">The application configuration.</param>
	public void Write(ApplicationConfiguration configuration);

	/// <summary>
	/// The <see cref="Write(ApplicationConfiguration, Encoding?)"/> method writes the application configuration to file.
	/// </summary>
	/// <remarks>
	/// Since encoding can be <see cref="Nullable"/>, when null, <see cref="Encoding.UTF8"/> will be used.
	/// </remarks>
	/// <param name="configuration">The application configuration.</param>
	/// <param name="encoding">The encoding type.</param>
	public void Write(ApplicationConfiguration configuration, Encoding? encoding);

	/// <summary>
	/// The <see cref="Read"/> method reads the <see cref="ApplicationConfiguration"/> from file.
	/// </summary>
	/// <returns><see cref="ApplicationConfiguration"/></returns>
	public ApplicationConfiguration? Read();

	/// <summary>
	/// The <see cref="Create"/> method creates a new application <see cref="ApplicationConfiguration"/>.
	/// </summary>
	/// <param name="applicationVersion">The Version of the application that creates the configuration.</param>
	/// <returns><see cref="ApplicationConfiguration"/></returns>
	public ApplicationConfiguration Create(string applicationVersion);
}
