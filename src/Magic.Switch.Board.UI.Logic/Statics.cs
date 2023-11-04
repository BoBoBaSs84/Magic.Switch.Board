using System.IO;
using System.Reflection;

namespace Magic.Switch.Board.UI.Logic;

internal static class Statics
{
	private static readonly Assembly Assembly;
	public static string AssemblyVersion { get; private set; }
	public static string AsseblyDirectory { get; private set; }

	static Statics()
	{
		Assembly = Assembly.GetExecutingAssembly();
		AssemblyVersion = Assembly.GetName().Version!.ToString();
		AsseblyDirectory = Path.GetDirectoryName(Assembly.Location)!;
	}
}