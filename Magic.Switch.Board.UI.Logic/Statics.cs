using System.IO;
using System.Reflection;

namespace Magic.Switch.Board.UI.Logic;

internal static class Statics
{
	private static readonly Assembly assembly;
	public static string AssemblyVersion { get; private set; }
	public static string AsseblyDirectory { get; private set; }

	static Statics()
	{
		assembly = Assembly.GetExecutingAssembly();
		AssemblyVersion = assembly.GetName().Version!.ToString();
		AsseblyDirectory = Path.GetDirectoryName(assembly.Location)!;
	}
}