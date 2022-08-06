using System.Reflection;

namespace Magic.Switch.Board.Services;

internal static class Statics
{
	private static readonly Assembly assembly;
	public static string AssemblyDirectory { get; private set; }
	public static string AppConfigFileName { get; private set; }
	public static string DeviceConfigFileName { get; private set; }

	static Statics()
	{
		assembly = Assembly.GetExecutingAssembly();
		AssemblyDirectory = Path.GetDirectoryName(assembly.Location);
		AppConfigFileName = $"{AssemblyDirectory}\\ApplicationConfiguration.xml";
		DeviceConfigFileName = $"{AssemblyDirectory}\\DeviceConfiguration.xml";
	}
}