namespace Magic.Switch.Board.Services;

internal static class Statics
{
	public static string AppConfigFileName { get; private set; }
	public static string DeviceConfigFileName { get; private set; }

	static Statics()
	{
		AppConfigFileName = "ApplicationConfiguration.xml";
		DeviceConfigFileName = "DeviceConfiguration.xml";
	}
}