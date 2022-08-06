using System.Reflection;

namespace Magic.Switch.Board.Entities;

internal static class Statics
{
	private static readonly Assembly assembly;
	public static string AssemblyVersion { get; private set; }

	static Statics()
	{
		assembly = Assembly.GetExecutingAssembly();
		AssemblyVersion = assembly.GetName().Version!.ToString();
	}
}