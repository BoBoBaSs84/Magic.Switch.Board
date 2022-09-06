using System.Globalization;
using System.IO;
using System.Reflection;

namespace Magic.Switch.Board.UI;

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

	/// <summary>
	/// Provides possible language values
	/// </summary>
	/// <returns></returns>
	public static CultureInfo[] GetSupportedLanguages() => new[]
	{
		new CultureInfo("en-US"),
		new CultureInfo("de-DE"),
		new CultureInfo("fr-FR")
	};
}