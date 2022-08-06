using Microsoft.Extensions.Configuration.UserSecrets;
using System.Reflection;
using System.Runtime.InteropServices;

[assembly: UserSecretsId("27296C33-913A-4F49-A2D8-5124C95BAFB5")]
[assembly: AssemblyCompany("https://github.com/BoBoBaSs84")]
[assembly: AssemblyCopyright("© 2022 BoBoBaSs84")]
[assembly: AssemblyProduct("Magic.Switch.Board.App")]
[assembly: AssemblyTitle("Magic.Switch.Board.App")]
[assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyMetadata("RepositoryUrl", "https://github.com/BoBoBaSs84/Magic.Switch.Board")]
[assembly: Guid("27296C33-913A-4F49-A2D8-5124C95BAFB5")]
[assembly: ComVisible(false)]
#if (DEBUG)
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif