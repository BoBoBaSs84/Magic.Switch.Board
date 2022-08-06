using System.Globalization;
using System.Reflection;

namespace Magic.Switch.Board.Services;

internal static class Statics
{
	private static readonly Assembly assembly;
	public static string AssemblyDirectory { get; private set; }
	public static string AssemblyName { get; private set; }
	public static string AppConfigFileName { get; private set; }
	public static CultureInfo CultureInfo { get; private set; }
	public static string DeviceConfigFileName { get; private set; }
	public static string LogFileName { get; private set; }

	static Statics()
	{
		assembly = Assembly.GetExecutingAssembly();
		AssemblyDirectory = Path.GetDirectoryName(assembly.Location);
		AssemblyName = assembly.GetName().Name;
		AppConfigFileName = $"{AssemblyDirectory}\\ApplicationConfiguration.xml";
		CultureInfo = CultureInfo.CurrentCulture;
		DeviceConfigFileName = $"{AssemblyDirectory}\\DeviceConfiguration.xml";
		LogFileName = $"{AssemblyDirectory}\\{AssemblyName}.log";
	}
}