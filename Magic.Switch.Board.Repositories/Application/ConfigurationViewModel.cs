using Magic.Switch.Board.Contracts.Base;
using Magic.Switch.Board.Models;
using Magic.Switch.Board.Models.Application;
using Magic.Switch.Board.Services.Application.Interfaces;
using System.ComponentModel.DataAnnotations;
using static Magic.Switch.Board.Models.Enums;

namespace Magic.Switch.Board.Contracts.Application
{
	/// <summary>
	/// The <see cref="ConfigurationViewModel"/> class
	/// </summary>
	public class ConfigurationViewModel : ViewModelBase
	{
		private readonly string applicationVersion;
		private readonly IConfigurationService configurationService;
		private Configuration configuration = default!;

		/// <summary>
		/// The <see cref="ConfigurationViewModel"/> class constructor
		/// </summary>
		/// <param name="configurationService"></param>
		/// <param name="applicationVersion"></param>
		public ConfigurationViewModel(IConfigurationService configurationService, string applicationVersion)
		{
			this.configurationService = configurationService;
			this.applicationVersion = applicationVersion;
			configuration = configurationService.Read()!;
			configuration ??= configurationService.Create(applicationVersion);
			configurationService.Write(configuration);
		}

		/// <summary>
		/// The <see cref="Id"/> property
		/// </summary>
		public Guid Id { get => configuration.Id; }

		/// <summary>
		/// The <see cref="ApplicationVersion"/> property
		/// </summary>
		public string ApplicationVersion { get => configuration.ApplicationVersion; }

		/// <summary>
		/// <see cref="ConfigurationVersion"/> property
		/// </summary>
		public string ConfigurationVersion { get => configuration.ConfigurationVersion; }

		private LogLevel logLevel;

		/// <summary>
		/// The <see cref="LogLevel"/> property
		/// </summary>
		[Required]
		public LogLevel LogLevel
		{
			get => logLevel;
			set => SetProperty(ref logLevel, value);
		}

		/// <summary>
		/// The <see cref="Reload"/> method for reloading the application configuration.
		/// </summary>
		protected void Reload() => configuration = configurationService.Read()!;

		/// <summary>
		/// The <see cref="Default"/> method for creating a new configuration with default values.
		/// </summary>
		protected void Default() => configuration = configurationService.Create(applicationVersion);

		/// <summary>
		/// The <see cref="Save"/> method saves the current configuration to file.
		/// </summary>
		protected void Save() => configurationService.Write(configuration);

		/// <summary>
		/// The <see cref="GetLogLevels"/> method returns a list of log level enums.
		/// </summary>
		/// <returns>A list of log level enums.</returns>
		protected static List<LogLevel> GetLogLevels() => LogLevel.None.GetListFromEnum();
	}
}