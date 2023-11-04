using System.Globalization;
using System.IO;
using System.Reflection;

namespace Magic.Switch.Board.UI;

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