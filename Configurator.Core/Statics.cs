namespace Configurator.Core
{
	internal static class Statics
	{
		public static string AssemblyVersion { get; private set; }

		static Statics()
		{
			AssemblyVersion = typeof(Statics).Assembly.GetName().Version!.ToString();
		}
	}
}
