using System.Globalization;
using System.Reflection;

namespace Configurator.Core
{
	internal static class Statics
	{
		private static readonly Assembly assembly;
		public static string AssemblyVersion { get; private set; }
		public static string AssemblyName { get; private set; }
		public static string AssemblyLocation { get; private set; }
		public static CultureInfo Culture { get; private set; }

		static Statics()
		{
			assembly = Assembly.GetExecutingAssembly();
			AssemblyVersion = assembly.GetName().Version!.ToString();
			AssemblyName = assembly.GetName().Name!;
			AssemblyLocation = assembly.Location;
			Culture = CultureInfo.CurrentCulture;
		}
	}
}
