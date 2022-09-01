<a name='assembly'></a>
# Magic.Switch.Board.UI.Logic

## Contents

- [ChannelVM](#T-Magic-Switch-Board-UI-Logic-ViewModels-Device-ChannelVM 'Magic.Switch.Board.UI.Logic.ViewModels.Device.ChannelVM')
  - [#ctor(channel)](#M-Magic-Switch-Board-UI-Logic-ViewModels-Device-ChannelVM-#ctor-Magic-Switch-Board-Core-Models-Device-Channel- 'Magic.Switch.Board.UI.Logic.ViewModels.Device.ChannelVM.#ctor(Magic.Switch.Board.Core.Models.Device.Channel)')
  - [Created](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ChannelVM-Created 'Magic.Switch.Board.UI.Logic.ViewModels.Device.ChannelVM.Created')
  - [Description](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ChannelVM-Description 'Magic.Switch.Board.UI.Logic.ViewModels.Device.ChannelVM.Description')
  - [Id](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ChannelVM-Id 'Magic.Switch.Board.UI.Logic.ViewModels.Device.ChannelVM.Id')
  - [Input](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ChannelVM-Input 'Magic.Switch.Board.UI.Logic.ViewModels.Device.ChannelVM.Input')
  - [Loops](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ChannelVM-Loops 'Magic.Switch.Board.UI.Logic.ViewModels.Device.ChannelVM.Loops')
  - [Name](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ChannelVM-Name 'Magic.Switch.Board.UI.Logic.ViewModels.Device.ChannelVM.Name')
  - [Output](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ChannelVM-Output 'Magic.Switch.Board.UI.Logic.ViewModels.Device.ChannelVM.Output')
  - [Switches](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ChannelVM-Switches 'Magic.Switch.Board.UI.Logic.ViewModels.Device.ChannelVM.Switches')
  - [Updated](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ChannelVM-Updated 'Magic.Switch.Board.UI.Logic.ViewModels.Device.ChannelVM.Updated')
- [ConfigurationVM](#T-Magic-Switch-Board-UI-Logic-ViewModels-Device-ConfigurationVM 'Magic.Switch.Board.UI.Logic.ViewModels.Device.ConfigurationVM')
  - [#ctor(configuration)](#M-Magic-Switch-Board-UI-Logic-ViewModels-Device-ConfigurationVM-#ctor-Magic-Switch-Board-Core-Models-Device-Configuration- 'Magic.Switch.Board.UI.Logic.ViewModels.Device.ConfigurationVM.#ctor(Magic.Switch.Board.Core.Models.Device.Configuration)')
  - [ApplicationVersion](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ConfigurationVM-ApplicationVersion 'Magic.Switch.Board.UI.Logic.ViewModels.Device.ConfigurationVM.ApplicationVersion')
  - [Channels](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ConfigurationVM-Channels 'Magic.Switch.Board.UI.Logic.ViewModels.Device.ConfigurationVM.Channels')
  - [ConfigurationVersion](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ConfigurationVM-ConfigurationVersion 'Magic.Switch.Board.UI.Logic.ViewModels.Device.ConfigurationVM.ConfigurationVersion')
  - [Created](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ConfigurationVM-Created 'Magic.Switch.Board.UI.Logic.ViewModels.Device.ConfigurationVM.Created')
  - [Description](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ConfigurationVM-Description 'Magic.Switch.Board.UI.Logic.ViewModels.Device.ConfigurationVM.Description')
  - [Id](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ConfigurationVM-Id 'Magic.Switch.Board.UI.Logic.ViewModels.Device.ConfigurationVM.Id')
  - [Name](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ConfigurationVM-Name 'Magic.Switch.Board.UI.Logic.ViewModels.Device.ConfigurationVM.Name')
  - [Updated](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ConfigurationVM-Updated 'Magic.Switch.Board.UI.Logic.ViewModels.Device.ConfigurationVM.Updated')
- [InputVM](#T-Magic-Switch-Board-UI-Logic-ViewModels-Device-InputVM 'Magic.Switch.Board.UI.Logic.ViewModels.Device.InputVM')
  - [#ctor(model)](#M-Magic-Switch-Board-UI-Logic-ViewModels-Device-InputVM-#ctor-Magic-Switch-Board-Core-Models-Device-Input- 'Magic.Switch.Board.UI.Logic.ViewModels.Device.InputVM.#ctor(Magic.Switch.Board.Core.Models.Device.Input)')
  - [MessageType](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-InputVM-MessageType 'Magic.Switch.Board.UI.Logic.ViewModels.Device.InputVM.MessageType')
  - [MidiChannel](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-InputVM-MidiChannel 'Magic.Switch.Board.UI.Logic.ViewModels.Device.InputVM.MidiChannel')
  - [Number](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-InputVM-Number 'Magic.Switch.Board.UI.Logic.ViewModels.Device.InputVM.Number')
- [LoopsVM](#T-Magic-Switch-Board-UI-Logic-ViewModels-Device-LoopsVM 'Magic.Switch.Board.UI.Logic.ViewModels.Device.LoopsVM')
  - [#ctor(model)](#M-Magic-Switch-Board-UI-Logic-ViewModels-Device-LoopsVM-#ctor-Magic-Switch-Board-Core-Models-Device-Loops- 'Magic.Switch.Board.UI.Logic.ViewModels.Device.LoopsVM.#ctor(Magic.Switch.Board.Core.Models.Device.Loops)')
  - [Channels](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-LoopsVM-Channels 'Magic.Switch.Board.UI.Logic.ViewModels.Device.LoopsVM.Channels')
- [MainViewModel](#T-Magic-Switch-Board-UI-Logic-ViewModels-MainViewModel 'Magic.Switch.Board.UI.Logic.ViewModels.MainViewModel')
  - [#ctor(logger,deviceConfigService,enumService)](#M-Magic-Switch-Board-UI-Logic-ViewModels-MainViewModel-#ctor-Magic-Switch-Board-Core-Contracts-Services-ILoggerService,Magic-Switch-Board-Core-Contracts-Services-IDeviceConfigService,Magic-Switch-Board-Core-Contracts-Services-IEnumService- 'Magic.Switch.Board.UI.Logic.ViewModels.MainViewModel.#ctor(Magic.Switch.Board.Core.Contracts.Services.ILoggerService,Magic.Switch.Board.Core.Contracts.Services.IDeviceConfigService,Magic.Switch.Board.Core.Contracts.Services.IEnumService)')
  - [ApplicationVersion](#P-Magic-Switch-Board-UI-Logic-ViewModels-MainViewModel-ApplicationVersion 'Magic.Switch.Board.UI.Logic.ViewModels.MainViewModel.ApplicationVersion')
- [NotifyPropertyChangedAttribute](#T-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase-NotifyPropertyChangedAttribute 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase.NotifyPropertyChangedAttribute')
  - [#ctor(propertyName)](#M-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase-NotifyPropertyChangedAttribute-#ctor-System-String- 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase.NotifyPropertyChangedAttribute.#ctor(System.String)')
  - [PropertyName](#P-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase-NotifyPropertyChangedAttribute-PropertyName 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase.NotifyPropertyChangedAttribute.PropertyName')
- [NotifyPropertyChangingAttribute](#T-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase-NotifyPropertyChangingAttribute 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase.NotifyPropertyChangingAttribute')
  - [#ctor(propertyName)](#M-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase-NotifyPropertyChangingAttribute-#ctor-System-String- 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase.NotifyPropertyChangingAttribute.#ctor(System.String)')
  - [PropertyName](#P-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase-NotifyPropertyChangingAttribute-PropertyName 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase.NotifyPropertyChangingAttribute.PropertyName')
- [OutputVM](#T-Magic-Switch-Board-UI-Logic-ViewModels-Device-OutputVM 'Magic.Switch.Board.UI.Logic.ViewModels.Device.OutputVM')
  - [#ctor(model)](#M-Magic-Switch-Board-UI-Logic-ViewModels-Device-OutputVM-#ctor-Magic-Switch-Board-Core-Models-Device-Output- 'Magic.Switch.Board.UI.Logic.ViewModels.Device.OutputVM.#ctor(Magic.Switch.Board.Core.Models.Device.Output)')
  - [MessageType](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-OutputVM-MessageType 'Magic.Switch.Board.UI.Logic.ViewModels.Device.OutputVM.MessageType')
  - [MidiChannel](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-OutputVM-MidiChannel 'Magic.Switch.Board.UI.Logic.ViewModels.Device.OutputVM.MidiChannel')
  - [Number](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-OutputVM-Number 'Magic.Switch.Board.UI.Logic.ViewModels.Device.OutputVM.Number')
- [RelayCommand](#T-Magic-Switch-Board-UI-Logic-BaseTypes-RelayCommand 'Magic.Switch.Board.UI.Logic.BaseTypes.RelayCommand')
  - [#ctor(execute)](#M-Magic-Switch-Board-UI-Logic-BaseTypes-RelayCommand-#ctor-System-Action- 'Magic.Switch.Board.UI.Logic.BaseTypes.RelayCommand.#ctor(System.Action)')
  - [#ctor(execute,canExecute)](#M-Magic-Switch-Board-UI-Logic-BaseTypes-RelayCommand-#ctor-System-Action,System-Func{System-Boolean}- 'Magic.Switch.Board.UI.Logic.BaseTypes.RelayCommand.#ctor(System.Action,System.Func{System.Boolean})')
  - [CanExecute(parameter)](#M-Magic-Switch-Board-UI-Logic-BaseTypes-RelayCommand-CanExecute-System-Object- 'Magic.Switch.Board.UI.Logic.BaseTypes.RelayCommand.CanExecute(System.Object)')
  - [Execute(parameter)](#M-Magic-Switch-Board-UI-Logic-BaseTypes-RelayCommand-Execute-System-Object- 'Magic.Switch.Board.UI.Logic.BaseTypes.RelayCommand.Execute(System.Object)')
  - [RaiseCanExecuteChanged()](#M-Magic-Switch-Board-UI-Logic-BaseTypes-RelayCommand-RaiseCanExecuteChanged 'Magic.Switch.Board.UI.Logic.BaseTypes.RelayCommand.RaiseCanExecuteChanged')
- [Resources](#T-Magic-Switch-Board-UI-Logic-Properties-Resources 'Magic.Switch.Board.UI.Logic.Properties.Resources')
  - [Culture](#P-Magic-Switch-Board-UI-Logic-Properties-Resources-Culture 'Magic.Switch.Board.UI.Logic.Properties.Resources.Culture')
  - [ResourceManager](#P-Magic-Switch-Board-UI-Logic-Properties-Resources-ResourceManager 'Magic.Switch.Board.UI.Logic.Properties.Resources.ResourceManager')
  - [ViewModel_Display_Name_Application_Version](#P-Magic-Switch-Board-UI-Logic-Properties-Resources-ViewModel_Display_Name_Application_Version 'Magic.Switch.Board.UI.Logic.Properties.Resources.ViewModel_Display_Name_Application_Version')
  - [ViewModel_Display_Name_Channels](#P-Magic-Switch-Board-UI-Logic-Properties-Resources-ViewModel_Display_Name_Channels 'Magic.Switch.Board.UI.Logic.Properties.Resources.ViewModel_Display_Name_Channels')
  - [ViewModel_Display_Name_Configuration_Version](#P-Magic-Switch-Board-UI-Logic-Properties-Resources-ViewModel_Display_Name_Configuration_Version 'Magic.Switch.Board.UI.Logic.Properties.Resources.ViewModel_Display_Name_Configuration_Version')
  - [ViewModel_Display_Name_Created](#P-Magic-Switch-Board-UI-Logic-Properties-Resources-ViewModel_Display_Name_Created 'Magic.Switch.Board.UI.Logic.Properties.Resources.ViewModel_Display_Name_Created')
  - [ViewModel_Display_Name_Description](#P-Magic-Switch-Board-UI-Logic-Properties-Resources-ViewModel_Display_Name_Description 'Magic.Switch.Board.UI.Logic.Properties.Resources.ViewModel_Display_Name_Description')
  - [ViewModel_Display_Name_Id](#P-Magic-Switch-Board-UI-Logic-Properties-Resources-ViewModel_Display_Name_Id 'Magic.Switch.Board.UI.Logic.Properties.Resources.ViewModel_Display_Name_Id')
  - [ViewModel_Display_Name_Input](#P-Magic-Switch-Board-UI-Logic-Properties-Resources-ViewModel_Display_Name_Input 'Magic.Switch.Board.UI.Logic.Properties.Resources.ViewModel_Display_Name_Input')
  - [ViewModel_Display_Name_Loops](#P-Magic-Switch-Board-UI-Logic-Properties-Resources-ViewModel_Display_Name_Loops 'Magic.Switch.Board.UI.Logic.Properties.Resources.ViewModel_Display_Name_Loops')
  - [ViewModel_Display_Name_MessageType](#P-Magic-Switch-Board-UI-Logic-Properties-Resources-ViewModel_Display_Name_MessageType 'Magic.Switch.Board.UI.Logic.Properties.Resources.ViewModel_Display_Name_MessageType')
  - [ViewModel_Display_Name_MidiChannel](#P-Magic-Switch-Board-UI-Logic-Properties-Resources-ViewModel_Display_Name_MidiChannel 'Magic.Switch.Board.UI.Logic.Properties.Resources.ViewModel_Display_Name_MidiChannel')
  - [ViewModel_Display_Name_Name](#P-Magic-Switch-Board-UI-Logic-Properties-Resources-ViewModel_Display_Name_Name 'Magic.Switch.Board.UI.Logic.Properties.Resources.ViewModel_Display_Name_Name')
  - [ViewModel_Display_Name_Number](#P-Magic-Switch-Board-UI-Logic-Properties-Resources-ViewModel_Display_Name_Number 'Magic.Switch.Board.UI.Logic.Properties.Resources.ViewModel_Display_Name_Number')
  - [ViewModel_Display_Name_Output](#P-Magic-Switch-Board-UI-Logic-Properties-Resources-ViewModel_Display_Name_Output 'Magic.Switch.Board.UI.Logic.Properties.Resources.ViewModel_Display_Name_Output')
  - [ViewModel_Display_Name_Switches](#P-Magic-Switch-Board-UI-Logic-Properties-Resources-ViewModel_Display_Name_Switches 'Magic.Switch.Board.UI.Logic.Properties.Resources.ViewModel_Display_Name_Switches')
  - [ViewModel_Display_Name_Updated](#P-Magic-Switch-Board-UI-Logic-Properties-Resources-ViewModel_Display_Name_Updated 'Magic.Switch.Board.UI.Logic.Properties.Resources.ViewModel_Display_Name_Updated')
- [SwitchesVM](#T-Magic-Switch-Board-UI-Logic-ViewModels-Device-SwitchesVM 'Magic.Switch.Board.UI.Logic.ViewModels.Device.SwitchesVM')
  - [#ctor(model)](#M-Magic-Switch-Board-UI-Logic-ViewModels-Device-SwitchesVM-#ctor-Magic-Switch-Board-Core-Models-Device-Switches- 'Magic.Switch.Board.UI.Logic.ViewModels.Device.SwitchesVM.#ctor(Magic.Switch.Board.Core.Models.Device.Switches)')
  - [Channels](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-SwitchesVM-Channels 'Magic.Switch.Board.UI.Logic.ViewModels.Device.SwitchesVM.Channels')
- [ViewModelBase](#T-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase')
  - [NotifyAttributeChangedProperty(propertyName)](#M-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase-NotifyAttributeChangedProperty-System-String- 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase.NotifyAttributeChangedProperty(System.String)')
  - [NotifyAttributeChangingProperty(propertyName)](#M-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase-NotifyAttributeChangingProperty-System-String- 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase.NotifyAttributeChangingProperty(System.String)')
  - [RaisePropertyChanged(propertyName)](#M-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase-RaisePropertyChanged-System-String- 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase.RaisePropertyChanged(System.String)')
  - [RaisePropertyChanging(propertyName)](#M-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase-RaisePropertyChanging-System-String- 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase.RaisePropertyChanging(System.String)')
  - [SetPropertyNoNotify\`\`1(field,newValue,propertyName)](#M-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase-SetPropertyNoNotify``1-``0@,``0,System-String- 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase.SetPropertyNoNotify``1(``0@,``0,System.String)')
  - [SetProperty\`\`1(field,newValue,propertyName)](#M-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase-SetProperty``1-``0@,``0,System-String- 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase.SetProperty``1(``0@,``0,System.String)')
- [ViewModelBase\`1](#T-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase`1 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase`1')
  - [#ctor(model)](#M-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase`1-#ctor-`0- 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase`1.#ctor(`0)')
  - [_propertyErrors](#F-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase`1-_propertyErrors 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase`1._propertyErrors')
  - [HasErrors](#P-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase`1-HasErrors 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase`1.HasErrors')
  - [Model](#P-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase`1-Model 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase`1.Model')
  - [AddError(propertyName,errorMessage)](#M-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase`1-AddError-System-String,System-String- 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase`1.AddError(System.String,System.String)')
  - [ClearErrors(propertyName)](#M-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase`1-ClearErrors-System-String- 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase`1.ClearErrors(System.String)')
  - [GetErrors()](#M-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase`1-GetErrors-System-String- 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase`1.GetErrors(System.String)')
  - [OnPropertyChangedPropagate(sender,e)](#M-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase`1-OnPropertyChangedPropagate-System-Object,System-ComponentModel-PropertyChangedEventArgs- 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase`1.OnPropertyChangedPropagate(System.Object,System.ComponentModel.PropertyChangedEventArgs)')
  - [RaiseErrorsChanged(propertyName)](#M-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase`1-RaiseErrorsChanged-System-String- 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase`1.RaiseErrorsChanged(System.String)')
  - [SetPropertyAndValidate\`\`1(field,newValue,propertyName)](#M-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase`1-SetPropertyAndValidate``1-``0@,``0,System-String- 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase`1.SetPropertyAndValidate``1(``0@,``0,System.String)')
  - [SetPropertyNoNotifyAndValidate\`\`1(field,newValue,propertyName)](#M-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase`1-SetPropertyNoNotifyAndValidate``1-``0@,``0,System-String- 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase`1.SetPropertyNoNotifyAndValidate``1(``0@,``0,System.String)')
  - [Validate\`\`1(value,propertyName)](#M-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase`1-Validate``1-``0,System-String- 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase`1.Validate``1(``0,System.String)')

<a name='T-Magic-Switch-Board-UI-Logic-ViewModels-Device-ChannelVM'></a>
## ChannelVM `type`

##### Namespace

Magic.Switch.Board.UI.Logic.ViewModels.Device

##### Summary

The [ChannelVM](#T-Magic-Switch-Board-UI-Logic-ViewModels-Device-ChannelVM 'Magic.Switch.Board.UI.Logic.ViewModels.Device.ChannelVM') class is the view model class for the model class [Channel](#T-Magic-Switch-Board-Core-Models-Device-Channel 'Magic.Switch.Board.Core.Models.Device.Channel').

<a name='M-Magic-Switch-Board-UI-Logic-ViewModels-Device-ChannelVM-#ctor-Magic-Switch-Board-Core-Models-Device-Channel-'></a>
### #ctor(channel) `constructor`

##### Summary

Initializes a new instance of the [ChannelVM](#T-Magic-Switch-Board-UI-Logic-ViewModels-Device-ChannelVM 'Magic.Switch.Board.UI.Logic.ViewModels.Device.ChannelVM') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| channel | [Magic.Switch.Board.Core.Models.Device.Channel](#T-Magic-Switch-Board-Core-Models-Device-Channel 'Magic.Switch.Board.Core.Models.Device.Channel') | The domain channel model. |

<a name='P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ChannelVM-Created'></a>
### Created `property`

##### Summary

The [Created](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ChannelVM-Created 'Magic.Switch.Board.UI.Logic.ViewModels.Device.ChannelVM.Created') property.

<a name='P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ChannelVM-Description'></a>
### Description `property`

##### Summary

The [Description](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ChannelVM-Description 'Magic.Switch.Board.UI.Logic.ViewModels.Device.ChannelVM.Description') property.

<a name='P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ChannelVM-Id'></a>
### Id `property`

##### Summary

The [Id](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ChannelVM-Id 'Magic.Switch.Board.UI.Logic.ViewModels.Device.ChannelVM.Id') property.

<a name='P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ChannelVM-Input'></a>
### Input `property`

##### Summary

The [Input](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ChannelVM-Input 'Magic.Switch.Board.UI.Logic.ViewModels.Device.ChannelVM.Input') property.

<a name='P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ChannelVM-Loops'></a>
### Loops `property`

##### Summary

The [Loops](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ChannelVM-Loops 'Magic.Switch.Board.UI.Logic.ViewModels.Device.ChannelVM.Loops') property.

<a name='P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ChannelVM-Name'></a>
### Name `property`

##### Summary

The [Name](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ChannelVM-Name 'Magic.Switch.Board.UI.Logic.ViewModels.Device.ChannelVM.Name') property.

<a name='P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ChannelVM-Output'></a>
### Output `property`

##### Summary

The [Output](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ChannelVM-Output 'Magic.Switch.Board.UI.Logic.ViewModels.Device.ChannelVM.Output') property.

<a name='P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ChannelVM-Switches'></a>
### Switches `property`

##### Summary

The [Switches](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ChannelVM-Switches 'Magic.Switch.Board.UI.Logic.ViewModels.Device.ChannelVM.Switches') property.

<a name='P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ChannelVM-Updated'></a>
### Updated `property`

##### Summary

The [Updated](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ChannelVM-Updated 'Magic.Switch.Board.UI.Logic.ViewModels.Device.ChannelVM.Updated') property.

<a name='T-Magic-Switch-Board-UI-Logic-ViewModels-Device-ConfigurationVM'></a>
## ConfigurationVM `type`

##### Namespace

Magic.Switch.Board.UI.Logic.ViewModels.Device

##### Summary

The [ConfigurationVM](#T-Magic-Switch-Board-UI-Logic-ViewModels-Device-ConfigurationVM 'Magic.Switch.Board.UI.Logic.ViewModels.Device.ConfigurationVM') class is the view model class for the model class [Configuration](#T-Magic-Switch-Board-Core-Models-Device-Configuration 'Magic.Switch.Board.Core.Models.Device.Configuration').

<a name='M-Magic-Switch-Board-UI-Logic-ViewModels-Device-ConfigurationVM-#ctor-Magic-Switch-Board-Core-Models-Device-Configuration-'></a>
### #ctor(configuration) `constructor`

##### Summary

Initializes a new instance of the [ConfigurationVM](#T-Magic-Switch-Board-UI-Logic-ViewModels-Device-ConfigurationVM 'Magic.Switch.Board.UI.Logic.ViewModels.Device.ConfigurationVM') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configuration | [Magic.Switch.Board.Core.Models.Device.Configuration](#T-Magic-Switch-Board-Core-Models-Device-Configuration 'Magic.Switch.Board.Core.Models.Device.Configuration') | The domain configuration model. |

<a name='P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ConfigurationVM-ApplicationVersion'></a>
### ApplicationVersion `property`

##### Summary

The [ApplicationVersion](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ConfigurationVM-ApplicationVersion 'Magic.Switch.Board.UI.Logic.ViewModels.Device.ConfigurationVM.ApplicationVersion') property.

<a name='P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ConfigurationVM-Channels'></a>
### Channels `property`

##### Summary

The [Channels](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ConfigurationVM-Channels 'Magic.Switch.Board.UI.Logic.ViewModels.Device.ConfigurationVM.Channels') property.

<a name='P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ConfigurationVM-ConfigurationVersion'></a>
### ConfigurationVersion `property`

##### Summary

The [ConfigurationVersion](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ConfigurationVM-ConfigurationVersion 'Magic.Switch.Board.UI.Logic.ViewModels.Device.ConfigurationVM.ConfigurationVersion') property.

<a name='P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ConfigurationVM-Created'></a>
### Created `property`

##### Summary

The [Created](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ConfigurationVM-Created 'Magic.Switch.Board.UI.Logic.ViewModels.Device.ConfigurationVM.Created') property.

<a name='P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ConfigurationVM-Description'></a>
### Description `property`

##### Summary

The [Description](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ConfigurationVM-Description 'Magic.Switch.Board.UI.Logic.ViewModels.Device.ConfigurationVM.Description') property.

<a name='P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ConfigurationVM-Id'></a>
### Id `property`

##### Summary

The [Id](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ConfigurationVM-Id 'Magic.Switch.Board.UI.Logic.ViewModels.Device.ConfigurationVM.Id') property.

<a name='P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ConfigurationVM-Name'></a>
### Name `property`

##### Summary

The [Name](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ConfigurationVM-Name 'Magic.Switch.Board.UI.Logic.ViewModels.Device.ConfigurationVM.Name') property.

<a name='P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ConfigurationVM-Updated'></a>
### Updated `property`

##### Summary

The [Updated](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-ConfigurationVM-Updated 'Magic.Switch.Board.UI.Logic.ViewModels.Device.ConfigurationVM.Updated') property.

<a name='T-Magic-Switch-Board-UI-Logic-ViewModels-Device-InputVM'></a>
## InputVM `type`

##### Namespace

Magic.Switch.Board.UI.Logic.ViewModels.Device

##### Summary

The [InputVM](#T-Magic-Switch-Board-UI-Logic-ViewModels-Device-InputVM 'Magic.Switch.Board.UI.Logic.ViewModels.Device.InputVM') class is the view model class for the model class [Input](#T-Magic-Switch-Board-Core-Models-Device-Input 'Magic.Switch.Board.Core.Models.Device.Input').

<a name='M-Magic-Switch-Board-UI-Logic-ViewModels-Device-InputVM-#ctor-Magic-Switch-Board-Core-Models-Device-Input-'></a>
### #ctor(model) `constructor`

##### Summary

Initializes a new instance of the [InputVM](#T-Magic-Switch-Board-UI-Logic-ViewModels-Device-InputVM 'Magic.Switch.Board.UI.Logic.ViewModels.Device.InputVM') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [Magic.Switch.Board.Core.Models.Device.Input](#T-Magic-Switch-Board-Core-Models-Device-Input 'Magic.Switch.Board.Core.Models.Device.Input') | The domain channel model. |

<a name='P-Magic-Switch-Board-UI-Logic-ViewModels-Device-InputVM-MessageType'></a>
### MessageType `property`

##### Summary

The [MessageType](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-InputVM-MessageType 'Magic.Switch.Board.UI.Logic.ViewModels.Device.InputVM.MessageType') property.

<a name='P-Magic-Switch-Board-UI-Logic-ViewModels-Device-InputVM-MidiChannel'></a>
### MidiChannel `property`

##### Summary

The [MidiChannel](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-InputVM-MidiChannel 'Magic.Switch.Board.UI.Logic.ViewModels.Device.InputVM.MidiChannel') property.

<a name='P-Magic-Switch-Board-UI-Logic-ViewModels-Device-InputVM-Number'></a>
### Number `property`

##### Summary

The [Number](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-InputVM-Number 'Magic.Switch.Board.UI.Logic.ViewModels.Device.InputVM.Number') property.

<a name='T-Magic-Switch-Board-UI-Logic-ViewModels-Device-LoopsVM'></a>
## LoopsVM `type`

##### Namespace

Magic.Switch.Board.UI.Logic.ViewModels.Device

##### Summary

The [LoopsVM](#T-Magic-Switch-Board-UI-Logic-ViewModels-Device-LoopsVM 'Magic.Switch.Board.UI.Logic.ViewModels.Device.LoopsVM') class is the view model class for the model class [Loops](#T-Magic-Switch-Board-Core-Models-Device-Loops 'Magic.Switch.Board.Core.Models.Device.Loops').

<a name='M-Magic-Switch-Board-UI-Logic-ViewModels-Device-LoopsVM-#ctor-Magic-Switch-Board-Core-Models-Device-Loops-'></a>
### #ctor(model) `constructor`

##### Summary

Initializes a new instance of the [LoopsVM](#T-Magic-Switch-Board-UI-Logic-ViewModels-Device-LoopsVM 'Magic.Switch.Board.UI.Logic.ViewModels.Device.LoopsVM') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [Magic.Switch.Board.Core.Models.Device.Loops](#T-Magic-Switch-Board-Core-Models-Device-Loops 'Magic.Switch.Board.Core.Models.Device.Loops') | The domain channel model. |

<a name='P-Magic-Switch-Board-UI-Logic-ViewModels-Device-LoopsVM-Channels'></a>
### Channels `property`

##### Summary

The [Channels](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-LoopsVM-Channels 'Magic.Switch.Board.UI.Logic.ViewModels.Device.LoopsVM.Channels') property.

<a name='T-Magic-Switch-Board-UI-Logic-ViewModels-MainViewModel'></a>
## MainViewModel `type`

##### Namespace

Magic.Switch.Board.UI.Logic.ViewModels

##### Summary

The [MainViewModel](#T-Magic-Switch-Board-UI-Logic-ViewModels-MainViewModel 'Magic.Switch.Board.UI.Logic.ViewModels.MainViewModel') class.

<a name='M-Magic-Switch-Board-UI-Logic-ViewModels-MainViewModel-#ctor-Magic-Switch-Board-Core-Contracts-Services-ILoggerService,Magic-Switch-Board-Core-Contracts-Services-IDeviceConfigService,Magic-Switch-Board-Core-Contracts-Services-IEnumService-'></a>
### #ctor(logger,deviceConfigService,enumService) `constructor`

##### Summary

Initializes a new instance of the [MainViewModel](#T-Magic-Switch-Board-UI-Logic-ViewModels-MainViewModel 'Magic.Switch.Board.UI.Logic.ViewModels.MainViewModel') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logger | [Magic.Switch.Board.Core.Contracts.Services.ILoggerService](#T-Magic-Switch-Board-Core-Contracts-Services-ILoggerService 'Magic.Switch.Board.Core.Contracts.Services.ILoggerService') | The logger service. |
| deviceConfigService | [Magic.Switch.Board.Core.Contracts.Services.IDeviceConfigService](#T-Magic-Switch-Board-Core-Contracts-Services-IDeviceConfigService 'Magic.Switch.Board.Core.Contracts.Services.IDeviceConfigService') | the device configuration service. |
| enumService | [Magic.Switch.Board.Core.Contracts.Services.IEnumService](#T-Magic-Switch-Board-Core-Contracts-Services-IEnumService 'Magic.Switch.Board.Core.Contracts.Services.IEnumService') | The enumerator service. |

<a name='P-Magic-Switch-Board-UI-Logic-ViewModels-MainViewModel-ApplicationVersion'></a>
### ApplicationVersion `property`

##### Summary

The [ApplicationVersion](#P-Magic-Switch-Board-UI-Logic-ViewModels-MainViewModel-ApplicationVersion 'Magic.Switch.Board.UI.Logic.ViewModels.MainViewModel.ApplicationVersion') property.

<a name='T-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase-NotifyPropertyChangedAttribute'></a>
## NotifyPropertyChangedAttribute `type`

##### Namespace

Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase

##### Summary

The [NotifyPropertyChangedAttribute](#T-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase-NotifyPropertyChangedAttribute 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase.NotifyPropertyChangedAttribute') class.

##### Remarks

A property decorated with this attribute propagates its change to the property defined in the attribute.

<a name='M-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase-NotifyPropertyChangedAttribute-#ctor-System-String-'></a>
### #ctor(propertyName) `constructor`

##### Summary

Initializes a new instance of the [NotifyPropertyChangedAttribute](#T-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase-NotifyPropertyChangedAttribute 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase.NotifyPropertyChangedAttribute') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the property to notify. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |

##### Remarks

Will throw an exception if `propertyName` is `null` or empty.

<a name='P-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase-NotifyPropertyChangedAttribute-PropertyName'></a>
### PropertyName `property`

##### Summary

The [PropertyName](#P-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase-NotifyPropertyChangedAttribute-PropertyName 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase.NotifyPropertyChangedAttribute.PropertyName') property.

<a name='T-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase-NotifyPropertyChangingAttribute'></a>
## NotifyPropertyChangingAttribute `type`

##### Namespace

Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase

##### Summary

The [NotifyPropertyChangingAttribute](#T-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase-NotifyPropertyChangingAttribute 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase.NotifyPropertyChangingAttribute') class.

##### Remarks

A property decorated with this attribute propagates its pending change to the property defined in the attribute.

<a name='M-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase-NotifyPropertyChangingAttribute-#ctor-System-String-'></a>
### #ctor(propertyName) `constructor`

##### Summary

Initializes a new instance of the [NotifyPropertyChangedAttribute](#T-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase-NotifyPropertyChangedAttribute 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase.NotifyPropertyChangedAttribute') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the property to notify. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |

##### Remarks

Will throw an exception if `propertyName` is `null` or empty.

<a name='P-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase-NotifyPropertyChangingAttribute-PropertyName'></a>
### PropertyName `property`

##### Summary

The [PropertyName](#P-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase-NotifyPropertyChangingAttribute-PropertyName 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase.NotifyPropertyChangingAttribute.PropertyName') property.

<a name='T-Magic-Switch-Board-UI-Logic-ViewModels-Device-OutputVM'></a>
## OutputVM `type`

##### Namespace

Magic.Switch.Board.UI.Logic.ViewModels.Device

##### Summary

The [OutputVM](#T-Magic-Switch-Board-UI-Logic-ViewModels-Device-OutputVM 'Magic.Switch.Board.UI.Logic.ViewModels.Device.OutputVM') class is the view model class for the model class [Output](#T-Magic-Switch-Board-Core-Models-Device-Output 'Magic.Switch.Board.Core.Models.Device.Output').

<a name='M-Magic-Switch-Board-UI-Logic-ViewModels-Device-OutputVM-#ctor-Magic-Switch-Board-Core-Models-Device-Output-'></a>
### #ctor(model) `constructor`

##### Summary

Initializes a new instance of the [OutputVM](#T-Magic-Switch-Board-UI-Logic-ViewModels-Device-OutputVM 'Magic.Switch.Board.UI.Logic.ViewModels.Device.OutputVM') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [Magic.Switch.Board.Core.Models.Device.Output](#T-Magic-Switch-Board-Core-Models-Device-Output 'Magic.Switch.Board.Core.Models.Device.Output') | The domain channel model. |

<a name='P-Magic-Switch-Board-UI-Logic-ViewModels-Device-OutputVM-MessageType'></a>
### MessageType `property`

##### Summary

The [MessageType](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-OutputVM-MessageType 'Magic.Switch.Board.UI.Logic.ViewModels.Device.OutputVM.MessageType') property.

<a name='P-Magic-Switch-Board-UI-Logic-ViewModels-Device-OutputVM-MidiChannel'></a>
### MidiChannel `property`

##### Summary

The [MidiChannel](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-OutputVM-MidiChannel 'Magic.Switch.Board.UI.Logic.ViewModels.Device.OutputVM.MidiChannel') property.

<a name='P-Magic-Switch-Board-UI-Logic-ViewModels-Device-OutputVM-Number'></a>
### Number `property`

##### Summary

The [Number](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-OutputVM-Number 'Magic.Switch.Board.UI.Logic.ViewModels.Device.OutputVM.Number') property.

<a name='T-Magic-Switch-Board-UI-Logic-BaseTypes-RelayCommand'></a>
## RelayCommand `type`

##### Namespace

Magic.Switch.Board.UI.Logic.BaseTypes

##### Summary

The [RelayCommand](#T-Magic-Switch-Board-UI-Logic-BaseTypes-RelayCommand 'Magic.Switch.Board.UI.Logic.BaseTypes.RelayCommand') class. Implements the mebmer of the [ICommand](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Windows.Input.ICommand 'System.Windows.Input.ICommand') interface.

##### Remarks

A command whose sole purpose is to relay its functionality to other objects by invoking delegates.
The default return value for the CanExecute method is `true`.
RaiseCanExecuteChanged needs to be called whenever CanExecute is expected to return a different value.

<a name='M-Magic-Switch-Board-UI-Logic-BaseTypes-RelayCommand-#ctor-System-Action-'></a>
### #ctor(execute) `constructor`

##### Summary

Initializes a new instance of the [RelayCommand](#T-Magic-Switch-Board-UI-Logic-BaseTypes-RelayCommand 'Magic.Switch.Board.UI.Logic.BaseTypes.RelayCommand') class that can always execute.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| execute | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | The execution logic. |

<a name='M-Magic-Switch-Board-UI-Logic-BaseTypes-RelayCommand-#ctor-System-Action,System-Func{System-Boolean}-'></a>
### #ctor(execute,canExecute) `constructor`

##### Summary

Initializes a new instance of the [RelayCommand](#T-Magic-Switch-Board-UI-Logic-BaseTypes-RelayCommand 'Magic.Switch.Board.UI.Logic.BaseTypes.RelayCommand') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| execute | [System.Action](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action') | The execution logic. |
| canExecute | [System.Func{System.Boolean}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Func 'System.Func{System.Boolean}') | The execution status logic. |

<a name='M-Magic-Switch-Board-UI-Logic-BaseTypes-RelayCommand-CanExecute-System-Object-'></a>
### CanExecute(parameter) `method`

##### Summary

Determines whether this RelayCommand can execute in its current state.

##### Returns

true if this command can be executed; otherwise, false.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parameter | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Data used by the command. If the command does not require data to be passed,
this object can be set to null. |

<a name='M-Magic-Switch-Board-UI-Logic-BaseTypes-RelayCommand-Execute-System-Object-'></a>
### Execute(parameter) `method`

##### Summary

Executes the RelayCommand on the current command target.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parameter | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | Data used by the command. If the command does not require data to be passed,
this object can be set to null. |

<a name='M-Magic-Switch-Board-UI-Logic-BaseTypes-RelayCommand-RaiseCanExecuteChanged'></a>
### RaiseCanExecuteChanged() `method`

##### Summary

Method used to raise the CanExecuteChanged event
to indicate that the return value of the CanExecute
method has changed.

##### Parameters

This method has no parameters.

<a name='T-Magic-Switch-Board-UI-Logic-Properties-Resources'></a>
## Resources `type`

##### Namespace

Magic.Switch.Board.UI.Logic.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-Magic-Switch-Board-UI-Logic-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-Magic-Switch-Board-UI-Logic-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='P-Magic-Switch-Board-UI-Logic-Properties-Resources-ViewModel_Display_Name_Application_Version'></a>
### ViewModel_Display_Name_Application_Version `property`

##### Summary

Looks up a localized string similar to Application version.

<a name='P-Magic-Switch-Board-UI-Logic-Properties-Resources-ViewModel_Display_Name_Channels'></a>
### ViewModel_Display_Name_Channels `property`

##### Summary

Looks up a localized string similar to Channels.

<a name='P-Magic-Switch-Board-UI-Logic-Properties-Resources-ViewModel_Display_Name_Configuration_Version'></a>
### ViewModel_Display_Name_Configuration_Version `property`

##### Summary

Looks up a localized string similar to Configuration version.

<a name='P-Magic-Switch-Board-UI-Logic-Properties-Resources-ViewModel_Display_Name_Created'></a>
### ViewModel_Display_Name_Created `property`

##### Summary

Looks up a localized string similar to Created.

<a name='P-Magic-Switch-Board-UI-Logic-Properties-Resources-ViewModel_Display_Name_Description'></a>
### ViewModel_Display_Name_Description `property`

##### Summary

Looks up a localized string similar to Description.

<a name='P-Magic-Switch-Board-UI-Logic-Properties-Resources-ViewModel_Display_Name_Id'></a>
### ViewModel_Display_Name_Id `property`

##### Summary

Looks up a localized string similar to Identifier.

<a name='P-Magic-Switch-Board-UI-Logic-Properties-Resources-ViewModel_Display_Name_Input'></a>
### ViewModel_Display_Name_Input `property`

##### Summary

Looks up a localized string similar to Input.

<a name='P-Magic-Switch-Board-UI-Logic-Properties-Resources-ViewModel_Display_Name_Loops'></a>
### ViewModel_Display_Name_Loops `property`

##### Summary

Looks up a localized string similar to Loops.

<a name='P-Magic-Switch-Board-UI-Logic-Properties-Resources-ViewModel_Display_Name_MessageType'></a>
### ViewModel_Display_Name_MessageType `property`

##### Summary

Looks up a localized string similar to Message type.

<a name='P-Magic-Switch-Board-UI-Logic-Properties-Resources-ViewModel_Display_Name_MidiChannel'></a>
### ViewModel_Display_Name_MidiChannel `property`

##### Summary

Looks up a localized string similar to Midi channel.

<a name='P-Magic-Switch-Board-UI-Logic-Properties-Resources-ViewModel_Display_Name_Name'></a>
### ViewModel_Display_Name_Name `property`

##### Summary

Looks up a localized string similar to Name.

<a name='P-Magic-Switch-Board-UI-Logic-Properties-Resources-ViewModel_Display_Name_Number'></a>
### ViewModel_Display_Name_Number `property`

##### Summary

Looks up a localized string similar to Number.

<a name='P-Magic-Switch-Board-UI-Logic-Properties-Resources-ViewModel_Display_Name_Output'></a>
### ViewModel_Display_Name_Output `property`

##### Summary

Looks up a localized string similar to Output.

<a name='P-Magic-Switch-Board-UI-Logic-Properties-Resources-ViewModel_Display_Name_Switches'></a>
### ViewModel_Display_Name_Switches `property`

##### Summary

Looks up a localized string similar to Switches.

<a name='P-Magic-Switch-Board-UI-Logic-Properties-Resources-ViewModel_Display_Name_Updated'></a>
### ViewModel_Display_Name_Updated `property`

##### Summary

Looks up a localized string similar to Updated.

<a name='T-Magic-Switch-Board-UI-Logic-ViewModels-Device-SwitchesVM'></a>
## SwitchesVM `type`

##### Namespace

Magic.Switch.Board.UI.Logic.ViewModels.Device

##### Summary

The [SwitchesVM](#T-Magic-Switch-Board-UI-Logic-ViewModels-Device-SwitchesVM 'Magic.Switch.Board.UI.Logic.ViewModels.Device.SwitchesVM') class is the view model class for the model class [Loops](#T-Magic-Switch-Board-Core-Models-Device-Loops 'Magic.Switch.Board.Core.Models.Device.Loops').

<a name='M-Magic-Switch-Board-UI-Logic-ViewModels-Device-SwitchesVM-#ctor-Magic-Switch-Board-Core-Models-Device-Switches-'></a>
### #ctor(model) `constructor`

##### Summary

Initializes a new instance of the [LoopsVM](#T-Magic-Switch-Board-UI-Logic-ViewModels-Device-LoopsVM 'Magic.Switch.Board.UI.Logic.ViewModels.Device.LoopsVM') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [Magic.Switch.Board.Core.Models.Device.Switches](#T-Magic-Switch-Board-Core-Models-Device-Switches 'Magic.Switch.Board.Core.Models.Device.Switches') | The domain channel model. |

<a name='P-Magic-Switch-Board-UI-Logic-ViewModels-Device-SwitchesVM-Channels'></a>
### Channels `property`

##### Summary

The [Channels](#P-Magic-Switch-Board-UI-Logic-ViewModels-Device-SwitchesVM-Channels 'Magic.Switch.Board.UI.Logic.ViewModels.Device.SwitchesVM.Channels') property.

<a name='T-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase'></a>
## ViewModelBase `type`

##### Namespace

Magic.Switch.Board.UI.Logic.BaseTypes

##### Summary

The `abstract`[ViewModelBase](#T-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase') base class.

##### Remarks

The [ViewModelBase](#T-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase') class implements the following interfaces:

The class also provides attributes for decorating properties, in turn informing other
properties of their value changes. See [NotifyPropertyChangedAttribute](#T-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase-NotifyPropertyChangedAttribute 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase.NotifyPropertyChangedAttribute').

<a name='M-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase-NotifyAttributeChangedProperty-System-String-'></a>
### NotifyAttributeChangedProperty(propertyName) `method`

##### Summary

The [NotifyAttributeChangedProperty](#M-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase-NotifyAttributeChangedProperty-System-String- 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase.NotifyAttributeChangedProperty(System.String)') method will notify all properties
which have been defined by the [NotifyPropertyChangedAttribute](#T-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase-NotifyPropertyChangedAttribute 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase.NotifyPropertyChangedAttribute') as to be informed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The property name. |

<a name='M-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase-NotifyAttributeChangingProperty-System-String-'></a>
### NotifyAttributeChangingProperty(propertyName) `method`

##### Summary

The [NotifyAttributeChangingProperty](#M-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase-NotifyAttributeChangingProperty-System-String- 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase.NotifyAttributeChangingProperty(System.String)') method will notify all properties
which have been defined by the [NotifyPropertyChangedAttribute](#T-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase-NotifyPropertyChangedAttribute 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase.NotifyPropertyChangedAttribute') as to be informed.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The property name. |

<a name='M-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase-RaisePropertyChanged-System-String-'></a>
### RaisePropertyChanged(propertyName) `method`

##### Summary

The [RaisePropertyChanged](#M-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase-RaisePropertyChanged-System-String- 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase.RaisePropertyChanged(System.String)') method to raise the changed event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the property, can be `null`. |

##### Remarks

The calling member's name will be used as the parameter.

<a name='M-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase-RaisePropertyChanging-System-String-'></a>
### RaisePropertyChanging(propertyName) `method`

##### Summary

The [RaisePropertyChanging](#M-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase-RaisePropertyChanging-System-String- 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase.RaisePropertyChanging(System.String)') method to raise the changing event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the property, can be `null`. |

##### Remarks

The calling member's name will be used as the parameter.

<a name='M-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase-SetPropertyNoNotify``1-``0@,``0,System-String-'></a>
### SetPropertyNoNotify\`\`1(field,newValue,propertyName) `method`

##### Summary

Sets a new value for a property and does not notify about the change.

##### Returns

`true` or `false` if the property has been set.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| field | [\`\`0@](#T-``0@ '``0@') | The referenced field. |
| newValue | [\`\`0](#T-``0 '``0') | The new value for the property. |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The property name. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | If `propertyName` is null. |

<a name='M-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase-SetProperty``1-``0@,``0,System-String-'></a>
### SetProperty\`\`1(field,newValue,propertyName) `method`

##### Summary

Sets a new value for a property and notifies about the change.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| field | [\`\`0@](#T-``0@ '``0@') | The referenced field. |
| newValue | [\`\`0](#T-``0 '``0') | The new value for the property. |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The property name. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | If `propertyName` is null. |

<a name='T-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase`1'></a>
## ViewModelBase\`1 `type`

##### Namespace

Magic.Switch.Board.UI.Logic.BaseTypes

##### Summary

The `abstract`[ViewModelBase\`1](#T-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase`1 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase`1') class.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TModel | The domain model class. |

##### Remarks

The [ViewModelBase\`1](#T-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase`1 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase`1') class implements the following interfaces:

It inherits the fields and methods from the [ViewModelBase](#T-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase') class.

<a name='M-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase`1-#ctor-`0-'></a>
### #ctor(model) `constructor`

##### Summary

Initializes a new instance of the [ViewModelBase\`1](#T-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase`1 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase`1') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [\`0](#T-`0 '`0') | The domain model class. |

<a name='F-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase`1-_propertyErrors'></a>
### _propertyErrors `constants`

##### Summary

The dictonary contains the errors for each property.

<a name='P-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase`1-HasErrors'></a>
### HasErrors `property`

##### Summary

*Inherit from parent.*

<a name='P-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase`1-Model'></a>
### Model `property`

##### Summary

The [Model](#P-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase`1-Model 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase`1.Model') property.

##### Remarks

Immutable types are those whose data members can not be changed after the instance is created.
At the first choice of design, for now the property is mutable.

<a name='M-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase`1-AddError-System-String,System-String-'></a>
### AddError(propertyName,errorMessage) `method`

##### Summary

The [AddError](#M-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase`1-AddError-System-String,System-String- 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase`1.AddError(System.String,System.String)') method will add an error message for the property.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The property name. |
| errorMessage | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The error message. |

<a name='M-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase`1-ClearErrors-System-String-'></a>
### ClearErrors(propertyName) `method`

##### Summary

The [ClearErrors](#M-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase`1-ClearErrors-System-String- 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase`1.ClearErrors(System.String)') method will clear all errors for the property.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The property name. |

<a name='M-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase`1-GetErrors-System-String-'></a>
### GetErrors() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase`1-OnPropertyChangedPropagate-System-Object,System-ComponentModel-PropertyChangedEventArgs-'></a>
### OnPropertyChangedPropagate(sender,e) `method`

##### Summary

The [OnPropertyChangedPropagate](#M-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase`1-OnPropertyChangedPropagate-System-Object,System-ComponentModel-PropertyChangedEventArgs- 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase`1.OnPropertyChangedPropagate(System.Object,System.ComponentModel.PropertyChangedEventArgs)') method
propagates the changes in the view model through to the domain model.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The sender will/should be [ViewModelBase\`1](#T-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase`1 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase`1'). |
| e | [System.ComponentModel.PropertyChangedEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.PropertyChangedEventArgs 'System.ComponentModel.PropertyChangedEventArgs') |  |

##### Remarks

The method can only / should be called from the derived class.

<a name='M-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase`1-RaiseErrorsChanged-System-String-'></a>
### RaiseErrorsChanged(propertyName) `method`

##### Summary

The [RaiseErrorsChanged](#M-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase`1-RaiseErrorsChanged-System-String- 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase`1.RaiseErrorsChanged(System.String)') method to raise the erros changed event.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The property name. |

##### Remarks

The calling member's name will be used as the parameter.

<a name='M-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase`1-SetPropertyAndValidate``1-``0@,``0,System-String-'></a>
### SetPropertyAndValidate\`\`1(field,newValue,propertyName) `method`

##### Summary

Sets a new value for a property, notifies about the change and tries to
validate the property against the domain model class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| field | [\`\`0@](#T-``0@ '``0@') | The referenced field. |
| newValue | [\`\`0](#T-``0 '``0') | The new value for the property. |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The property name. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | If `propertyName` is null. |

<a name='M-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase`1-SetPropertyNoNotifyAndValidate``1-``0@,``0,System-String-'></a>
### SetPropertyNoNotifyAndValidate\`\`1(field,newValue,propertyName) `method`

##### Summary

Sets a new value for a property, does not notify about the changeand tries to
validate the property against the domain model class.

##### Returns

`true` or `false` if the property has been set.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| field | [\`\`0@](#T-``0@ '``0@') | The referenced field. |
| newValue | [\`\`0](#T-``0 '``0') | The new value for the property. |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The property name. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | If `propertyName` is null. |

<a name='M-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase`1-Validate``1-``0,System-String-'></a>
### Validate\`\`1(value,propertyName) `method`

##### Summary

The [Validate\`\`1](#M-Magic-Switch-Board-UI-Logic-BaseTypes-ViewModelBase`1-Validate``1-``0,System-String- 'Magic.Switch.Board.UI.Logic.BaseTypes.ViewModelBase`1.Validate``1(``0,System.String)') method will try to validate the property value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [\`\`0](#T-``0 '``0') | The value of the property. |
| propertyName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The property name. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |
