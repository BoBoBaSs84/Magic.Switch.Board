using Microsoft.Extensions.Configuration.UserSecrets;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Windows;

#if (DEBUG)
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif
[assembly: UserSecretsId("27296C33-913A-4F49-A2D8-5124C95BAFB5")]
[assembly: AssemblyCompany("https://github.com/BoBoBaSs84")]
[assembly: AssemblyCopyright("© 2022 BoBoBaSs84")]
[assembly: AssemblyProduct("Magic.Switch.Board.App")]
[assembly: AssemblyTitle("Magic.Switch.Board.App")]
[assembly: AssemblyVersion("1.0.0.*")]
[assembly: AssemblyMetadata("RepositoryUrl", "https://github.com/BoBoBaSs84/Magic.Switch.Board")]
[assembly: Guid("27296C33-913A-4F49-A2D8-5124C95BAFB5")]
[assembly: ComVisible(false)]
[assembly: NeutralResourcesLanguage("en-US")]
[assembly: ThemeInfo(
		ResourceDictionaryLocation.None, //where theme specific resource dictionaries are located
										 //(used if a resource is not found in the page,
										 // or application resource dictionaries)
		ResourceDictionaryLocation.SourceAssembly //where the generic resource dictionary is located
												  //(used if a resource is not found in the page,
												  // app, or any theme specific resource dictionaries)
)]