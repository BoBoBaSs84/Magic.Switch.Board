﻿using Magic.Switch.Board.Models.Application;
using System.Text;

namespace Magic.Switch.Board.Services.Application.Interfaces;

/// <summary>
/// The <see cref="IConfigurationService"/> interface exposes the public methods for reading an writing the application configuration file
/// </summary>
public interface IConfigurationService
{
	/// <summary>
	/// The <see cref="Create"/> method creates a new application <see cref="Configuration"/>.
	/// </summary>
	/// <param name="applicationVersion">The Version of the application that creates the configuration.</param>
	/// <returns><see cref="Configuration"/></returns>
	public Configuration Create(string applicationVersion);

	/// <summary>
	/// The <see cref="Read"/> method reads the <see cref="Configuration"/> from file.
	/// </summary>
	/// <returns><see cref="Configuration"/></returns>
	public Configuration? Read();

	/// <summary>
	/// The <see cref="Write(Configuration)"/> method writes the application configuration to file.
	/// </summary>
	/// <remarks>
	/// This method will enforce to use <see cref="Encoding.UTF8"/>.
	/// </remarks>
	/// <param name="configuration">The application configuration.</param>
	/// <returns>The success of true or false. </returns>
	public bool Write(Configuration configuration);

	/// <summary>
	/// The <see cref="Write(Configuration, Encoding?)"/> method writes the application configuration to file.
	/// </summary>
	/// <remarks>
	/// Since encoding can be <see cref="Nullable"/>, when null, <see cref="Encoding.UTF8"/> will be used.
	/// </remarks>
	/// <param name="configuration">The application configuration.</param>
	/// <param name="encoding">The encoding type.</param>
	/// <returns>The success of true or false. </returns>
	public bool Write(Configuration configuration, Encoding? encoding);
}