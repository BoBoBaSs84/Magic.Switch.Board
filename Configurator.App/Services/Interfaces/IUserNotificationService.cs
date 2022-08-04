namespace Configurator.Services.Interfaces
{
	/// <summary>
	/// User notification service interface.
	/// </summary>
	public interface IUserNotificationService
	{
		/// <summary>
		/// Notifies the user with a provided message.
		/// </summary>
		/// <param name="message">The message that should be shown to the user.</param>
		/// <param name="logIt">Should the message be logged.</param>
		/// <returns>A <see cref="Task" /> that can be awaited.</returns>
		Task NotifyWithMessageAsync(string message, bool logIt = false);
	}
}
