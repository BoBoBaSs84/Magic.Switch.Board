using System.Reflection;

namespace Magic.Switch.Board.Models;

/// <summary>
/// The static <see cref="Statics"/> class.
/// </summary>
internal static class Statics
{
	private static readonly Assembly assembly;
	
	/// <summary>
	/// The <see cref="AssemblyVersion"/> property.
	/// </summary>
	public static string AssemblyVersion { get; private set; }

	/// <summary>
	/// The static <see cref="Statics"/> class constructor.
	/// </summary>
	static Statics()
	{
		assembly = Assembly.GetExecutingAssembly();
		AssemblyVersion = assembly.GetName().Version!.ToString();
	}
}