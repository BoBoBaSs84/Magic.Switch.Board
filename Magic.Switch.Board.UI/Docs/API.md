<a name='assembly'></a>
# Magic.Switch.Board.UI

## Contents

- [App](#T-Magic-Switch-Board-UI-App 'Magic.Switch.Board.UI.App')
  - [#ctor()](#M-Magic-Switch-Board-UI-App-#ctor 'Magic.Switch.Board.UI.App.#ctor')
  - [Application_Exit(sender,e)](#M-Magic-Switch-Board-UI-App-Application_Exit-System-Object,System-Windows-ExitEventArgs- 'Magic.Switch.Board.UI.App.Application_Exit(System.Object,System.Windows.ExitEventArgs)')
  - [Application_Startup(sender,e)](#M-Magic-Switch-Board-UI-App-Application_Startup-System-Object,System-Windows-StartupEventArgs- 'Magic.Switch.Board.UI.App.Application_Startup(System.Object,System.Windows.StartupEventArgs)')
  - [GetService\`\`1()](#M-Magic-Switch-Board-UI-App-GetService``1 'Magic.Switch.Board.UI.App.GetService``1')
  - [InitializeComponent()](#M-Magic-Switch-Board-UI-App-InitializeComponent 'Magic.Switch.Board.UI.App.InitializeComponent')
  - [Main()](#M-Magic-Switch-Board-UI-App-Main 'Magic.Switch.Board.UI.App.Main')
- [MainWindow](#T-Magic-Switch-Board-UI-Views-MainWindow 'Magic.Switch.Board.UI.Views.MainWindow')
  - [#ctor()](#M-Magic-Switch-Board-UI-Views-MainWindow-#ctor 'Magic.Switch.Board.UI.Views.MainWindow.#ctor')
  - [InitializeComponent()](#M-Magic-Switch-Board-UI-Views-MainWindow-InitializeComponent 'Magic.Switch.Board.UI.Views.MainWindow.InitializeComponent')
- [Resources](#T-Magic-Switch-Board-UI-Properties-Resources 'Magic.Switch.Board.UI.Properties.Resources')
  - [Culture](#P-Magic-Switch-Board-UI-Properties-Resources-Culture 'Magic.Switch.Board.UI.Properties.Resources.Culture')
  - [File_New](#P-Magic-Switch-Board-UI-Properties-Resources-File_New 'Magic.Switch.Board.UI.Properties.Resources.File_New')
  - [File_Open](#P-Magic-Switch-Board-UI-Properties-Resources-File_Open 'Magic.Switch.Board.UI.Properties.Resources.File_Open')
  - [File_Quit](#P-Magic-Switch-Board-UI-Properties-Resources-File_Quit 'Magic.Switch.Board.UI.Properties.Resources.File_Quit')
  - [File_Settings](#P-Magic-Switch-Board-UI-Properties-Resources-File_Settings 'Magic.Switch.Board.UI.Properties.Resources.File_Settings')
  - [Help_About](#P-Magic-Switch-Board-UI-Properties-Resources-Help_About 'Magic.Switch.Board.UI.Properties.Resources.Help_About')
  - [Help_Center](#P-Magic-Switch-Board-UI-Properties-Resources-Help_Center 'Magic.Switch.Board.UI.Properties.Resources.Help_Center')
  - [Help_News](#P-Magic-Switch-Board-UI-Properties-Resources-Help_News 'Magic.Switch.Board.UI.Properties.Resources.Help_News')
  - [Help_Update](#P-Magic-Switch-Board-UI-Properties-Resources-Help_Update 'Magic.Switch.Board.UI.Properties.Resources.Help_Update')
  - [Magic_Switch_Board](#P-Magic-Switch-Board-UI-Properties-Resources-Magic_Switch_Board 'Magic.Switch.Board.UI.Properties.Resources.Magic_Switch_Board')
  - [ResourceManager](#P-Magic-Switch-Board-UI-Properties-Resources-ResourceManager 'Magic.Switch.Board.UI.Properties.Resources.ResourceManager')
- [ServiceCollectionExtension](#T-Magic-Switch-Board-UI-Extensions-ServiceCollectionExtension 'Magic.Switch.Board.UI.Extensions.ServiceCollectionExtension')
  - [ConfigureSingletonServices(services)](#M-Magic-Switch-Board-UI-Extensions-ServiceCollectionExtension-ConfigureSingletonServices-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'Magic.Switch.Board.UI.Extensions.ServiceCollectionExtension.ConfigureSingletonServices(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
  - [ConfigureTransientServices(services)](#M-Magic-Switch-Board-UI-Extensions-ServiceCollectionExtension-ConfigureTransientServices-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'Magic.Switch.Board.UI.Extensions.ServiceCollectionExtension.ConfigureTransientServices(Microsoft.Extensions.DependencyInjection.IServiceCollection)')
- [Statics](#T-Magic-Switch-Board-Statics 'Magic.Switch.Board.Statics')
  - [GetSupportedLanguages()](#M-Magic-Switch-Board-Statics-GetSupportedLanguages 'Magic.Switch.Board.Statics.GetSupportedLanguages')

<a name='T-Magic-Switch-Board-UI-App'></a>
## App `type`

##### Namespace

Magic.Switch.Board.UI

##### Summary

Interaction logic for App.xaml

<a name='M-Magic-Switch-Board-UI-App-#ctor'></a>
### #ctor() `constructor`

##### Summary

The App constructor

##### Parameters

This constructor has no parameters.

<a name='M-Magic-Switch-Board-UI-App-Application_Exit-System-Object,System-Windows-ExitEventArgs-'></a>
### Application_Exit(sender,e) `method`

##### Summary

The [Application_Exit](#M-Magic-Switch-Board-UI-App-Application_Exit-System-Object,System-Windows-ExitEventArgs- 'Magic.Switch.Board.UI.App.Application_Exit(System.Object,System.Windows.ExitEventArgs)') method should exit the application.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.ExitEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.ExitEventArgs 'System.Windows.ExitEventArgs') |  |

<a name='M-Magic-Switch-Board-UI-App-Application_Startup-System-Object,System-Windows-StartupEventArgs-'></a>
### Application_Startup(sender,e) `method`

##### Summary

The [Application_Startup](#M-Magic-Switch-Board-UI-App-Application_Startup-System-Object,System-Windows-StartupEventArgs- 'Magic.Switch.Board.UI.App.Application_Startup(System.Object,System.Windows.StartupEventArgs)') method should start the application.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Windows.StartupEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.StartupEventArgs 'System.Windows.StartupEventArgs') |  |

<a name='M-Magic-Switch-Board-UI-App-GetService``1'></a>
### GetService\`\`1() `method`

##### Summary

The [GetService\`\`1](#M-Magic-Switch-Board-UI-App-GetService``1 'Magic.Switch.Board.UI.App.GetService``1') method should the requested registered service.

##### Returns

The registered service.

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The requested service. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | If a service is not registered. |

<a name='M-Magic-Switch-Board-UI-App-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='M-Magic-Switch-Board-UI-App-Main'></a>
### Main() `method`

##### Summary

Application Entry Point.

##### Parameters

This method has no parameters.

<a name='T-Magic-Switch-Board-UI-Views-MainWindow'></a>
## MainWindow `type`

##### Namespace

Magic.Switch.Board.UI.Views

##### Summary

Interaction logic for MainWindow.xaml

<a name='M-Magic-Switch-Board-UI-Views-MainWindow-#ctor'></a>
### #ctor() `constructor`

##### Summary

The [MainWindow](#T-Magic-Switch-Board-UI-Views-MainWindow 'Magic.Switch.Board.UI.Views.MainWindow') constructor

##### Parameters

This constructor has no parameters.

<a name='M-Magic-Switch-Board-UI-Views-MainWindow-InitializeComponent'></a>
### InitializeComponent() `method`

##### Summary

InitializeComponent

##### Parameters

This method has no parameters.

<a name='T-Magic-Switch-Board-UI-Properties-Resources'></a>
## Resources `type`

##### Namespace

Magic.Switch.Board.UI.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-Magic-Switch-Board-UI-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-Magic-Switch-Board-UI-Properties-Resources-File_New'></a>
### File_New `property`

##### Summary

Looks up a localized resource of type System.Drawing.Icon similar to (Icon).

<a name='P-Magic-Switch-Board-UI-Properties-Resources-File_Open'></a>
### File_Open `property`

##### Summary

Looks up a localized resource of type System.Drawing.Icon similar to (Icon).

<a name='P-Magic-Switch-Board-UI-Properties-Resources-File_Quit'></a>
### File_Quit `property`

##### Summary

Looks up a localized resource of type System.Drawing.Icon similar to (Icon).

<a name='P-Magic-Switch-Board-UI-Properties-Resources-File_Settings'></a>
### File_Settings `property`

##### Summary

Looks up a localized resource of type System.Drawing.Icon similar to (Icon).

<a name='P-Magic-Switch-Board-UI-Properties-Resources-Help_About'></a>
### Help_About `property`

##### Summary

Looks up a localized resource of type System.Drawing.Icon similar to (Icon).

<a name='P-Magic-Switch-Board-UI-Properties-Resources-Help_Center'></a>
### Help_Center `property`

##### Summary

Looks up a localized resource of type System.Drawing.Icon similar to (Icon).

<a name='P-Magic-Switch-Board-UI-Properties-Resources-Help_News'></a>
### Help_News `property`

##### Summary

Looks up a localized resource of type System.Drawing.Icon similar to (Icon).

<a name='P-Magic-Switch-Board-UI-Properties-Resources-Help_Update'></a>
### Help_Update `property`

##### Summary

Looks up a localized resource of type System.Drawing.Icon similar to (Icon).

<a name='P-Magic-Switch-Board-UI-Properties-Resources-Magic_Switch_Board'></a>
### Magic_Switch_Board `property`

##### Summary

Looks up a localized resource of type System.Drawing.Icon similar to (Icon).

<a name='P-Magic-Switch-Board-UI-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-Magic-Switch-Board-UI-Extensions-ServiceCollectionExtension'></a>
## ServiceCollectionExtension `type`

##### Namespace

Magic.Switch.Board.UI.Extensions

<a name='M-Magic-Switch-Board-UI-Extensions-ServiceCollectionExtension-ConfigureSingletonServices-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### ConfigureSingletonServices(services) `method`

##### Summary

The [ConfigureSingletonServices](#M-Magic-Switch-Board-UI-Extensions-ServiceCollectionExtension-ConfigureSingletonServices-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'Magic.Switch.Board.UI.Extensions.ServiceCollectionExtension.ConfigureSingletonServices(Microsoft.Extensions.DependencyInjection.IServiceCollection)') method should add transient services of the type specified

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') |  |

<a name='M-Magic-Switch-Board-UI-Extensions-ServiceCollectionExtension-ConfigureTransientServices-Microsoft-Extensions-DependencyInjection-IServiceCollection-'></a>
### ConfigureTransientServices(services) `method`

##### Summary

The [ConfigureTransientServices](#M-Magic-Switch-Board-UI-Extensions-ServiceCollectionExtension-ConfigureTransientServices-Microsoft-Extensions-DependencyInjection-IServiceCollection- 'Magic.Switch.Board.UI.Extensions.ServiceCollectionExtension.ConfigureTransientServices(Microsoft.Extensions.DependencyInjection.IServiceCollection)') method should add transient services of the type specified

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') |  |

<a name='T-Magic-Switch-Board-Statics'></a>
## Statics `type`

##### Namespace

Magic.Switch.Board

<a name='M-Magic-Switch-Board-Statics-GetSupportedLanguages'></a>
### GetSupportedLanguages() `method`

##### Summary

Provides possible language values

##### Returns



##### Parameters

This method has no parameters.
