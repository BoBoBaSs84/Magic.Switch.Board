using Configurator.Services.Interfaces;
using Microsoft.Extensions.Logging;

namespace Configurator.Services
{
	/// <summary>
	/// User notification service
	/// </summary>
	public partial class UserNotificationService : IUserNotificationService
	{
		private readonly ILogger<UserNotificationService> logger;

		/// <summary>
		/// Initialises the <see cref="UserNotificationService" /> using the specified dependencies.
		/// </summary>
		/// <param name="logger"></param>
		public UserNotificationService(ILogger<UserNotificationService> logger)
		{
			this.logger = logger;
		}

		/// <inheritdoc/>
		public Task NotifyWithMessageAsync(string message, bool logIt = false)
		{
			if (logIt)
				LogNotification(message);			

			return Task.CompletedTask;
		}

		/// <summary>
		/// Logs the messages the user gets
		/// </summary>
		/// <param name="message">The message shown to the user.</param>
		[LoggerMessage(EventId = 100, Level = LogLevel.Information, Message = "{message}")]
		partial void LogNotification(string message);
	}
}