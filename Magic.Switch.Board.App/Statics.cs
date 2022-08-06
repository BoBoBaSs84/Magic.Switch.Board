using System.Globalization;
using System.Reflection;

namespace Magic.Switch.Board.App;

internal static class Statics
{
	private static readonly Assembly assembly;
	public static string AssemblyVersion { get; private set; }
	public static string AssemblyName { get; private set; }
	public static string AssemblyLocation { get; private set; }
	public static string AsseblyDirectory { get; private set; }
	public static CultureInfo Culture { get; private set; }
	public static string NlogConfigFileName { get; private set; }

	static Statics()
	{
		assembly = Assembly.GetExecutingAssembly();
		AssemblyVersion = assembly.GetName().Version!.ToString();
		AssemblyName = assembly.GetName().Name!;
		AssemblyLocation = assembly.Location;
		AsseblyDirectory = Path.GetDirectoryName(assembly.Location)!;
		Culture = CultureInfo.CurrentCulture;
		NlogConfigFileName = "nlog.config";
	}
}
