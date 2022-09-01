<a name='assembly'></a>
# Magic.Switch.Board.Core

## Contents

- [AuditBase](#T-Magic-Switch-Board-Core-Models-Device-Base-AuditBase 'Magic.Switch.Board.Core.Models.Device.Base.AuditBase')
  - [#ctor()](#M-Magic-Switch-Board-Core-Models-Device-Base-AuditBase-#ctor 'Magic.Switch.Board.Core.Models.Device.Base.AuditBase.#ctor')
  - [#ctor(name)](#M-Magic-Switch-Board-Core-Models-Device-Base-AuditBase-#ctor-System-String- 'Magic.Switch.Board.Core.Models.Device.Base.AuditBase.#ctor(System.String)')
  - [Created](#P-Magic-Switch-Board-Core-Models-Device-Base-AuditBase-Created 'Magic.Switch.Board.Core.Models.Device.Base.AuditBase.Created')
  - [Description](#P-Magic-Switch-Board-Core-Models-Device-Base-AuditBase-Description 'Magic.Switch.Board.Core.Models.Device.Base.AuditBase.Description')
  - [Id](#P-Magic-Switch-Board-Core-Models-Device-Base-AuditBase-Id 'Magic.Switch.Board.Core.Models.Device.Base.AuditBase.Id')
  - [Name](#P-Magic-Switch-Board-Core-Models-Device-Base-AuditBase-Name 'Magic.Switch.Board.Core.Models.Device.Base.AuditBase.Name')
  - [Updated](#P-Magic-Switch-Board-Core-Models-Device-Base-AuditBase-Updated 'Magic.Switch.Board.Core.Models.Device.Base.AuditBase.Updated')
- [Channel](#T-Magic-Switch-Board-Core-Models-Device-Channel 'Magic.Switch.Board.Core.Models.Device.Channel')
  - [#ctor()](#M-Magic-Switch-Board-Core-Models-Device-Channel-#ctor 'Magic.Switch.Board.Core.Models.Device.Channel.#ctor')
  - [#ctor(name,input,output,switches,loops)](#M-Magic-Switch-Board-Core-Models-Device-Channel-#ctor-System-String,Magic-Switch-Board-Core-Models-Device-Input,Magic-Switch-Board-Core-Models-Device-Output,Magic-Switch-Board-Core-Models-Device-Switches,Magic-Switch-Board-Core-Models-Device-Loops- 'Magic.Switch.Board.Core.Models.Device.Channel.#ctor(System.String,Magic.Switch.Board.Core.Models.Device.Input,Magic.Switch.Board.Core.Models.Device.Output,Magic.Switch.Board.Core.Models.Device.Switches,Magic.Switch.Board.Core.Models.Device.Loops)')
  - [Input](#P-Magic-Switch-Board-Core-Models-Device-Channel-Input 'Magic.Switch.Board.Core.Models.Device.Channel.Input')
  - [Loops](#P-Magic-Switch-Board-Core-Models-Device-Channel-Loops 'Magic.Switch.Board.Core.Models.Device.Channel.Loops')
  - [Output](#P-Magic-Switch-Board-Core-Models-Device-Channel-Output 'Magic.Switch.Board.Core.Models.Device.Channel.Output')
  - [Switches](#P-Magic-Switch-Board-Core-Models-Device-Channel-Switches 'Magic.Switch.Board.Core.Models.Device.Channel.Switches')
- [Configuration](#T-Magic-Switch-Board-Core-Models-Device-Configuration 'Magic.Switch.Board.Core.Models.Device.Configuration')
  - [#ctor()](#M-Magic-Switch-Board-Core-Models-Device-Configuration-#ctor 'Magic.Switch.Board.Core.Models.Device.Configuration.#ctor')
  - [#ctor(name,applicationVersion)](#M-Magic-Switch-Board-Core-Models-Device-Configuration-#ctor-System-String,System-String- 'Magic.Switch.Board.Core.Models.Device.Configuration.#ctor(System.String,System.String)')
  - [#ctor(name,applicationVersion,channels)](#M-Magic-Switch-Board-Core-Models-Device-Configuration-#ctor-System-String,System-String,System-Collections-Generic-List{Magic-Switch-Board-Core-Models-Device-Channel}- 'Magic.Switch.Board.Core.Models.Device.Configuration.#ctor(System.String,System.String,System.Collections.Generic.List{Magic.Switch.Board.Core.Models.Device.Channel})')
  - [ApplicationVersion](#P-Magic-Switch-Board-Core-Models-Device-Configuration-ApplicationVersion 'Magic.Switch.Board.Core.Models.Device.Configuration.ApplicationVersion')
  - [Channels](#P-Magic-Switch-Board-Core-Models-Device-Configuration-Channels 'Magic.Switch.Board.Core.Models.Device.Configuration.Channels')
  - [ConfigurationVersion](#P-Magic-Switch-Board-Core-Models-Device-Configuration-ConfigurationVersion 'Magic.Switch.Board.Core.Models.Device.Configuration.ConfigurationVersion')
- [ConsoleLoggerService](#T-Magic-Switch-Board-Core-Services-ConsoleLoggerService 'Magic.Switch.Board.Core.Services.ConsoleLoggerService')
  - [Critical()](#M-Magic-Switch-Board-Core-Services-ConsoleLoggerService-Critical-System-String,System-String- 'Magic.Switch.Board.Core.Services.ConsoleLoggerService.Critical(System.String,System.String)')
  - [Debug()](#M-Magic-Switch-Board-Core-Services-ConsoleLoggerService-Debug-System-String,System-String- 'Magic.Switch.Board.Core.Services.ConsoleLoggerService.Debug(System.String,System.String)')
  - [Error()](#M-Magic-Switch-Board-Core-Services-ConsoleLoggerService-Error-System-String,System-String- 'Magic.Switch.Board.Core.Services.ConsoleLoggerService.Error(System.String,System.String)')
  - [Information()](#M-Magic-Switch-Board-Core-Services-ConsoleLoggerService-Information-System-String,System-String- 'Magic.Switch.Board.Core.Services.ConsoleLoggerService.Information(System.String,System.String)')
  - [LogToConsole(type,caller,message)](#M-Magic-Switch-Board-Core-Services-ConsoleLoggerService-LogToConsole-System-String,System-String,System-String- 'Magic.Switch.Board.Core.Services.ConsoleLoggerService.LogToConsole(System.String,System.String,System.String)')
  - [Trace()](#M-Magic-Switch-Board-Core-Services-ConsoleLoggerService-Trace-System-String,System-String- 'Magic.Switch.Board.Core.Services.ConsoleLoggerService.Trace(System.String,System.String)')
  - [Warning()](#M-Magic-Switch-Board-Core-Services-ConsoleLoggerService-Warning-System-String,System-String- 'Magic.Switch.Board.Core.Services.ConsoleLoggerService.Warning(System.String,System.String)')
- [DeviceConfigService](#T-Magic-Switch-Board-Core-Services-DeviceConfigService 'Magic.Switch.Board.Core.Services.DeviceConfigService')
  - [#ctor(logger,fileService)](#M-Magic-Switch-Board-Core-Services-DeviceConfigService-#ctor-Magic-Switch-Board-Core-Contracts-Services-ILoggerService,Magic-Switch-Board-Core-Contracts-Services-IFileService- 'Magic.Switch.Board.Core.Services.DeviceConfigService.#ctor(Magic.Switch.Board.Core.Contracts.Services.ILoggerService,Magic.Switch.Board.Core.Contracts.Services.IFileService)')
  - [Create()](#M-Magic-Switch-Board-Core-Services-DeviceConfigService-Create-System-String,System-String- 'Magic.Switch.Board.Core.Services.DeviceConfigService.Create(System.String,System.String)')
  - [Read()](#M-Magic-Switch-Board-Core-Services-DeviceConfigService-Read-System-String,System-String- 'Magic.Switch.Board.Core.Services.DeviceConfigService.Read(System.String,System.String)')
  - [Write()](#M-Magic-Switch-Board-Core-Services-DeviceConfigService-Write-System-String,System-String,Magic-Switch-Board-Core-Models-Device-Configuration,System-Text-Encoding- 'Magic.Switch.Board.Core.Services.DeviceConfigService.Write(System.String,System.String,Magic.Switch.Board.Core.Models.Device.Configuration,System.Text.Encoding)')
  - [Write()](#M-Magic-Switch-Board-Core-Services-DeviceConfigService-Write-System-String,System-String,Magic-Switch-Board-Core-Models-Device-Configuration- 'Magic.Switch.Board.Core.Services.DeviceConfigService.Write(System.String,System.String,Magic.Switch.Board.Core.Models.Device.Configuration)')
- [EnumModel\`1](#T-Magic-Switch-Board-Core-Models-EnumModel`1 'Magic.Switch.Board.Core.Models.EnumModel`1')
  - [#ctor(enum,name,shortName,description)](#M-Magic-Switch-Board-Core-Models-EnumModel`1-#ctor-`0,System-String,System-String,System-String- 'Magic.Switch.Board.Core.Models.EnumModel`1.#ctor(`0,System.String,System.String,System.String)')
  - [Description](#P-Magic-Switch-Board-Core-Models-EnumModel`1-Description 'Magic.Switch.Board.Core.Models.EnumModel`1.Description')
  - [Enum](#P-Magic-Switch-Board-Core-Models-EnumModel`1-Enum 'Magic.Switch.Board.Core.Models.EnumModel`1.Enum')
  - [Name](#P-Magic-Switch-Board-Core-Models-EnumModel`1-Name 'Magic.Switch.Board.Core.Models.EnumModel`1.Name')
  - [ShortName](#P-Magic-Switch-Board-Core-Models-EnumModel`1-ShortName 'Magic.Switch.Board.Core.Models.EnumModel`1.ShortName')
- [EnumService](#T-Magic-Switch-Board-Core-Services-EnumService 'Magic.Switch.Board.Core.Services.EnumService')
  - [#ctor(logger)](#M-Magic-Switch-Board-Core-Services-EnumService-#ctor-Magic-Switch-Board-Core-Contracts-Services-ILoggerService- 'Magic.Switch.Board.Core.Services.EnumService.#ctor(Magic.Switch.Board.Core.Contracts.Services.ILoggerService)')
  - [GetLogLevels()](#M-Magic-Switch-Board-Core-Services-EnumService-GetLogLevels 'Magic.Switch.Board.Core.Services.EnumService.GetLogLevels')
  - [GetLoopChannels()](#M-Magic-Switch-Board-Core-Services-EnumService-GetLoopChannels 'Magic.Switch.Board.Core.Services.EnumService.GetLoopChannels')
  - [GetMidiChannels()](#M-Magic-Switch-Board-Core-Services-EnumService-GetMidiChannels 'Magic.Switch.Board.Core.Services.EnumService.GetMidiChannels')
  - [GetMidiMessageTypes()](#M-Magic-Switch-Board-Core-Services-EnumService-GetMidiMessageTypes 'Magic.Switch.Board.Core.Services.EnumService.GetMidiMessageTypes')
  - [GetSwitchChannels()](#M-Magic-Switch-Board-Core-Services-EnumService-GetSwitchChannels 'Magic.Switch.Board.Core.Services.EnumService.GetSwitchChannels')
- [Enums](#T-Magic-Switch-Board-Core-Enums 'Magic.Switch.Board.Core.Enums')
  - [FlagsToList\`\`1(enumFlags)](#M-Magic-Switch-Board-Core-Enums-FlagsToList``1-``0- 'Magic.Switch.Board.Core.Enums.FlagsToList``1(``0)')
  - [GetDisplayAttribute\`\`1(enumValue)](#M-Magic-Switch-Board-Core-Enums-GetDisplayAttribute``1-``0- 'Magic.Switch.Board.Core.Enums.GetDisplayAttribute``1(``0)')
  - [GetEnumDescription\`\`1(enumValue)](#M-Magic-Switch-Board-Core-Enums-GetEnumDescription``1-``0- 'Magic.Switch.Board.Core.Enums.GetEnumDescription``1(``0)')
  - [GetEnumModelList\`\`1(enumValue)](#M-Magic-Switch-Board-Core-Enums-GetEnumModelList``1-``0- 'Magic.Switch.Board.Core.Enums.GetEnumModelList``1(``0)')
  - [GetEnumName\`\`1(enumValue)](#M-Magic-Switch-Board-Core-Enums-GetEnumName``1-``0- 'Magic.Switch.Board.Core.Enums.GetEnumName``1(``0)')
  - [GetEnumShortName\`\`1(enumValue)](#M-Magic-Switch-Board-Core-Enums-GetEnumShortName``1-``0- 'Magic.Switch.Board.Core.Enums.GetEnumShortName``1(``0)')
  - [GetEnumsWithDescription\`\`1(enumValue)](#M-Magic-Switch-Board-Core-Enums-GetEnumsWithDescription``1-``0- 'Magic.Switch.Board.Core.Enums.GetEnumsWithDescription``1(``0)')
  - [GetListFromEnum\`\`1()](#M-Magic-Switch-Board-Core-Enums-GetListFromEnum``1-``0- 'Magic.Switch.Board.Core.Enums.GetListFromEnum``1(``0)')
- [FileLoggerService](#T-Magic-Switch-Board-Core-Services-FileLoggerService 'Magic.Switch.Board.Core.Services.FileLoggerService')
  - [Critical()](#M-Magic-Switch-Board-Core-Services-FileLoggerService-Critical-System-String,System-String- 'Magic.Switch.Board.Core.Services.FileLoggerService.Critical(System.String,System.String)')
  - [Debug()](#M-Magic-Switch-Board-Core-Services-FileLoggerService-Debug-System-String,System-String- 'Magic.Switch.Board.Core.Services.FileLoggerService.Debug(System.String,System.String)')
  - [Error()](#M-Magic-Switch-Board-Core-Services-FileLoggerService-Error-System-String,System-String- 'Magic.Switch.Board.Core.Services.FileLoggerService.Error(System.String,System.String)')
  - [Information()](#M-Magic-Switch-Board-Core-Services-FileLoggerService-Information-System-String,System-String- 'Magic.Switch.Board.Core.Services.FileLoggerService.Information(System.String,System.String)')
  - [LogToFile(type,caller,message)](#M-Magic-Switch-Board-Core-Services-FileLoggerService-LogToFile-System-String,System-String,System-String- 'Magic.Switch.Board.Core.Services.FileLoggerService.LogToFile(System.String,System.String,System.String)')
  - [Trace()](#M-Magic-Switch-Board-Core-Services-FileLoggerService-Trace-System-String,System-String- 'Magic.Switch.Board.Core.Services.FileLoggerService.Trace(System.String,System.String)')
  - [Warning()](#M-Magic-Switch-Board-Core-Services-FileLoggerService-Warning-System-String,System-String- 'Magic.Switch.Board.Core.Services.FileLoggerService.Warning(System.String,System.String)')
- [FileService](#T-Magic-Switch-Board-Core-Services-FileService 'Magic.Switch.Board.Core.Services.FileService')
  - [#ctor(logger)](#M-Magic-Switch-Board-Core-Services-FileService-#ctor-Magic-Switch-Board-Core-Contracts-Services-ILoggerService- 'Magic.Switch.Board.Core.Services.FileService.#ctor(Magic.Switch.Board.Core.Contracts.Services.ILoggerService)')
  - [Delete()](#M-Magic-Switch-Board-Core-Services-FileService-Delete-System-String,System-String- 'Magic.Switch.Board.Core.Services.FileService.Delete(System.String,System.String)')
  - [DirectoryExists(folderPath)](#M-Magic-Switch-Board-Core-Services-FileService-DirectoryExists-System-String- 'Magic.Switch.Board.Core.Services.FileService.DirectoryExists(System.String)')
  - [FileExists(fullFilePath)](#M-Magic-Switch-Board-Core-Services-FileService-FileExists-System-String- 'Magic.Switch.Board.Core.Services.FileService.FileExists(System.String)')
  - [Read()](#M-Magic-Switch-Board-Core-Services-FileService-Read-System-String,System-String- 'Magic.Switch.Board.Core.Services.FileService.Read(System.String,System.String)')
  - [Save()](#M-Magic-Switch-Board-Core-Services-FileService-Save-System-String,System-String,System-String- 'Magic.Switch.Board.Core.Services.FileService.Save(System.String,System.String,System.String)')
- [IDeviceConfigService](#T-Magic-Switch-Board-Core-Contracts-Services-IDeviceConfigService 'Magic.Switch.Board.Core.Contracts.Services.IDeviceConfigService')
  - [Create(applicationVersion,name)](#M-Magic-Switch-Board-Core-Contracts-Services-IDeviceConfigService-Create-System-String,System-String- 'Magic.Switch.Board.Core.Contracts.Services.IDeviceConfigService.Create(System.String,System.String)')
  - [Read(folderPath,fileName)](#M-Magic-Switch-Board-Core-Contracts-Services-IDeviceConfigService-Read-System-String,System-String- 'Magic.Switch.Board.Core.Contracts.Services.IDeviceConfigService.Read(System.String,System.String)')
  - [Write(folderPath,fileName,configuration)](#M-Magic-Switch-Board-Core-Contracts-Services-IDeviceConfigService-Write-System-String,System-String,Magic-Switch-Board-Core-Models-Device-Configuration- 'Magic.Switch.Board.Core.Contracts.Services.IDeviceConfigService.Write(System.String,System.String,Magic.Switch.Board.Core.Models.Device.Configuration)')
  - [Write(folderPath,fileName,configuration,encoding)](#M-Magic-Switch-Board-Core-Contracts-Services-IDeviceConfigService-Write-System-String,System-String,Magic-Switch-Board-Core-Models-Device-Configuration,System-Text-Encoding- 'Magic.Switch.Board.Core.Contracts.Services.IDeviceConfigService.Write(System.String,System.String,Magic.Switch.Board.Core.Models.Device.Configuration,System.Text.Encoding)')
- [IEnumService](#T-Magic-Switch-Board-Core-Contracts-Services-IEnumService 'Magic.Switch.Board.Core.Contracts.Services.IEnumService')
  - [GetLogLevels()](#M-Magic-Switch-Board-Core-Contracts-Services-IEnumService-GetLogLevels 'Magic.Switch.Board.Core.Contracts.Services.IEnumService.GetLogLevels')
  - [GetLoopChannels()](#M-Magic-Switch-Board-Core-Contracts-Services-IEnumService-GetLoopChannels 'Magic.Switch.Board.Core.Contracts.Services.IEnumService.GetLoopChannels')
  - [GetMidiChannels()](#M-Magic-Switch-Board-Core-Contracts-Services-IEnumService-GetMidiChannels 'Magic.Switch.Board.Core.Contracts.Services.IEnumService.GetMidiChannels')
  - [GetMidiMessageTypes()](#M-Magic-Switch-Board-Core-Contracts-Services-IEnumService-GetMidiMessageTypes 'Magic.Switch.Board.Core.Contracts.Services.IEnumService.GetMidiMessageTypes')
  - [GetSwitchChannels()](#M-Magic-Switch-Board-Core-Contracts-Services-IEnumService-GetSwitchChannels 'Magic.Switch.Board.Core.Contracts.Services.IEnumService.GetSwitchChannels')
- [IFileService](#T-Magic-Switch-Board-Core-Contracts-Services-IFileService 'Magic.Switch.Board.Core.Contracts.Services.IFileService')
  - [Delete(folderPath,fileName)](#M-Magic-Switch-Board-Core-Contracts-Services-IFileService-Delete-System-String,System-String- 'Magic.Switch.Board.Core.Contracts.Services.IFileService.Delete(System.String,System.String)')
  - [Read(folderPath,fileName)](#M-Magic-Switch-Board-Core-Contracts-Services-IFileService-Read-System-String,System-String- 'Magic.Switch.Board.Core.Contracts.Services.IFileService.Read(System.String,System.String)')
  - [Save(folderPath,fileName,fileContent)](#M-Magic-Switch-Board-Core-Contracts-Services-IFileService-Save-System-String,System-String,System-String- 'Magic.Switch.Board.Core.Contracts.Services.IFileService.Save(System.String,System.String,System.String)')
- [ILoggerService](#T-Magic-Switch-Board-Core-Contracts-Services-ILoggerService 'Magic.Switch.Board.Core.Contracts.Services.ILoggerService')
  - [Critical(message,callerName)](#M-Magic-Switch-Board-Core-Contracts-Services-ILoggerService-Critical-System-String,System-String- 'Magic.Switch.Board.Core.Contracts.Services.ILoggerService.Critical(System.String,System.String)')
  - [Debug(message,callerName)](#M-Magic-Switch-Board-Core-Contracts-Services-ILoggerService-Debug-System-String,System-String- 'Magic.Switch.Board.Core.Contracts.Services.ILoggerService.Debug(System.String,System.String)')
  - [Error(message,callerName)](#M-Magic-Switch-Board-Core-Contracts-Services-ILoggerService-Error-System-String,System-String- 'Magic.Switch.Board.Core.Contracts.Services.ILoggerService.Error(System.String,System.String)')
  - [Information(message,callerName)](#M-Magic-Switch-Board-Core-Contracts-Services-ILoggerService-Information-System-String,System-String- 'Magic.Switch.Board.Core.Contracts.Services.ILoggerService.Information(System.String,System.String)')
  - [Trace(message,callerName)](#M-Magic-Switch-Board-Core-Contracts-Services-ILoggerService-Trace-System-String,System-String- 'Magic.Switch.Board.Core.Contracts.Services.ILoggerService.Trace(System.String,System.String)')
  - [Warning(message,callerName)](#M-Magic-Switch-Board-Core-Contracts-Services-ILoggerService-Warning-System-String,System-String- 'Magic.Switch.Board.Core.Contracts.Services.ILoggerService.Warning(System.String,System.String)')
- [Input](#T-Magic-Switch-Board-Core-Models-Device-Input 'Magic.Switch.Board.Core.Models.Device.Input')
  - [#ctor()](#M-Magic-Switch-Board-Core-Models-Device-Input-#ctor 'Magic.Switch.Board.Core.Models.Device.Input.#ctor')
  - [#ctor(midiChannel,messageType,number)](#M-Magic-Switch-Board-Core-Models-Device-Input-#ctor-Magic-Switch-Board-Core-Enums-MidiChannel,Magic-Switch-Board-Core-Enums-MidiMessageType,System-Int32- 'Magic.Switch.Board.Core.Models.Device.Input.#ctor(Magic.Switch.Board.Core.Enums.MidiChannel,Magic.Switch.Board.Core.Enums.MidiMessageType,System.Int32)')
- [InputOutputBase](#T-Magic-Switch-Board-Core-Models-Device-Base-InputOutputBase 'Magic.Switch.Board.Core.Models.Device.Base.InputOutputBase')
  - [#ctor()](#M-Magic-Switch-Board-Core-Models-Device-Base-InputOutputBase-#ctor 'Magic.Switch.Board.Core.Models.Device.Base.InputOutputBase.#ctor')
  - [#ctor(midiChannel,messageType,number)](#M-Magic-Switch-Board-Core-Models-Device-Base-InputOutputBase-#ctor-Magic-Switch-Board-Core-Enums-MidiChannel,Magic-Switch-Board-Core-Enums-MidiMessageType,System-Int32- 'Magic.Switch.Board.Core.Models.Device.Base.InputOutputBase.#ctor(Magic.Switch.Board.Core.Enums.MidiChannel,Magic.Switch.Board.Core.Enums.MidiMessageType,System.Int32)')
  - [MessageType](#P-Magic-Switch-Board-Core-Models-Device-Base-InputOutputBase-MessageType 'Magic.Switch.Board.Core.Models.Device.Base.InputOutputBase.MessageType')
  - [MidiChannel](#P-Magic-Switch-Board-Core-Models-Device-Base-InputOutputBase-MidiChannel 'Magic.Switch.Board.Core.Models.Device.Base.InputOutputBase.MidiChannel')
  - [Number](#P-Magic-Switch-Board-Core-Models-Device-Base-InputOutputBase-Number 'Magic.Switch.Board.Core.Models.Device.Base.InputOutputBase.Number')
- [Loops](#T-Magic-Switch-Board-Core-Models-Device-Loops 'Magic.Switch.Board.Core.Models.Device.Loops')
  - [#ctor()](#M-Magic-Switch-Board-Core-Models-Device-Loops-#ctor 'Magic.Switch.Board.Core.Models.Device.Loops.#ctor')
  - [#ctor(channels)](#M-Magic-Switch-Board-Core-Models-Device-Loops-#ctor-Magic-Switch-Board-Core-Enums-LoopChannels- 'Magic.Switch.Board.Core.Models.Device.Loops.#ctor(Magic.Switch.Board.Core.Enums.LoopChannels)')
  - [Channels](#P-Magic-Switch-Board-Core-Models-Device-Loops-Channels 'Magic.Switch.Board.Core.Models.Device.Loops.Channels')
- [Output](#T-Magic-Switch-Board-Core-Models-Device-Output 'Magic.Switch.Board.Core.Models.Device.Output')
  - [#ctor()](#M-Magic-Switch-Board-Core-Models-Device-Output-#ctor 'Magic.Switch.Board.Core.Models.Device.Output.#ctor')
  - [#ctor(midiChannel,messageType,number)](#M-Magic-Switch-Board-Core-Models-Device-Output-#ctor-Magic-Switch-Board-Core-Enums-MidiChannel,Magic-Switch-Board-Core-Enums-MidiMessageType,System-Int32- 'Magic.Switch.Board.Core.Models.Device.Output.#ctor(Magic.Switch.Board.Core.Enums.MidiChannel,Magic.Switch.Board.Core.Enums.MidiMessageType,System.Int32)')
- [Resources](#T-Magic-Switch-Board-Core-Properties-Resources 'Magic.Switch.Board.Core.Properties.Resources')
  - [Culture](#P-Magic-Switch-Board-Core-Properties-Resources-Culture 'Magic.Switch.Board.Core.Properties.Resources.Culture')
  - [Enum_LogLevel_Critical_Description](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_LogLevel_Critical_Description 'Magic.Switch.Board.Core.Properties.Resources.Enum_LogLevel_Critical_Description')
  - [Enum_LogLevel_Critical_Name](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_LogLevel_Critical_Name 'Magic.Switch.Board.Core.Properties.Resources.Enum_LogLevel_Critical_Name')
  - [Enum_LogLevel_Debug_Description](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_LogLevel_Debug_Description 'Magic.Switch.Board.Core.Properties.Resources.Enum_LogLevel_Debug_Description')
  - [Enum_LogLevel_Debug_Name](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_LogLevel_Debug_Name 'Magic.Switch.Board.Core.Properties.Resources.Enum_LogLevel_Debug_Name')
  - [Enum_LogLevel_Error_Description](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_LogLevel_Error_Description 'Magic.Switch.Board.Core.Properties.Resources.Enum_LogLevel_Error_Description')
  - [Enum_LogLevel_Error_Name](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_LogLevel_Error_Name 'Magic.Switch.Board.Core.Properties.Resources.Enum_LogLevel_Error_Name')
  - [Enum_LogLevel_Information_Description](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_LogLevel_Information_Description 'Magic.Switch.Board.Core.Properties.Resources.Enum_LogLevel_Information_Description')
  - [Enum_LogLevel_Information_Name](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_LogLevel_Information_Name 'Magic.Switch.Board.Core.Properties.Resources.Enum_LogLevel_Information_Name')
  - [Enum_LogLevel_None_Description](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_LogLevel_None_Description 'Magic.Switch.Board.Core.Properties.Resources.Enum_LogLevel_None_Description')
  - [Enum_LogLevel_None_Name](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_LogLevel_None_Name 'Magic.Switch.Board.Core.Properties.Resources.Enum_LogLevel_None_Name')
  - [Enum_LogLevel_Trace_Description](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_LogLevel_Trace_Description 'Magic.Switch.Board.Core.Properties.Resources.Enum_LogLevel_Trace_Description')
  - [Enum_LogLevel_Trace_Name](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_LogLevel_Trace_Name 'Magic.Switch.Board.Core.Properties.Resources.Enum_LogLevel_Trace_Name')
  - [Enum_LogLevel_Warning_Description](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_LogLevel_Warning_Description 'Magic.Switch.Board.Core.Properties.Resources.Enum_LogLevel_Warning_Description')
  - [Enum_LogLevel_Warning_Name](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_LogLevel_Warning_Name 'Magic.Switch.Board.Core.Properties.Resources.Enum_LogLevel_Warning_Name')
  - [Enum_LoopChannel_1_Name](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_LoopChannel_1_Name 'Magic.Switch.Board.Core.Properties.Resources.Enum_LoopChannel_1_Name')
  - [Enum_LoopChannel_2_Name](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_LoopChannel_2_Name 'Magic.Switch.Board.Core.Properties.Resources.Enum_LoopChannel_2_Name')
  - [Enum_LoopChannel_3_Name](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_LoopChannel_3_Name 'Magic.Switch.Board.Core.Properties.Resources.Enum_LoopChannel_3_Name')
  - [Enum_LoopChannel_4_Name](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_LoopChannel_4_Name 'Magic.Switch.Board.Core.Properties.Resources.Enum_LoopChannel_4_Name')
  - [Enum_LoopChannel_5_Name](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_LoopChannel_5_Name 'Magic.Switch.Board.Core.Properties.Resources.Enum_LoopChannel_5_Name')
  - [Enum_LoopChannel_6_Name](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_LoopChannel_6_Name 'Magic.Switch.Board.Core.Properties.Resources.Enum_LoopChannel_6_Name')
  - [Enum_LoopChannel_7_Name](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_LoopChannel_7_Name 'Magic.Switch.Board.Core.Properties.Resources.Enum_LoopChannel_7_Name')
  - [Enum_LoopChannel_8_Name](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_LoopChannel_8_Name 'Magic.Switch.Board.Core.Properties.Resources.Enum_LoopChannel_8_Name')
  - [Enum_MidiChannel_10_Name](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_MidiChannel_10_Name 'Magic.Switch.Board.Core.Properties.Resources.Enum_MidiChannel_10_Name')
  - [Enum_MidiChannel_11_Name](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_MidiChannel_11_Name 'Magic.Switch.Board.Core.Properties.Resources.Enum_MidiChannel_11_Name')
  - [Enum_MidiChannel_12_Name](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_MidiChannel_12_Name 'Magic.Switch.Board.Core.Properties.Resources.Enum_MidiChannel_12_Name')
  - [Enum_MidiChannel_13_Name](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_MidiChannel_13_Name 'Magic.Switch.Board.Core.Properties.Resources.Enum_MidiChannel_13_Name')
  - [Enum_MidiChannel_14_Name](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_MidiChannel_14_Name 'Magic.Switch.Board.Core.Properties.Resources.Enum_MidiChannel_14_Name')
  - [Enum_MidiChannel_15_Name](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_MidiChannel_15_Name 'Magic.Switch.Board.Core.Properties.Resources.Enum_MidiChannel_15_Name')
  - [Enum_MidiChannel_16_Name](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_MidiChannel_16_Name 'Magic.Switch.Board.Core.Properties.Resources.Enum_MidiChannel_16_Name')
  - [Enum_MidiChannel_1_Name](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_MidiChannel_1_Name 'Magic.Switch.Board.Core.Properties.Resources.Enum_MidiChannel_1_Name')
  - [Enum_MidiChannel_2_Name](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_MidiChannel_2_Name 'Magic.Switch.Board.Core.Properties.Resources.Enum_MidiChannel_2_Name')
  - [Enum_MidiChannel_3_Name](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_MidiChannel_3_Name 'Magic.Switch.Board.Core.Properties.Resources.Enum_MidiChannel_3_Name')
  - [Enum_MidiChannel_4_Name](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_MidiChannel_4_Name 'Magic.Switch.Board.Core.Properties.Resources.Enum_MidiChannel_4_Name')
  - [Enum_MidiChannel_5_Name](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_MidiChannel_5_Name 'Magic.Switch.Board.Core.Properties.Resources.Enum_MidiChannel_5_Name')
  - [Enum_MidiChannel_6_Name](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_MidiChannel_6_Name 'Magic.Switch.Board.Core.Properties.Resources.Enum_MidiChannel_6_Name')
  - [Enum_MidiChannel_7_Name](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_MidiChannel_7_Name 'Magic.Switch.Board.Core.Properties.Resources.Enum_MidiChannel_7_Name')
  - [Enum_MidiChannel_8_Name](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_MidiChannel_8_Name 'Magic.Switch.Board.Core.Properties.Resources.Enum_MidiChannel_8_Name')
  - [Enum_MidiChannel_9_Name](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_MidiChannel_9_Name 'Magic.Switch.Board.Core.Properties.Resources.Enum_MidiChannel_9_Name')
  - [Enum_MidiMessageType_CCM_Description](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_MidiMessageType_CCM_Description 'Magic.Switch.Board.Core.Properties.Resources.Enum_MidiMessageType_CCM_Description')
  - [Enum_MidiMessageType_CCM_Name](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_MidiMessageType_CCM_Name 'Magic.Switch.Board.Core.Properties.Resources.Enum_MidiMessageType_CCM_Name')
  - [Enum_MidiMessageType_PCM_Description](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_MidiMessageType_PCM_Description 'Magic.Switch.Board.Core.Properties.Resources.Enum_MidiMessageType_PCM_Description')
  - [Enum_MidiMessageType_PCM_Name](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_MidiMessageType_PCM_Name 'Magic.Switch.Board.Core.Properties.Resources.Enum_MidiMessageType_PCM_Name')
  - [Enum_SwitchChannel_1_Name](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_SwitchChannel_1_Name 'Magic.Switch.Board.Core.Properties.Resources.Enum_SwitchChannel_1_Name')
  - [Enum_SwitchChannel_2_Name](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_SwitchChannel_2_Name 'Magic.Switch.Board.Core.Properties.Resources.Enum_SwitchChannel_2_Name')
  - [Enum_SwitchChannel_3_Name](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_SwitchChannel_3_Name 'Magic.Switch.Board.Core.Properties.Resources.Enum_SwitchChannel_3_Name')
  - [Enum_SwitchChannel_4_Name](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_SwitchChannel_4_Name 'Magic.Switch.Board.Core.Properties.Resources.Enum_SwitchChannel_4_Name')
  - [Enum_SwitchChannel_5_Name](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_SwitchChannel_5_Name 'Magic.Switch.Board.Core.Properties.Resources.Enum_SwitchChannel_5_Name')
  - [Enum_SwitchChannel_6_Name](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_SwitchChannel_6_Name 'Magic.Switch.Board.Core.Properties.Resources.Enum_SwitchChannel_6_Name')
  - [Enum_SwitchChannel_7_Name](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_SwitchChannel_7_Name 'Magic.Switch.Board.Core.Properties.Resources.Enum_SwitchChannel_7_Name')
  - [Enum_SwitchChannel_8_Name](#P-Magic-Switch-Board-Core-Properties-Resources-Enum_SwitchChannel_8_Name 'Magic.Switch.Board.Core.Properties.Resources.Enum_SwitchChannel_8_Name')
  - [Error_While_Creating_A_New_Device_Configuration](#P-Magic-Switch-Board-Core-Properties-Resources-Error_While_Creating_A_New_Device_Configuration 'Magic.Switch.Board.Core.Properties.Resources.Error_While_Creating_A_New_Device_Configuration')
  - [Error_While_Creating_File](#P-Magic-Switch-Board-Core-Properties-Resources-Error_While_Creating_File 'Magic.Switch.Board.Core.Properties.Resources.Error_While_Creating_File')
  - [Error_While_Deleting_File](#P-Magic-Switch-Board-Core-Properties-Resources-Error_While_Deleting_File 'Magic.Switch.Board.Core.Properties.Resources.Error_While_Deleting_File')
  - [Error_While_Fetching_Enum_List](#P-Magic-Switch-Board-Core-Properties-Resources-Error_While_Fetching_Enum_List 'Magic.Switch.Board.Core.Properties.Resources.Error_While_Fetching_Enum_List')
  - [Error_While_Reading_A_Existing_Device_Configuration](#P-Magic-Switch-Board-Core-Properties-Resources-Error_While_Reading_A_Existing_Device_Configuration 'Magic.Switch.Board.Core.Properties.Resources.Error_While_Reading_A_Existing_Device_Configuration')
  - [Error_While_Reading_File](#P-Magic-Switch-Board-Core-Properties-Resources-Error_While_Reading_File 'Magic.Switch.Board.Core.Properties.Resources.Error_While_Reading_File')
  - [Error_While_Saving_Device_Configuration](#P-Magic-Switch-Board-Core-Properties-Resources-Error_While_Saving_Device_Configuration 'Magic.Switch.Board.Core.Properties.Resources.Error_While_Saving_Device_Configuration')
  - [Error_Xml_Unknown_Attribute](#P-Magic-Switch-Board-Core-Properties-Resources-Error_Xml_Unknown_Attribute 'Magic.Switch.Board.Core.Properties.Resources.Error_Xml_Unknown_Attribute')
  - [Error_Xml_Unknown_Element](#P-Magic-Switch-Board-Core-Properties-Resources-Error_Xml_Unknown_Element 'Magic.Switch.Board.Core.Properties.Resources.Error_Xml_Unknown_Element')
  - [Error_Xml_Unknown_Node](#P-Magic-Switch-Board-Core-Properties-Resources-Error_Xml_Unknown_Node 'Magic.Switch.Board.Core.Properties.Resources.Error_Xml_Unknown_Node')
  - [File_Service_Error_Directory](#P-Magic-Switch-Board-Core-Properties-Resources-File_Service_Error_Directory 'Magic.Switch.Board.Core.Properties.Resources.File_Service_Error_Directory')
  - [File_Service_Error_File](#P-Magic-Switch-Board-Core-Properties-Resources-File_Service_Error_File 'Magic.Switch.Board.Core.Properties.Resources.File_Service_Error_File')
  - [File_Service_File_Created](#P-Magic-Switch-Board-Core-Properties-Resources-File_Service_File_Created 'Magic.Switch.Board.Core.Properties.Resources.File_Service_File_Created')
  - [File_Service_File_Deleted](#P-Magic-Switch-Board-Core-Properties-Resources-File_Service_File_Deleted 'Magic.Switch.Board.Core.Properties.Resources.File_Service_File_Deleted')
  - [File_Service_File_Read](#P-Magic-Switch-Board-Core-Properties-Resources-File_Service_File_Read 'Magic.Switch.Board.Core.Properties.Resources.File_Service_File_Read')
  - [Model_Field_MaxLength_Generic](#P-Magic-Switch-Board-Core-Properties-Resources-Model_Field_MaxLength_Generic 'Magic.Switch.Board.Core.Properties.Resources.Model_Field_MaxLength_Generic')
  - [Model_Field_Range_Generic](#P-Magic-Switch-Board-Core-Properties-Resources-Model_Field_Range_Generic 'Magic.Switch.Board.Core.Properties.Resources.Model_Field_Range_Generic')
  - [Model_Field_Required_Generic](#P-Magic-Switch-Board-Core-Properties-Resources-Model_Field_Required_Generic 'Magic.Switch.Board.Core.Properties.Resources.Model_Field_Required_Generic')
  - [Model_Field_StringLength_Generic](#P-Magic-Switch-Board-Core-Properties-Resources-Model_Field_StringLength_Generic 'Magic.Switch.Board.Core.Properties.Resources.Model_Field_StringLength_Generic')
  - [ResourceManager](#P-Magic-Switch-Board-Core-Properties-Resources-ResourceManager 'Magic.Switch.Board.Core.Properties.Resources.ResourceManager')
- [ServiceException](#T-Magic-Switch-Board-Core-Exceptions-ServiceException 'Magic.Switch.Board.Core.Exceptions.ServiceException')
  - [#ctor(message,innerException)](#M-Magic-Switch-Board-Core-Exceptions-ServiceException-#ctor-System-String,System-Exception- 'Magic.Switch.Board.Core.Exceptions.ServiceException.#ctor(System.String,System.Exception)')
- [Statics](#T-Magic-Switch-Board-Core-Statics 'Magic.Switch.Board.Core.Statics')
  - [AssemblyDirectory](#P-Magic-Switch-Board-Core-Statics-AssemblyDirectory 'Magic.Switch.Board.Core.Statics.AssemblyDirectory')
  - [AssemblyName](#P-Magic-Switch-Board-Core-Statics-AssemblyName 'Magic.Switch.Board.Core.Statics.AssemblyName')
  - [AssemblyVersion](#P-Magic-Switch-Board-Core-Statics-AssemblyVersion 'Magic.Switch.Board.Core.Statics.AssemblyVersion')
  - [CurrentCulture](#P-Magic-Switch-Board-Core-Statics-CurrentCulture 'Magic.Switch.Board.Core.Statics.CurrentCulture')
  - [DeviceConfigFileName](#P-Magic-Switch-Board-Core-Statics-DeviceConfigFileName 'Magic.Switch.Board.Core.Statics.DeviceConfigFileName')
  - [LogFileName](#P-Magic-Switch-Board-Core-Statics-LogFileName 'Magic.Switch.Board.Core.Statics.LogFileName')
  - [#cctor()](#M-Magic-Switch-Board-Core-Statics-#cctor 'Magic.Switch.Board.Core.Statics.#cctor')
- [StringWriterHelper](#T-Magic-Switch-Board-Core-Helpers-StringWriterHelper 'Magic.Switch.Board.Core.Helpers.StringWriterHelper')
  - [#ctor(encoding)](#M-Magic-Switch-Board-Core-Helpers-StringWriterHelper-#ctor-System-Text-Encoding- 'Magic.Switch.Board.Core.Helpers.StringWriterHelper.#ctor(System.Text.Encoding)')
  - [Encoding](#P-Magic-Switch-Board-Core-Helpers-StringWriterHelper-Encoding 'Magic.Switch.Board.Core.Helpers.StringWriterHelper.Encoding')
- [Switches](#T-Magic-Switch-Board-Core-Models-Device-Switches 'Magic.Switch.Board.Core.Models.Device.Switches')
  - [#ctor()](#M-Magic-Switch-Board-Core-Models-Device-Switches-#ctor 'Magic.Switch.Board.Core.Models.Device.Switches.#ctor')
  - [#ctor(channels)](#M-Magic-Switch-Board-Core-Models-Device-Switches-#ctor-Magic-Switch-Board-Core-Enums-SwitchChannels- 'Magic.Switch.Board.Core.Models.Device.Switches.#ctor(Magic.Switch.Board.Core.Enums.SwitchChannels)')
  - [Channels](#P-Magic-Switch-Board-Core-Models-Device-Switches-Channels 'Magic.Switch.Board.Core.Models.Device.Switches.Channels')
- [XmlHelper\`1](#T-Magic-Switch-Board-Core-Helpers-XmlHelper`1 'Magic.Switch.Board.Core.Helpers.XmlHelper`1')
  - [#ctor()](#M-Magic-Switch-Board-Core-Helpers-XmlHelper`1-#ctor 'Magic.Switch.Board.Core.Helpers.XmlHelper`1.#ctor')
  - [Deserialize(xmlString)](#M-Magic-Switch-Board-Core-Helpers-XmlHelper`1-Deserialize-System-String- 'Magic.Switch.Board.Core.Helpers.XmlHelper`1.Deserialize(System.String)')
  - [Deserialize(xmlDocument)](#M-Magic-Switch-Board-Core-Helpers-XmlHelper`1-Deserialize-System-Xml-XmlDocument- 'Magic.Switch.Board.Core.Helpers.XmlHelper`1.Deserialize(System.Xml.XmlDocument)')
  - [Deserialize(textReader)](#M-Magic-Switch-Board-Core-Helpers-XmlHelper`1-Deserialize-System-IO-TextReader- 'Magic.Switch.Board.Core.Helpers.XmlHelper`1.Deserialize(System.IO.TextReader)')
  - [OnUnknownAttribute(sender,e)](#M-Magic-Switch-Board-Core-Helpers-XmlHelper`1-OnUnknownAttribute-System-Object,System-Xml-Serialization-XmlAttributeEventArgs- 'Magic.Switch.Board.Core.Helpers.XmlHelper`1.OnUnknownAttribute(System.Object,System.Xml.Serialization.XmlAttributeEventArgs)')
  - [OnUnknownElement(sender,e)](#M-Magic-Switch-Board-Core-Helpers-XmlHelper`1-OnUnknownElement-System-Object,System-Xml-Serialization-XmlElementEventArgs- 'Magic.Switch.Board.Core.Helpers.XmlHelper`1.OnUnknownElement(System.Object,System.Xml.Serialization.XmlElementEventArgs)')
  - [OnUnknownNode(sender,e)](#M-Magic-Switch-Board-Core-Helpers-XmlHelper`1-OnUnknownNode-System-Object,System-Xml-Serialization-XmlNodeEventArgs- 'Magic.Switch.Board.Core.Helpers.XmlHelper`1.OnUnknownNode(System.Object,System.Xml.Serialization.XmlNodeEventArgs)')
  - [Serialize(obj,encoding)](#M-Magic-Switch-Board-Core-Helpers-XmlHelper`1-Serialize-`0,System-Text-Encoding- 'Magic.Switch.Board.Core.Helpers.XmlHelper`1.Serialize(`0,System.Text.Encoding)')
  - [StringSerialize(obj,encoding)](#M-Magic-Switch-Board-Core-Helpers-XmlHelper`1-StringSerialize-`0,System-Text-Encoding- 'Magic.Switch.Board.Core.Helpers.XmlHelper`1.StringSerialize(`0,System.Text.Encoding)')
  - [WriterSerialize(obj,encoding)](#M-Magic-Switch-Board-Core-Helpers-XmlHelper`1-WriterSerialize-`0,System-Text-Encoding- 'Magic.Switch.Board.Core.Helpers.XmlHelper`1.WriterSerialize(`0,System.Text.Encoding)')

<a name='T-Magic-Switch-Board-Core-Models-Device-Base-AuditBase'></a>
## AuditBase `type`

##### Namespace

Magic.Switch.Board.Core.Models.Device.Base

##### Summary

The [AuditBase](#T-Magic-Switch-Board-Core-Models-Device-Base-AuditBase 'Magic.Switch.Board.Core.Models.Device.Base.AuditBase') class.

<a name='M-Magic-Switch-Board-Core-Models-Device-Base-AuditBase-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new parameterless instance of the [AuditBase](#T-Magic-Switch-Board-Core-Models-Device-Base-AuditBase 'Magic.Switch.Board.Core.Models.Device.Base.AuditBase') class.

##### Parameters

This constructor has no parameters.

<a name='M-Magic-Switch-Board-Core-Models-Device-Base-AuditBase-#ctor-System-String-'></a>
### #ctor(name) `constructor`

##### Summary

Initializes a new instance of the [AuditBase](#T-Magic-Switch-Board-Core-Models-Device-Base-AuditBase 'Magic.Switch.Board.Core.Models.Device.Base.AuditBase') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name parameter. Will throw an exception if `null`. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |

<a name='P-Magic-Switch-Board-Core-Models-Device-Base-AuditBase-Created'></a>
### Created `property`

##### Summary

The [Created](#P-Magic-Switch-Board-Core-Models-Device-Base-AuditBase-Created 'Magic.Switch.Board.Core.Models.Device.Base.AuditBase.Created') property.

##### Remarks

When was the configuration created?

<a name='P-Magic-Switch-Board-Core-Models-Device-Base-AuditBase-Description'></a>
### Description `property`

##### Summary

The [Description](#P-Magic-Switch-Board-Core-Models-Device-Base-AuditBase-Description 'Magic.Switch.Board.Core.Models.Device.Base.AuditBase.Description') property, can be `null`.

<a name='P-Magic-Switch-Board-Core-Models-Device-Base-AuditBase-Id'></a>
### Id `property`

##### Summary

The [Id](#P-Magic-Switch-Board-Core-Models-Device-Base-AuditBase-Id 'Magic.Switch.Board.Core.Models.Device.Base.AuditBase.Id') property.

<a name='P-Magic-Switch-Board-Core-Models-Device-Base-AuditBase-Name'></a>
### Name `property`

##### Summary

The [Name](#P-Magic-Switch-Board-Core-Models-Device-Base-AuditBase-Name 'Magic.Switch.Board.Core.Models.Device.Base.AuditBase.Name') property, can not be `null`.

<a name='P-Magic-Switch-Board-Core-Models-Device-Base-AuditBase-Updated'></a>
### Updated `property`

##### Summary

The [Updated](#P-Magic-Switch-Board-Core-Models-Device-Base-AuditBase-Updated 'Magic.Switch.Board.Core.Models.Device.Base.AuditBase.Updated') property.

##### Remarks

When was the configuration the last time modified?

<a name='T-Magic-Switch-Board-Core-Models-Device-Channel'></a>
## Channel `type`

##### Namespace

Magic.Switch.Board.Core.Models.Device

##### Summary

The [Channel](#T-Magic-Switch-Board-Core-Models-Device-Channel 'Magic.Switch.Board.Core.Models.Device.Channel') class.

##### Remarks

Inherits the properties from [AuditBase](#T-Magic-Switch-Board-Core-Models-Device-Base-AuditBase 'Magic.Switch.Board.Core.Models.Device.Base.AuditBase') class.

<a name='M-Magic-Switch-Board-Core-Models-Device-Channel-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new parameterless instance of the [Channel](#T-Magic-Switch-Board-Core-Models-Device-Channel 'Magic.Switch.Board.Core.Models.Device.Channel') class.

##### Parameters

This constructor has no parameters.

<a name='M-Magic-Switch-Board-Core-Models-Device-Channel-#ctor-System-String,Magic-Switch-Board-Core-Models-Device-Input,Magic-Switch-Board-Core-Models-Device-Output,Magic-Switch-Board-Core-Models-Device-Switches,Magic-Switch-Board-Core-Models-Device-Loops-'></a>
### #ctor(name,input,output,switches,loops) `constructor`

##### Summary

Initializes a new instance of the [Channel](#T-Magic-Switch-Board-Core-Models-Device-Channel 'Magic.Switch.Board.Core.Models.Device.Channel') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the channel configuration. Will throw an exception if `null` |
| input | [Magic.Switch.Board.Core.Models.Device.Input](#T-Magic-Switch-Board-Core-Models-Device-Input 'Magic.Switch.Board.Core.Models.Device.Input') | The input parameters the channel listens to. Will throw an exception if `null` |
| output | [Magic.Switch.Board.Core.Models.Device.Output](#T-Magic-Switch-Board-Core-Models-Device-Output 'Magic.Switch.Board.Core.Models.Device.Output') | The output parameters the channel should send. Will throw an exception if `null` |
| switches | [Magic.Switch.Board.Core.Models.Device.Switches](#T-Magic-Switch-Board-Core-Models-Device-Switches 'Magic.Switch.Board.Core.Models.Device.Switches') | The switches the channel should switch. Will throw an exception if `null` |
| loops | [Magic.Switch.Board.Core.Models.Device.Loops](#T-Magic-Switch-Board-Core-Models-Device-Loops 'Magic.Switch.Board.Core.Models.Device.Loops') | The loops the channel should switch. Will throw an exception if `null` |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |

<a name='P-Magic-Switch-Board-Core-Models-Device-Channel-Input'></a>
### Input `property`

##### Summary

The [Input](#P-Magic-Switch-Board-Core-Models-Device-Channel-Input 'Magic.Switch.Board.Core.Models.Device.Channel.Input') property, can not be `null`.

<a name='P-Magic-Switch-Board-Core-Models-Device-Channel-Loops'></a>
### Loops `property`

##### Summary

The [Loops](#P-Magic-Switch-Board-Core-Models-Device-Channel-Loops 'Magic.Switch.Board.Core.Models.Device.Channel.Loops') property, can be `null`.

<a name='P-Magic-Switch-Board-Core-Models-Device-Channel-Output'></a>
### Output `property`

##### Summary

The [Output](#P-Magic-Switch-Board-Core-Models-Device-Channel-Output 'Magic.Switch.Board.Core.Models.Device.Channel.Output') property, can be `null`.

<a name='P-Magic-Switch-Board-Core-Models-Device-Channel-Switches'></a>
### Switches `property`

##### Summary

The [Switches](#P-Magic-Switch-Board-Core-Models-Device-Channel-Switches 'Magic.Switch.Board.Core.Models.Device.Channel.Switches') property, can be `null`.

<a name='T-Magic-Switch-Board-Core-Models-Device-Configuration'></a>
## Configuration `type`

##### Namespace

Magic.Switch.Board.Core.Models.Device

##### Summary

The [Configuration](#T-Magic-Switch-Board-Core-Models-Device-Configuration 'Magic.Switch.Board.Core.Models.Device.Configuration') class is the root element of the device configuration file.

##### Remarks

Inherits the properties from [AuditBase](#T-Magic-Switch-Board-Core-Models-Device-Base-AuditBase 'Magic.Switch.Board.Core.Models.Device.Base.AuditBase') class.

<a name='M-Magic-Switch-Board-Core-Models-Device-Configuration-#ctor'></a>
### #ctor() `constructor`

##### Summary

The empty [Configuration](#T-Magic-Switch-Board-Core-Models-Device-Configuration 'Magic.Switch.Board.Core.Models.Device.Configuration') class constructor.

##### Parameters

This constructor has no parameters.

<a name='M-Magic-Switch-Board-Core-Models-Device-Configuration-#ctor-System-String,System-String-'></a>
### #ctor(name,applicationVersion) `constructor`

##### Summary

The standard [Configuration](#T-Magic-Switch-Board-Core-Models-Device-Configuration 'Magic.Switch.Board.Core.Models.Device.Configuration') class constructor.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the configuration. Will throw an exception if `null`. |
| applicationVersion | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The version of the application that creates the configuration. Will throw an exception if `null`. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |

##### Remarks

Will throw an exception if `applicationVersion` is `null`.

<a name='M-Magic-Switch-Board-Core-Models-Device-Configuration-#ctor-System-String,System-String,System-Collections-Generic-List{Magic-Switch-Board-Core-Models-Device-Channel}-'></a>
### #ctor(name,applicationVersion,channels) `constructor`

##### Summary

The advanced [Configuration](#T-Magic-Switch-Board-Core-Models-Device-Configuration 'Magic.Switch.Board.Core.Models.Device.Configuration') class constructor.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the configuration. Will throw an exception if `null`. |
| applicationVersion | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The version of the application that creates the configuration. Will throw an exception if `null`. |
| channels | [System.Collections.Generic.List{Magic.Switch.Board.Core.Models.Device.Channel}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{Magic.Switch.Board.Core.Models.Device.Channel}') | The list of channels that should be added. Will throw an exception if `null`. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |

<a name='P-Magic-Switch-Board-Core-Models-Device-Configuration-ApplicationVersion'></a>
### ApplicationVersion `property`

##### Summary

The [ApplicationVersion](#P-Magic-Switch-Board-Core-Models-Device-Configuration-ApplicationVersion 'Magic.Switch.Board.Core.Models.Device.Configuration.ApplicationVersion') property, can not be `null`.

<a name='P-Magic-Switch-Board-Core-Models-Device-Configuration-Channels'></a>
### Channels `property`

##### Summary

The [Channels](#P-Magic-Switch-Board-Core-Models-Device-Configuration-Channels 'Magic.Switch.Board.Core.Models.Device.Configuration.Channels') property.

<a name='P-Magic-Switch-Board-Core-Models-Device-Configuration-ConfigurationVersion'></a>
### ConfigurationVersion `property`

##### Summary

[ConfigurationVersion](#P-Magic-Switch-Board-Core-Models-Device-Configuration-ConfigurationVersion 'Magic.Switch.Board.Core.Models.Device.Configuration.ConfigurationVersion') property, can not be `null`.

<a name='T-Magic-Switch-Board-Core-Services-ConsoleLoggerService'></a>
## ConsoleLoggerService `type`

##### Namespace

Magic.Switch.Board.Core.Services

##### Summary

This is the [ConsoleLoggerService](#T-Magic-Switch-Board-Core-Services-ConsoleLoggerService 'Magic.Switch.Board.Core.Services.ConsoleLoggerService') class which implements the members of the [ILoggerService](#T-Magic-Switch-Board-Core-Contracts-Services-ILoggerService 'Magic.Switch.Board.Core.Contracts.Services.ILoggerService') interface.

##### Remarks

As the class name suggest, the logging is done via the vs console.

<a name='M-Magic-Switch-Board-Core-Services-ConsoleLoggerService-Critical-System-String,System-String-'></a>
### Critical() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Magic-Switch-Board-Core-Services-ConsoleLoggerService-Debug-System-String,System-String-'></a>
### Debug() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Magic-Switch-Board-Core-Services-ConsoleLoggerService-Error-System-String,System-String-'></a>
### Error() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Magic-Switch-Board-Core-Services-ConsoleLoggerService-Information-System-String,System-String-'></a>
### Information() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Magic-Switch-Board-Core-Services-ConsoleLoggerService-LogToConsole-System-String,System-String,System-String-'></a>
### LogToConsole(type,caller,message) `method`

##### Summary

The [LogToConsole](#M-Magic-Switch-Board-Core-Services-ConsoleLoggerService-LogToConsole-System-String,System-String,System-String- 'Magic.Switch.Board.Core.Services.ConsoleLoggerService.LogToConsole(System.String,System.String,System.String)') method logs the message content to the console.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The logger message type. |
| caller | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The logger message caller. |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The logger message itself. |

<a name='M-Magic-Switch-Board-Core-Services-ConsoleLoggerService-Trace-System-String,System-String-'></a>
### Trace() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Magic-Switch-Board-Core-Services-ConsoleLoggerService-Warning-System-String,System-String-'></a>
### Warning() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Magic-Switch-Board-Core-Services-DeviceConfigService'></a>
## DeviceConfigService `type`

##### Namespace

Magic.Switch.Board.Core.Services

##### Summary

The [DeviceConfigService](#T-Magic-Switch-Board-Core-Services-DeviceConfigService 'Magic.Switch.Board.Core.Services.DeviceConfigService') class implements the members of the [IDeviceConfigService](#T-Magic-Switch-Board-Core-Contracts-Services-IDeviceConfigService 'Magic.Switch.Board.Core.Contracts.Services.IDeviceConfigService') interface.

<a name='M-Magic-Switch-Board-Core-Services-DeviceConfigService-#ctor-Magic-Switch-Board-Core-Contracts-Services-ILoggerService,Magic-Switch-Board-Core-Contracts-Services-IFileService-'></a>
### #ctor(logger,fileService) `constructor`

##### Summary

Initializes a new instance of the [DeviceConfigService](#T-Magic-Switch-Board-Core-Services-DeviceConfigService 'Magic.Switch.Board.Core.Services.DeviceConfigService') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logger | [Magic.Switch.Board.Core.Contracts.Services.ILoggerService](#T-Magic-Switch-Board-Core-Contracts-Services-ILoggerService 'Magic.Switch.Board.Core.Contracts.Services.ILoggerService') | The logger service. |
| fileService | [Magic.Switch.Board.Core.Contracts.Services.IFileService](#T-Magic-Switch-Board-Core-Contracts-Services-IFileService 'Magic.Switch.Board.Core.Contracts.Services.IFileService') | The file service. |

<a name='M-Magic-Switch-Board-Core-Services-DeviceConfigService-Create-System-String,System-String-'></a>
### Create() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [Magic.Switch.Board.Core.Exceptions.ServiceException](#T-Magic-Switch-Board-Core-Exceptions-ServiceException 'Magic.Switch.Board.Core.Exceptions.ServiceException') |  |

<a name='M-Magic-Switch-Board-Core-Services-DeviceConfigService-Read-System-String,System-String-'></a>
### Read() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Magic.Switch.Board.Core.Exceptions.ServiceException](#T-Magic-Switch-Board-Core-Exceptions-ServiceException 'Magic.Switch.Board.Core.Exceptions.ServiceException') |  |

<a name='M-Magic-Switch-Board-Core-Services-DeviceConfigService-Write-System-String,System-String,Magic-Switch-Board-Core-Models-Device-Configuration,System-Text-Encoding-'></a>
### Write() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [Magic.Switch.Board.Core.Exceptions.ServiceException](#T-Magic-Switch-Board-Core-Exceptions-ServiceException 'Magic.Switch.Board.Core.Exceptions.ServiceException') |  |

<a name='M-Magic-Switch-Board-Core-Services-DeviceConfigService-Write-System-String,System-String,Magic-Switch-Board-Core-Models-Device-Configuration-'></a>
### Write() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [Magic.Switch.Board.Core.Exceptions.ServiceException](#T-Magic-Switch-Board-Core-Exceptions-ServiceException 'Magic.Switch.Board.Core.Exceptions.ServiceException') |  |

<a name='T-Magic-Switch-Board-Core-Models-EnumModel`1'></a>
## EnumModel\`1 `type`

##### Namespace

Magic.Switch.Board.Core.Models

##### Summary

The [EnumModel\`1](#T-Magic-Switch-Board-Core-Models-EnumModel`1 'Magic.Switch.Board.Core.Models.EnumModel`1') class.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

##### Remarks

The class contains all additional information about an enumerator.

<a name='M-Magic-Switch-Board-Core-Models-EnumModel`1-#ctor-`0,System-String,System-String,System-String-'></a>
### #ctor(enum,name,shortName,description) `constructor`

##### Summary

Initializes a new parameterless instance of the [EnumModel\`1](#T-Magic-Switch-Board-Core-Models-EnumModel`1 'Magic.Switch.Board.Core.Models.EnumModel`1') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enum | [\`0](#T-`0 '`0') | The enumerator itself. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The localized enumerator name. |
| shortName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The localized enumerator short name. |
| description | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The localized enumerator short name. |

<a name='P-Magic-Switch-Board-Core-Models-EnumModel`1-Description'></a>
### Description `property`

##### Summary

The [Description](#P-Magic-Switch-Board-Core-Models-EnumModel`1-Description 'Magic.Switch.Board.Core.Models.EnumModel`1.Description') property.

##### Remarks

The localized enumerator short name.

<a name='P-Magic-Switch-Board-Core-Models-EnumModel`1-Enum'></a>
### Enum `property`

##### Summary

The [Enum](#P-Magic-Switch-Board-Core-Models-EnumModel`1-Enum 'Magic.Switch.Board.Core.Models.EnumModel`1.Enum') property.

##### Remarks

The enumerator itself.

<a name='P-Magic-Switch-Board-Core-Models-EnumModel`1-Name'></a>
### Name `property`

##### Summary

The [Name](#P-Magic-Switch-Board-Core-Models-EnumModel`1-Name 'Magic.Switch.Board.Core.Models.EnumModel`1.Name') property.

##### Remarks

The localized enumerator name.

<a name='P-Magic-Switch-Board-Core-Models-EnumModel`1-ShortName'></a>
### ShortName `property`

##### Summary

The [ShortName](#P-Magic-Switch-Board-Core-Models-EnumModel`1-ShortName 'Magic.Switch.Board.Core.Models.EnumModel`1.ShortName') property.

##### Remarks

The localized enumerator short name.

<a name='T-Magic-Switch-Board-Core-Services-EnumService'></a>
## EnumService `type`

##### Namespace

Magic.Switch.Board.Core.Services

##### Summary

The [EnumService](#T-Magic-Switch-Board-Core-Services-EnumService 'Magic.Switch.Board.Core.Services.EnumService') class implements the members of the [IEnumService](#T-Magic-Switch-Board-Core-Contracts-Services-IEnumService 'Magic.Switch.Board.Core.Contracts.Services.IEnumService') interface.

<a name='M-Magic-Switch-Board-Core-Services-EnumService-#ctor-Magic-Switch-Board-Core-Contracts-Services-ILoggerService-'></a>
### #ctor(logger) `constructor`

##### Summary

Initializes a new instance of the [EnumService](#T-Magic-Switch-Board-Core-Services-EnumService 'Magic.Switch.Board.Core.Services.EnumService') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logger | [Magic.Switch.Board.Core.Contracts.Services.ILoggerService](#T-Magic-Switch-Board-Core-Contracts-Services-ILoggerService 'Magic.Switch.Board.Core.Contracts.Services.ILoggerService') | The logger service. |

<a name='M-Magic-Switch-Board-Core-Services-EnumService-GetLogLevels'></a>
### GetLogLevels() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Magic.Switch.Board.Core.Exceptions.ServiceException](#T-Magic-Switch-Board-Core-Exceptions-ServiceException 'Magic.Switch.Board.Core.Exceptions.ServiceException') |  |

<a name='M-Magic-Switch-Board-Core-Services-EnumService-GetLoopChannels'></a>
### GetLoopChannels() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Magic.Switch.Board.Core.Exceptions.ServiceException](#T-Magic-Switch-Board-Core-Exceptions-ServiceException 'Magic.Switch.Board.Core.Exceptions.ServiceException') |  |

<a name='M-Magic-Switch-Board-Core-Services-EnumService-GetMidiChannels'></a>
### GetMidiChannels() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Magic.Switch.Board.Core.Exceptions.ServiceException](#T-Magic-Switch-Board-Core-Exceptions-ServiceException 'Magic.Switch.Board.Core.Exceptions.ServiceException') |  |

<a name='M-Magic-Switch-Board-Core-Services-EnumService-GetMidiMessageTypes'></a>
### GetMidiMessageTypes() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Magic.Switch.Board.Core.Exceptions.ServiceException](#T-Magic-Switch-Board-Core-Exceptions-ServiceException 'Magic.Switch.Board.Core.Exceptions.ServiceException') |  |

<a name='M-Magic-Switch-Board-Core-Services-EnumService-GetSwitchChannels'></a>
### GetSwitchChannels() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [Magic.Switch.Board.Core.Exceptions.ServiceException](#T-Magic-Switch-Board-Core-Exceptions-ServiceException 'Magic.Switch.Board.Core.Exceptions.ServiceException') |  |

<a name='T-Magic-Switch-Board-Core-Enums'></a>
## Enums `type`

##### Namespace

Magic.Switch.Board.Core

##### Summary

The [Enums](#T-Magic-Switch-Board-Core-Enums 'Magic.Switch.Board.Core.Enums') class.

<a name='M-Magic-Switch-Board-Core-Enums-FlagsToList``1-``0-'></a>
### FlagsToList\`\`1(enumFlags) `method`

##### Summary

The [FlagsToList\`\`1](#M-Magic-Switch-Board-Core-Enums-FlagsToList``1-``0- 'Magic.Switch.Board.Core.Enums.FlagsToList``1(``0)') extension method returns a [List\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List`1 'System.Collections.Generic.List`1')

##### Returns

A [List\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List`1 'System.Collections.Generic.List`1') of the provided enum flags.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enumFlags | [\`\`0](#T-``0 '``0') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-Magic-Switch-Board-Core-Enums-GetDisplayAttribute``1-``0-'></a>
### GetDisplayAttribute\`\`1(enumValue) `method`

##### Summary

The [GetDisplayAttribute\`\`1](#M-Magic-Switch-Board-Core-Enums-GetDisplayAttribute``1-``0- 'Magic.Switch.Board.Core.Enums.GetDisplayAttribute``1(``0)') method should return the [DisplayAttribute](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.DataAnnotations.DisplayAttribute 'System.ComponentModel.DataAnnotations.DisplayAttribute') from the enum.

##### Returns

The [DisplayAttribute](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.DataAnnotations.DisplayAttribute 'System.ComponentModel.DataAnnotations.DisplayAttribute') or `null`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enumValue | [\`\`0](#T-``0 '``0') | The enum. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

##### Remarks

Will return null if the enum is not decorated with the [DisplayAttribute](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.DataAnnotations.DisplayAttribute 'System.ComponentModel.DataAnnotations.DisplayAttribute').

<a name='M-Magic-Switch-Board-Core-Enums-GetEnumDescription``1-``0-'></a>
### GetEnumDescription\`\`1(enumValue) `method`

##### Summary

The [GetEnumDescription\`\`1](#M-Magic-Switch-Board-Core-Enums-GetEnumDescription``1-``0- 'Magic.Switch.Board.Core.Enums.GetEnumDescription``1(``0)') extension method will try to get the [Description](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.DataAnnotations.DisplayAttribute.Description 'System.ComponentModel.DataAnnotations.DisplayAttribute.Description').

##### Returns

The [Description](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.DataAnnotations.DisplayAttribute.Description 'System.ComponentModel.DataAnnotations.DisplayAttribute.Description') or the `enumValue` as string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enumValue | [\`\`0](#T-``0 '``0') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

##### Remarks

The [GetDescription](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.DataAnnotations.DisplayAttribute.GetDescription 'System.ComponentModel.DataAnnotations.DisplayAttribute.GetDescription') method is used, so strings will be returned localized.

<a name='M-Magic-Switch-Board-Core-Enums-GetEnumModelList``1-``0-'></a>
### GetEnumModelList\`\`1(enumValue) `method`

##### Summary

The [GetEnumModelList\`\`1](#M-Magic-Switch-Board-Core-Enums-GetEnumModelList``1-``0- 'Magic.Switch.Board.Core.Enums.GetEnumModelList``1(``0)') should return a list of the [EnumModel\`1](#T-Magic-Switch-Board-Core-Models-EnumModel`1 'Magic.Switch.Board.Core.Models.EnumModel`1').

##### Returns

A list of type [EnumModel\`1](#T-Magic-Switch-Board-Core-Models-EnumModel`1 'Magic.Switch.Board.Core.Models.EnumModel`1')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enumValue | [\`\`0](#T-``0 '``0') | The enum. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-Magic-Switch-Board-Core-Enums-GetEnumName``1-``0-'></a>
### GetEnumName\`\`1(enumValue) `method`

##### Summary

The [GetEnumName\`\`1](#M-Magic-Switch-Board-Core-Enums-GetEnumName``1-``0- 'Magic.Switch.Board.Core.Enums.GetEnumName``1(``0)') extension method will try to get the [Name](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.DataAnnotations.DisplayAttribute.Name 'System.ComponentModel.DataAnnotations.DisplayAttribute.Name').

##### Returns

The [Name](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.DataAnnotations.DisplayAttribute.Name 'System.ComponentModel.DataAnnotations.DisplayAttribute.Name') or the `enumValue` as string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enumValue | [\`\`0](#T-``0 '``0') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

##### Remarks

The [GetName](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.DataAnnotations.DisplayAttribute.GetName 'System.ComponentModel.DataAnnotations.DisplayAttribute.GetName') method is used, so strings will be returned localized.

<a name='M-Magic-Switch-Board-Core-Enums-GetEnumShortName``1-``0-'></a>
### GetEnumShortName\`\`1(enumValue) `method`

##### Summary

The [GetEnumShortName\`\`1](#M-Magic-Switch-Board-Core-Enums-GetEnumShortName``1-``0- 'Magic.Switch.Board.Core.Enums.GetEnumShortName``1(``0)') extension method will try to get the [ShortName](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.DataAnnotations.DisplayAttribute.ShortName 'System.ComponentModel.DataAnnotations.DisplayAttribute.ShortName').

##### Returns

The [ShortName](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.DataAnnotations.DisplayAttribute.ShortName 'System.ComponentModel.DataAnnotations.DisplayAttribute.ShortName') or the `enumValue` as string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enumValue | [\`\`0](#T-``0 '``0') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

##### Remarks

The [GetShortName](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ComponentModel.DataAnnotations.DisplayAttribute.GetShortName 'System.ComponentModel.DataAnnotations.DisplayAttribute.GetShortName') method is used, so strings will be returned localized.

<a name='M-Magic-Switch-Board-Core-Enums-GetEnumsWithDescription``1-``0-'></a>
### GetEnumsWithDescription\`\`1(enumValue) `method`

##### Summary

The [GetEnumsWithDescription\`\`1](#M-Magic-Switch-Board-Core-Enums-GetEnumsWithDescription``1-``0- 'Magic.Switch.Board.Core.Enums.GetEnumsWithDescription``1(``0)') method should return a dictornary with enums and their description.

##### Returns

A dictionary with enums and their description.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enumValue | [\`\`0](#T-``0 '``0') |  |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

##### Remarks

If the enum has no description property, the enum name will be returned.

<a name='M-Magic-Switch-Board-Core-Enums-GetListFromEnum``1-``0-'></a>
### GetListFromEnum\`\`1() `method`

##### Summary

The [GetListFromEnum\`\`1](#M-Magic-Switch-Board-Core-Enums-GetListFromEnum``1-``0- 'Magic.Switch.Board.Core.Enums.GetListFromEnum``1(``0)') method should return a list of all enumerators of the given type of enum.

##### Returns

A [List\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List`1 'System.Collections.Generic.List`1') of the provided enum.

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='T-Magic-Switch-Board-Core-Services-FileLoggerService'></a>
## FileLoggerService `type`

##### Namespace

Magic.Switch.Board.Core.Services

##### Summary

This is the [FileLoggerService](#T-Magic-Switch-Board-Core-Services-FileLoggerService 'Magic.Switch.Board.Core.Services.FileLoggerService') class which implements the members of the [ILoggerService](#T-Magic-Switch-Board-Core-Contracts-Services-ILoggerService 'Magic.Switch.Board.Core.Contracts.Services.ILoggerService') interface.

##### Remarks

As the class name suggest, the logging is done via logging the messages to file.

<a name='M-Magic-Switch-Board-Core-Services-FileLoggerService-Critical-System-String,System-String-'></a>
### Critical() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Magic-Switch-Board-Core-Services-FileLoggerService-Debug-System-String,System-String-'></a>
### Debug() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Magic-Switch-Board-Core-Services-FileLoggerService-Error-System-String,System-String-'></a>
### Error() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Magic-Switch-Board-Core-Services-FileLoggerService-Information-System-String,System-String-'></a>
### Information() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Magic-Switch-Board-Core-Services-FileLoggerService-LogToFile-System-String,System-String,System-String-'></a>
### LogToFile(type,caller,message) `method`

##### Summary

The [LogToFile](#M-Magic-Switch-Board-Core-Services-FileLoggerService-LogToFile-System-String,System-String,System-String- 'Magic.Switch.Board.Core.Services.FileLoggerService.LogToFile(System.String,System.String,System.String)') method logs the message content to the log file.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The logger message type. |
| caller | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The logger message caller. |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The logger message itself. |

<a name='M-Magic-Switch-Board-Core-Services-FileLoggerService-Trace-System-String,System-String-'></a>
### Trace() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Magic-Switch-Board-Core-Services-FileLoggerService-Warning-System-String,System-String-'></a>
### Warning() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Magic-Switch-Board-Core-Services-FileService'></a>
## FileService `type`

##### Namespace

Magic.Switch.Board.Core.Services

##### Summary

The [FileService](#T-Magic-Switch-Board-Core-Services-FileService 'Magic.Switch.Board.Core.Services.FileService') class implements the mebers of the [IFileService](#T-Magic-Switch-Board-Core-Contracts-Services-IFileService 'Magic.Switch.Board.Core.Contracts.Services.IFileService') interface.

<a name='M-Magic-Switch-Board-Core-Services-FileService-#ctor-Magic-Switch-Board-Core-Contracts-Services-ILoggerService-'></a>
### #ctor(logger) `constructor`

##### Summary

Initializes a new instance of the [FileService](#T-Magic-Switch-Board-Core-Services-FileService 'Magic.Switch.Board.Core.Services.FileService') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| logger | [Magic.Switch.Board.Core.Contracts.Services.ILoggerService](#T-Magic-Switch-Board-Core-Contracts-Services-ILoggerService 'Magic.Switch.Board.Core.Contracts.Services.ILoggerService') |  |

<a name='M-Magic-Switch-Board-Core-Services-FileService-Delete-System-String,System-String-'></a>
### Delete() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |
| [Magic.Switch.Board.Core.Exceptions.ServiceException](#T-Magic-Switch-Board-Core-Exceptions-ServiceException 'Magic.Switch.Board.Core.Exceptions.ServiceException') |  |

<a name='M-Magic-Switch-Board-Core-Services-FileService-DirectoryExists-System-String-'></a>
### DirectoryExists(folderPath) `method`

##### Summary

The [DirectoryExists](#M-Magic-Switch-Board-Core-Services-FileService-DirectoryExists-System-String- 'Magic.Switch.Board.Core.Services.FileService.DirectoryExists(System.String)') method check if the directory exists.

##### Returns

`true` or `false` depending on the outcome.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| folderPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Magic-Switch-Board-Core-Services-FileService-FileExists-System-String-'></a>
### FileExists(fullFilePath) `method`

##### Summary

The [FileExists](#M-Magic-Switch-Board-Core-Services-FileService-FileExists-System-String- 'Magic.Switch.Board.Core.Services.FileService.FileExists(System.String)') method checks if the file exists.

##### Returns

`true` or `false` depending on the outcome.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| fullFilePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The full file path is folder name and file name. |

<a name='M-Magic-Switch-Board-Core-Services-FileService-Read-System-String,System-String-'></a>
### Read() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |
| [Magic.Switch.Board.Core.Exceptions.ServiceException](#T-Magic-Switch-Board-Core-Exceptions-ServiceException 'Magic.Switch.Board.Core.Exceptions.ServiceException') |  |

<a name='M-Magic-Switch-Board-Core-Services-FileService-Save-System-String,System-String,System-String-'></a>
### Save() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') |  |
| [Magic.Switch.Board.Core.Exceptions.ServiceException](#T-Magic-Switch-Board-Core-Exceptions-ServiceException 'Magic.Switch.Board.Core.Exceptions.ServiceException') |  |

<a name='T-Magic-Switch-Board-Core-Contracts-Services-IDeviceConfigService'></a>
## IDeviceConfigService `type`

##### Namespace

Magic.Switch.Board.Core.Contracts.Services

##### Summary

The [IDeviceConfigService](#T-Magic-Switch-Board-Core-Contracts-Services-IDeviceConfigService 'Magic.Switch.Board.Core.Contracts.Services.IDeviceConfigService') interface exposes the public methods for reading an writing the device configuration file.

<a name='M-Magic-Switch-Board-Core-Contracts-Services-IDeviceConfigService-Create-System-String,System-String-'></a>
### Create(applicationVersion,name) `method`

##### Summary

The [Create](#M-Magic-Switch-Board-Core-Contracts-Services-IDeviceConfigService-Create-System-String,System-String- 'Magic.Switch.Board.Core.Contracts.Services.IDeviceConfigService.Create(System.String,System.String)') method should create a new device configuration.

##### Returns

A device configurastion of type [Configuration](#T-Magic-Switch-Board-Core-Models-Device-Configuration 'Magic.Switch.Board.Core.Models.Device.Configuration').

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| applicationVersion | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The Version of the application that creates the device configuration. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the configuration. |

<a name='M-Magic-Switch-Board-Core-Contracts-Services-IDeviceConfigService-Read-System-String,System-String-'></a>
### Read(folderPath,fileName) `method`

##### Summary

The [Read](#M-Magic-Switch-Board-Core-Contracts-Services-IDeviceConfigService-Read-System-String,System-String- 'Magic.Switch.Board.Core.Contracts.Services.IDeviceConfigService.Read(System.String,System.String)') method should read the device configuration from file.

##### Returns

The device configuration or `null`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| folderPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| fileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Magic-Switch-Board-Core-Contracts-Services-IDeviceConfigService-Write-System-String,System-String,Magic-Switch-Board-Core-Models-Device-Configuration-'></a>
### Write(folderPath,fileName,configuration) `method`

##### Summary

The [Write](#M-Magic-Switch-Board-Core-Contracts-Services-IDeviceConfigService-Write-System-String,System-String,Magic-Switch-Board-Core-Models-Device-Configuration- 'Magic.Switch.Board.Core.Contracts.Services.IDeviceConfigService.Write(System.String,System.String,Magic.Switch.Board.Core.Models.Device.Configuration)') method writes the device configuration to file.

##### Returns

`true` or `false` as success or failure.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| folderPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| fileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| configuration | [Magic.Switch.Board.Core.Models.Device.Configuration](#T-Magic-Switch-Board-Core-Models-Device-Configuration 'Magic.Switch.Board.Core.Models.Device.Configuration') | The device configuration. |

##### Remarks

This method will enforce to use [UTF8](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding.UTF8 'System.Text.Encoding.UTF8').
Will throw an exception if `folderPath` or `fileName` or `configuration` is `null`.

<a name='M-Magic-Switch-Board-Core-Contracts-Services-IDeviceConfigService-Write-System-String,System-String,Magic-Switch-Board-Core-Models-Device-Configuration,System-Text-Encoding-'></a>
### Write(folderPath,fileName,configuration,encoding) `method`

##### Summary

The [Write](#M-Magic-Switch-Board-Core-Contracts-Services-IDeviceConfigService-Write-System-String,System-String,Magic-Switch-Board-Core-Models-Device-Configuration,System-Text-Encoding- 'Magic.Switch.Board.Core.Contracts.Services.IDeviceConfigService.Write(System.String,System.String,Magic.Switch.Board.Core.Models.Device.Configuration,System.Text.Encoding)') method writes the device configuration to file.

##### Returns

`true` or `false` as success or failure.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| folderPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| fileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| configuration | [Magic.Switch.Board.Core.Models.Device.Configuration](#T-Magic-Switch-Board-Core-Models-Device-Configuration 'Magic.Switch.Board.Core.Models.Device.Configuration') | The device configuration. |
| encoding | [System.Text.Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding 'System.Text.Encoding') | The desired encoding type. |

##### Remarks

Since encoding can be `null`, when null, [UTF8](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding.UTF8 'System.Text.Encoding.UTF8') will be used.
Will throw an exception if `folderPath` or `fileName` or `configuration` is `null`.

<a name='T-Magic-Switch-Board-Core-Contracts-Services-IEnumService'></a>
## IEnumService `type`

##### Namespace

Magic.Switch.Board.Core.Contracts.Services

##### Summary

The [IEnumService](#T-Magic-Switch-Board-Core-Contracts-Services-IEnumService 'Magic.Switch.Board.Core.Contracts.Services.IEnumService') interface exposes the public methods for to obtain all enumerator types.

<a name='M-Magic-Switch-Board-Core-Contracts-Services-IEnumService-GetLogLevels'></a>
### GetLogLevels() `method`

##### Summary

The [GetLogLevels](#M-Magic-Switch-Board-Core-Contracts-Services-IEnumService-GetLogLevels 'Magic.Switch.Board.Core.Contracts.Services.IEnumService.GetLogLevels') method should return a read only list for the enum type [LogLevel](#T-Magic-Switch-Board-Core-Enums-LogLevel 'Magic.Switch.Board.Core.Enums.LogLevel').

##### Returns

A read only list of type [EnumModel\`1](#T-Magic-Switch-Board-Core-Models-EnumModel`1 'Magic.Switch.Board.Core.Models.EnumModel`1').

##### Parameters

This method has no parameters.

<a name='M-Magic-Switch-Board-Core-Contracts-Services-IEnumService-GetLoopChannels'></a>
### GetLoopChannels() `method`

##### Summary

The [GetLoopChannels](#M-Magic-Switch-Board-Core-Contracts-Services-IEnumService-GetLoopChannels 'Magic.Switch.Board.Core.Contracts.Services.IEnumService.GetLoopChannels') method should return a read only list for the enum type [LoopChannels](#T-Magic-Switch-Board-Core-Enums-LoopChannels 'Magic.Switch.Board.Core.Enums.LoopChannels').

##### Returns

A read only list of type [EnumModel\`1](#T-Magic-Switch-Board-Core-Models-EnumModel`1 'Magic.Switch.Board.Core.Models.EnumModel`1').

##### Parameters

This method has no parameters.

<a name='M-Magic-Switch-Board-Core-Contracts-Services-IEnumService-GetMidiChannels'></a>
### GetMidiChannels() `method`

##### Summary

The [GetMidiChannels](#M-Magic-Switch-Board-Core-Contracts-Services-IEnumService-GetMidiChannels 'Magic.Switch.Board.Core.Contracts.Services.IEnumService.GetMidiChannels') method should return a read only list for the enum type [MidiChannel](#T-Magic-Switch-Board-Core-Enums-MidiChannel 'Magic.Switch.Board.Core.Enums.MidiChannel').

##### Returns

A read only list of type [EnumModel\`1](#T-Magic-Switch-Board-Core-Models-EnumModel`1 'Magic.Switch.Board.Core.Models.EnumModel`1').

##### Parameters

This method has no parameters.

<a name='M-Magic-Switch-Board-Core-Contracts-Services-IEnumService-GetMidiMessageTypes'></a>
### GetMidiMessageTypes() `method`

##### Summary

The [GetMidiMessageTypes](#M-Magic-Switch-Board-Core-Contracts-Services-IEnumService-GetMidiMessageTypes 'Magic.Switch.Board.Core.Contracts.Services.IEnumService.GetMidiMessageTypes') method should return a read only list for the enum type [MidiMessageType](#T-Magic-Switch-Board-Core-Enums-MidiMessageType 'Magic.Switch.Board.Core.Enums.MidiMessageType').

##### Returns

A read only list of type [EnumModel\`1](#T-Magic-Switch-Board-Core-Models-EnumModel`1 'Magic.Switch.Board.Core.Models.EnumModel`1').

##### Parameters

This method has no parameters.

<a name='M-Magic-Switch-Board-Core-Contracts-Services-IEnumService-GetSwitchChannels'></a>
### GetSwitchChannels() `method`

##### Summary

The [GetSwitchChannels](#M-Magic-Switch-Board-Core-Contracts-Services-IEnumService-GetSwitchChannels 'Magic.Switch.Board.Core.Contracts.Services.IEnumService.GetSwitchChannels') method should return a read only list for the enum type [SwitchChannels](#T-Magic-Switch-Board-Core-Enums-SwitchChannels 'Magic.Switch.Board.Core.Enums.SwitchChannels').

##### Returns

A read only list of type [EnumModel\`1](#T-Magic-Switch-Board-Core-Models-EnumModel`1 'Magic.Switch.Board.Core.Models.EnumModel`1').

##### Parameters

This method has no parameters.

<a name='T-Magic-Switch-Board-Core-Contracts-Services-IFileService'></a>
## IFileService `type`

##### Namespace

Magic.Switch.Board.Core.Contracts.Services

##### Summary

The [IFileService](#T-Magic-Switch-Board-Core-Contracts-Services-IFileService 'Magic.Switch.Board.Core.Contracts.Services.IFileService') interface exposes the public methods for file manipulation.

<a name='M-Magic-Switch-Board-Core-Contracts-Services-IFileService-Delete-System-String,System-String-'></a>
### Delete(folderPath,fileName) `method`

##### Summary

The [Delete](#M-Magic-Switch-Board-Core-Contracts-Services-IFileService-Delete-System-String,System-String- 'Magic.Switch.Board.Core.Contracts.Services.IFileService.Delete(System.String,System.String)') method should be used for deleting a file.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| folderPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The path where the file is located. Will throw an exception if `null`. |
| fileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The file name of the file that should be deleted. Will throw an exception if `null`. |

##### Remarks

Will throw an exception if `fileName` or `folderPath` is `null`.

<a name='M-Magic-Switch-Board-Core-Contracts-Services-IFileService-Read-System-String,System-String-'></a>
### Read(folderPath,fileName) `method`

##### Summary

The [Read](#M-Magic-Switch-Board-Core-Contracts-Services-IFileService-Read-System-String,System-String- 'Magic.Switch.Board.Core.Contracts.Services.IFileService.Read(System.String,System.String)') method should be used for reading a file.

##### Returns

The file content as string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| folderPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The path where the file is located. Will throw an exception if `null`. |
| fileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The file name of the file that should be read. Will throw an exception if `null`. |

<a name='M-Magic-Switch-Board-Core-Contracts-Services-IFileService-Save-System-String,System-String,System-String-'></a>
### Save(folderPath,fileName,fileContent) `method`

##### Summary

The [Save](#M-Magic-Switch-Board-Core-Contracts-Services-IFileService-Save-System-String,System-String,System-String- 'Magic.Switch.Board.Core.Contracts.Services.IFileService.Save(System.String,System.String,System.String)') method should be used for saving a file.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| folderPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The path where the file should be saved. Will throw an exception if `null`. |
| fileName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The file name of the file that should be saved. Will throw an exception if `null`. |
| fileContent | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The content of the file thst should be saved. Will throw an exception if `null`. |

<a name='T-Magic-Switch-Board-Core-Contracts-Services-ILoggerService'></a>
## ILoggerService `type`

##### Namespace

Magic.Switch.Board.Core.Contracts.Services

##### Summary

This is the [ILoggerService](#T-Magic-Switch-Board-Core-Contracts-Services-ILoggerService 'Magic.Switch.Board.Core.Contracts.Services.ILoggerService') interface for various logger service implementations.

<a name='M-Magic-Switch-Board-Core-Contracts-Services-ILoggerService-Critical-System-String,System-String-'></a>
### Critical(message,callerName) `method`

##### Summary

The interface member for logging critical messages.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| callerName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Remarks

Logs that describe an unrecoverable application or system crash, or a catastrophic failure that requires immediate attention.

<a name='M-Magic-Switch-Board-Core-Contracts-Services-ILoggerService-Debug-System-String,System-String-'></a>
### Debug(message,callerName) `method`

##### Summary

The interface member for logging debug messages.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| callerName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Remarks

Logs that are used for interactive investigation during development.
These logs should primarily contain information useful for debugging and have no long-term value.

<a name='M-Magic-Switch-Board-Core-Contracts-Services-ILoggerService-Error-System-String,System-String-'></a>
### Error(message,callerName) `method`

##### Summary

The interface member for logging error messages.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| callerName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Remarks

Logs that highlight when the current flow of execution is stopped due to a failure.
These should indicate a failure in the current activity, not an application-wide failure.

<a name='M-Magic-Switch-Board-Core-Contracts-Services-ILoggerService-Information-System-String,System-String-'></a>
### Information(message,callerName) `method`

##### Summary

The interface member for logging debug messages.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| callerName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Remarks

Logs that track the general flow of the application.
These logs should have long-term value.

<a name='M-Magic-Switch-Board-Core-Contracts-Services-ILoggerService-Trace-System-String,System-String-'></a>
### Trace(message,callerName) `method`

##### Summary

The interface member for logging trace messages.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| callerName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Remarks

Logs that contain the most detailed messages. 
These messages may contain sensitive application data. 
These messages are disabled by default and should never be enabled in a production environment.

<a name='M-Magic-Switch-Board-Core-Contracts-Services-ILoggerService-Warning-System-String,System-String-'></a>
### Warning(message,callerName) `method`

##### Summary

The interface member for logging warning messages.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| callerName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Remarks

Logs that highlight an abnormal or unexpected event in the application flow,
but do not otherwise cause the application execution to stop.

<a name='T-Magic-Switch-Board-Core-Models-Device-Input'></a>
## Input `type`

##### Namespace

Magic.Switch.Board.Core.Models.Device

##### Summary

The [Input](#T-Magic-Switch-Board-Core-Models-Device-Input 'Magic.Switch.Board.Core.Models.Device.Input') class.

##### Remarks

Inherits from the [InputOutputBase](#T-Magic-Switch-Board-Core-Models-Device-Base-InputOutputBase 'Magic.Switch.Board.Core.Models.Device.Base.InputOutputBase') class.

<a name='M-Magic-Switch-Board-Core-Models-Device-Input-#ctor'></a>
### #ctor() `constructor`

##### Summary

The empty [Input](#T-Magic-Switch-Board-Core-Models-Device-Input 'Magic.Switch.Board.Core.Models.Device.Input') class contructor.

##### Parameters

This constructor has no parameters.

<a name='M-Magic-Switch-Board-Core-Models-Device-Input-#ctor-Magic-Switch-Board-Core-Enums-MidiChannel,Magic-Switch-Board-Core-Enums-MidiMessageType,System-Int32-'></a>
### #ctor(midiChannel,messageType,number) `constructor`

##### Summary

The standard [Input](#T-Magic-Switch-Board-Core-Models-Device-Input 'Magic.Switch.Board.Core.Models.Device.Input') class constructor.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| midiChannel | [Magic.Switch.Board.Core.Enums.MidiChannel](#T-Magic-Switch-Board-Core-Enums-MidiChannel 'Magic.Switch.Board.Core.Enums.MidiChannel') |  |
| messageType | [Magic.Switch.Board.Core.Enums.MidiMessageType](#T-Magic-Switch-Board-Core-Enums-MidiMessageType 'Magic.Switch.Board.Core.Enums.MidiMessageType') |  |
| number | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='T-Magic-Switch-Board-Core-Models-Device-Base-InputOutputBase'></a>
## InputOutputBase `type`

##### Namespace

Magic.Switch.Board.Core.Models.Device.Base

##### Summary

The [InputOutputBase](#T-Magic-Switch-Board-Core-Models-Device-Base-InputOutputBase 'Magic.Switch.Board.Core.Models.Device.Base.InputOutputBase') class.

<a name='M-Magic-Switch-Board-Core-Models-Device-Base-InputOutputBase-#ctor'></a>
### #ctor() `constructor`

##### Summary

The empty [InputOutputBase](#T-Magic-Switch-Board-Core-Models-Device-Base-InputOutputBase 'Magic.Switch.Board.Core.Models.Device.Base.InputOutputBase') class constructor.

##### Parameters

This constructor has no parameters.

<a name='M-Magic-Switch-Board-Core-Models-Device-Base-InputOutputBase-#ctor-Magic-Switch-Board-Core-Enums-MidiChannel,Magic-Switch-Board-Core-Enums-MidiMessageType,System-Int32-'></a>
### #ctor(midiChannel,messageType,number) `constructor`

##### Summary

The standard [InputOutputBase](#T-Magic-Switch-Board-Core-Models-Device-Base-InputOutputBase 'Magic.Switch.Board.Core.Models.Device.Base.InputOutputBase') class constructor.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| midiChannel | [Magic.Switch.Board.Core.Enums.MidiChannel](#T-Magic-Switch-Board-Core-Enums-MidiChannel 'Magic.Switch.Board.Core.Enums.MidiChannel') |  |
| messageType | [Magic.Switch.Board.Core.Enums.MidiMessageType](#T-Magic-Switch-Board-Core-Enums-MidiMessageType 'Magic.Switch.Board.Core.Enums.MidiMessageType') |  |
| number | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='P-Magic-Switch-Board-Core-Models-Device-Base-InputOutputBase-MessageType'></a>
### MessageType `property`

##### Summary

The [MessageType](#P-Magic-Switch-Board-Core-Models-Device-Base-InputOutputBase-MessageType 'Magic.Switch.Board.Core.Models.Device.Base.InputOutputBase.MessageType') property

<a name='P-Magic-Switch-Board-Core-Models-Device-Base-InputOutputBase-MidiChannel'></a>
### MidiChannel `property`

##### Summary

The [MidiChannel](#P-Magic-Switch-Board-Core-Models-Device-Base-InputOutputBase-MidiChannel 'Magic.Switch.Board.Core.Models.Device.Base.InputOutputBase.MidiChannel') property

<a name='P-Magic-Switch-Board-Core-Models-Device-Base-InputOutputBase-Number'></a>
### Number `property`

##### Summary

The [Number](#P-Magic-Switch-Board-Core-Models-Device-Base-InputOutputBase-Number 'Magic.Switch.Board.Core.Models.Device.Base.InputOutputBase.Number') property

<a name='T-Magic-Switch-Board-Core-Models-Device-Loops'></a>
## Loops `type`

##### Namespace

Magic.Switch.Board.Core.Models.Device

##### Summary

The [Loops](#T-Magic-Switch-Board-Core-Models-Device-Loops 'Magic.Switch.Board.Core.Models.Device.Loops') class.

<a name='M-Magic-Switch-Board-Core-Models-Device-Loops-#ctor'></a>
### #ctor() `constructor`

##### Summary

The empty [Loops](#T-Magic-Switch-Board-Core-Models-Device-Loops 'Magic.Switch.Board.Core.Models.Device.Loops') class constructor.

##### Parameters

This constructor has no parameters.

<a name='M-Magic-Switch-Board-Core-Models-Device-Loops-#ctor-Magic-Switch-Board-Core-Enums-LoopChannels-'></a>
### #ctor(channels) `constructor`

##### Summary

The standard [Loops](#T-Magic-Switch-Board-Core-Models-Device-Loops 'Magic.Switch.Board.Core.Models.Device.Loops') class constructor.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| channels | [Magic.Switch.Board.Core.Enums.LoopChannels](#T-Magic-Switch-Board-Core-Enums-LoopChannels 'Magic.Switch.Board.Core.Enums.LoopChannels') |  |

<a name='P-Magic-Switch-Board-Core-Models-Device-Loops-Channels'></a>
### Channels `property`

##### Summary

The [Channels](#P-Magic-Switch-Board-Core-Models-Device-Loops-Channels 'Magic.Switch.Board.Core.Models.Device.Loops.Channels') property.

<a name='T-Magic-Switch-Board-Core-Models-Device-Output'></a>
## Output `type`

##### Namespace

Magic.Switch.Board.Core.Models.Device

##### Summary

The [Output](#T-Magic-Switch-Board-Core-Models-Device-Output 'Magic.Switch.Board.Core.Models.Device.Output') class.

##### Remarks

Inherits from the [InputOutputBase](#T-Magic-Switch-Board-Core-Models-Device-Base-InputOutputBase 'Magic.Switch.Board.Core.Models.Device.Base.InputOutputBase') class.

<a name='M-Magic-Switch-Board-Core-Models-Device-Output-#ctor'></a>
### #ctor() `constructor`

##### Summary

The empty [Output](#T-Magic-Switch-Board-Core-Models-Device-Output 'Magic.Switch.Board.Core.Models.Device.Output') class contructor.

##### Parameters

This constructor has no parameters.

<a name='M-Magic-Switch-Board-Core-Models-Device-Output-#ctor-Magic-Switch-Board-Core-Enums-MidiChannel,Magic-Switch-Board-Core-Enums-MidiMessageType,System-Int32-'></a>
### #ctor(midiChannel,messageType,number) `constructor`

##### Summary

The standard [Output](#T-Magic-Switch-Board-Core-Models-Device-Output 'Magic.Switch.Board.Core.Models.Device.Output') class constructor.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| midiChannel | [Magic.Switch.Board.Core.Enums.MidiChannel](#T-Magic-Switch-Board-Core-Enums-MidiChannel 'Magic.Switch.Board.Core.Enums.MidiChannel') |  |
| messageType | [Magic.Switch.Board.Core.Enums.MidiMessageType](#T-Magic-Switch-Board-Core-Enums-MidiMessageType 'Magic.Switch.Board.Core.Enums.MidiMessageType') |  |
| number | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

<a name='T-Magic-Switch-Board-Core-Properties-Resources'></a>
## Resources `type`

##### Namespace

Magic.Switch.Board.Core.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_LogLevel_Critical_Description'></a>
### Enum_LogLevel_Critical_Description `property`

##### Summary

Looks up a localized string similar to Logs that describe an unrecoverable application or system crash, or a catastrophic failure that requires immediate attention..

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_LogLevel_Critical_Name'></a>
### Enum_LogLevel_Critical_Name `property`

##### Summary

Looks up a localized string similar to Critical.

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_LogLevel_Debug_Description'></a>
### Enum_LogLevel_Debug_Description `property`

##### Summary

Looks up a localized string similar to Logs that are used for interactive investigation during development. These logs should primarily contain information useful for debugging and have no long-term value..

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_LogLevel_Debug_Name'></a>
### Enum_LogLevel_Debug_Name `property`

##### Summary

Looks up a localized string similar to Debug.

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_LogLevel_Error_Description'></a>
### Enum_LogLevel_Error_Description `property`

##### Summary

Looks up a localized string similar to Logs that highlight when the current flow of execution is stopped due to a failure. These should indicate a failure in the current activity, not an application-wide failure..

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_LogLevel_Error_Name'></a>
### Enum_LogLevel_Error_Name `property`

##### Summary

Looks up a localized string similar to Error.

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_LogLevel_Information_Description'></a>
### Enum_LogLevel_Information_Description `property`

##### Summary

Looks up a localized string similar to Logs that track the general flow of the application. These logs should have long-term value..

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_LogLevel_Information_Name'></a>
### Enum_LogLevel_Information_Name `property`

##### Summary

Looks up a localized string similar to Information.

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_LogLevel_None_Description'></a>
### Enum_LogLevel_None_Description `property`

##### Summary

Looks up a localized string similar to Not used for writing log messages. Specifies that a logging category should not write any messages..

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_LogLevel_None_Name'></a>
### Enum_LogLevel_None_Name `property`

##### Summary

Looks up a localized string similar to None.

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_LogLevel_Trace_Description'></a>
### Enum_LogLevel_Trace_Description `property`

##### Summary

Looks up a localized string similar to Logs that contain the most detailed messages. These messages may contain sensitive application data. These messages are disabled by default and should never be enabled in a production environment..

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_LogLevel_Trace_Name'></a>
### Enum_LogLevel_Trace_Name `property`

##### Summary

Looks up a localized string similar to Trace.

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_LogLevel_Warning_Description'></a>
### Enum_LogLevel_Warning_Description `property`

##### Summary

Looks up a localized string similar to Logs that highlight an abnormal or unexpected event in the application flow, but do not otherwise cause the application execution to stop..

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_LogLevel_Warning_Name'></a>
### Enum_LogLevel_Warning_Name `property`

##### Summary

Looks up a localized string similar to Warning.

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_LoopChannel_1_Name'></a>
### Enum_LoopChannel_1_Name `property`

##### Summary

Looks up a localized string similar to Loop Channel 1.

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_LoopChannel_2_Name'></a>
### Enum_LoopChannel_2_Name `property`

##### Summary

Looks up a localized string similar to Loop Channel 2.

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_LoopChannel_3_Name'></a>
### Enum_LoopChannel_3_Name `property`

##### Summary

Looks up a localized string similar to Loop Channel 3.

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_LoopChannel_4_Name'></a>
### Enum_LoopChannel_4_Name `property`

##### Summary

Looks up a localized string similar to Loop Channel 4.

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_LoopChannel_5_Name'></a>
### Enum_LoopChannel_5_Name `property`

##### Summary

Looks up a localized string similar to Loop Channel 5.

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_LoopChannel_6_Name'></a>
### Enum_LoopChannel_6_Name `property`

##### Summary

Looks up a localized string similar to Loop Channel 6.

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_LoopChannel_7_Name'></a>
### Enum_LoopChannel_7_Name `property`

##### Summary

Looks up a localized string similar to Loop Channel 7.

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_LoopChannel_8_Name'></a>
### Enum_LoopChannel_8_Name `property`

##### Summary

Looks up a localized string similar to Loop Channel 8.

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_MidiChannel_10_Name'></a>
### Enum_MidiChannel_10_Name `property`

##### Summary

Looks up a localized string similar to Midi Channel 10.

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_MidiChannel_11_Name'></a>
### Enum_MidiChannel_11_Name `property`

##### Summary

Looks up a localized string similar to Midi Channel 11.

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_MidiChannel_12_Name'></a>
### Enum_MidiChannel_12_Name `property`

##### Summary

Looks up a localized string similar to Midi Channel 12.

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_MidiChannel_13_Name'></a>
### Enum_MidiChannel_13_Name `property`

##### Summary

Looks up a localized string similar to Midi Channel 13.

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_MidiChannel_14_Name'></a>
### Enum_MidiChannel_14_Name `property`

##### Summary

Looks up a localized string similar to Midi Channel 14.

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_MidiChannel_15_Name'></a>
### Enum_MidiChannel_15_Name `property`

##### Summary

Looks up a localized string similar to Midi Channel 15.

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_MidiChannel_16_Name'></a>
### Enum_MidiChannel_16_Name `property`

##### Summary

Looks up a localized string similar to Midi Channel 16.

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_MidiChannel_1_Name'></a>
### Enum_MidiChannel_1_Name `property`

##### Summary

Looks up a localized string similar to Midi Channel 1.

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_MidiChannel_2_Name'></a>
### Enum_MidiChannel_2_Name `property`

##### Summary

Looks up a localized string similar to Midi Channel 2.

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_MidiChannel_3_Name'></a>
### Enum_MidiChannel_3_Name `property`

##### Summary

Looks up a localized string similar to Midi Channel 3.

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_MidiChannel_4_Name'></a>
### Enum_MidiChannel_4_Name `property`

##### Summary

Looks up a localized string similar to Midi Channel 4.

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_MidiChannel_5_Name'></a>
### Enum_MidiChannel_5_Name `property`

##### Summary

Looks up a localized string similar to Midi Channel 5.

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_MidiChannel_6_Name'></a>
### Enum_MidiChannel_6_Name `property`

##### Summary

Looks up a localized string similar to Midi Channel 6.

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_MidiChannel_7_Name'></a>
### Enum_MidiChannel_7_Name `property`

##### Summary

Looks up a localized string similar to Midi Channel 7.

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_MidiChannel_8_Name'></a>
### Enum_MidiChannel_8_Name `property`

##### Summary

Looks up a localized string similar to Midi Channel 8.

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_MidiChannel_9_Name'></a>
### Enum_MidiChannel_9_Name `property`

##### Summary

Looks up a localized string similar to Midi Channel 9.

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_MidiMessageType_CCM_Description'></a>
### Enum_MidiMessageType_CCM_Description `property`

##### Summary

Looks up a localized string similar to Control Change messages are usually used to change function parameters or call functions in your Midi devices..

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_MidiMessageType_CCM_Name'></a>
### Enum_MidiMessageType_CCM_Name `property`

##### Summary

Looks up a localized string similar to Control Change Message.

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_MidiMessageType_PCM_Description'></a>
### Enum_MidiMessageType_PCM_Description `property`

##### Summary

Looks up a localized string similar to The Program Change message is used to specify the type of instrument which should be used to play sounds on a given Channel..

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_MidiMessageType_PCM_Name'></a>
### Enum_MidiMessageType_PCM_Name `property`

##### Summary

Looks up a localized string similar to Program Change Message.

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_SwitchChannel_1_Name'></a>
### Enum_SwitchChannel_1_Name `property`

##### Summary

Looks up a localized string similar to Switch Channel 1.

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_SwitchChannel_2_Name'></a>
### Enum_SwitchChannel_2_Name `property`

##### Summary

Looks up a localized string similar to Switch Channel 2.

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_SwitchChannel_3_Name'></a>
### Enum_SwitchChannel_3_Name `property`

##### Summary

Looks up a localized string similar to Switch Channel 3.

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_SwitchChannel_4_Name'></a>
### Enum_SwitchChannel_4_Name `property`

##### Summary

Looks up a localized string similar to Switch Channel 4.

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_SwitchChannel_5_Name'></a>
### Enum_SwitchChannel_5_Name `property`

##### Summary

Looks up a localized string similar to Switch Channel 5.

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_SwitchChannel_6_Name'></a>
### Enum_SwitchChannel_6_Name `property`

##### Summary

Looks up a localized string similar to Switch Channel 6.

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_SwitchChannel_7_Name'></a>
### Enum_SwitchChannel_7_Name `property`

##### Summary

Looks up a localized string similar to Switch Channel 7.

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Enum_SwitchChannel_8_Name'></a>
### Enum_SwitchChannel_8_Name `property`

##### Summary

Looks up a localized string similar to Switch Channel 8.

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Error_While_Creating_A_New_Device_Configuration'></a>
### Error_While_Creating_A_New_Device_Configuration `property`

##### Summary

Looks up a localized string similar to Error while creating a new device configuration..

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Error_While_Creating_File'></a>
### Error_While_Creating_File `property`

##### Summary

Looks up a localized string similar to Error while creating file. '{0}'.

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Error_While_Deleting_File'></a>
### Error_While_Deleting_File `property`

##### Summary

Looks up a localized string similar to Error while deleting file. '{0}.

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Error_While_Fetching_Enum_List'></a>
### Error_While_Fetching_Enum_List `property`

##### Summary

Looks up a localized string similar to Error while fetching enum list..

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Error_While_Reading_A_Existing_Device_Configuration'></a>
### Error_While_Reading_A_Existing_Device_Configuration `property`

##### Summary

Looks up a localized string similar to Error while reading a existing device configuration..

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Error_While_Reading_File'></a>
### Error_While_Reading_File `property`

##### Summary

Looks up a localized string similar to Error while reading file. '{0}'.

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Error_While_Saving_Device_Configuration'></a>
### Error_While_Saving_Device_Configuration `property`

##### Summary

Looks up a localized string similar to Error while saving device configuration..

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Error_Xml_Unknown_Attribute'></a>
### Error_Xml_Unknown_Attribute `property`

##### Summary

Looks up a localized string similar to Error during deserialisation. Unkown attribute found. Name: '{0}' at line: {1} and position: {2}..

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Error_Xml_Unknown_Element'></a>
### Error_Xml_Unknown_Element `property`

##### Summary

Looks up a localized string similar to Error during deserialisation. Unkown element found. Name: '{0}' at line: {1} and position: {2}..

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Error_Xml_Unknown_Node'></a>
### Error_Xml_Unknown_Node `property`

##### Summary

Looks up a localized string similar to Error during deserialisation. Unkown node found. Name: '{0}' of type: '{1}'.

<a name='P-Magic-Switch-Board-Core-Properties-Resources-File_Service_Error_Directory'></a>
### File_Service_Error_Directory `property`

##### Summary

Looks up a localized string similar to The directory could not be found..

<a name='P-Magic-Switch-Board-Core-Properties-Resources-File_Service_Error_File'></a>
### File_Service_Error_File `property`

##### Summary

Looks up a localized string similar to The file could not be found..

<a name='P-Magic-Switch-Board-Core-Properties-Resources-File_Service_File_Created'></a>
### File_Service_File_Created `property`

##### Summary

Looks up a localized string similar to The file '{0}' was created..

<a name='P-Magic-Switch-Board-Core-Properties-Resources-File_Service_File_Deleted'></a>
### File_Service_File_Deleted `property`

##### Summary

Looks up a localized string similar to The file '{0}' has been deleted..

<a name='P-Magic-Switch-Board-Core-Properties-Resources-File_Service_File_Read'></a>
### File_Service_File_Read `property`

##### Summary

Looks up a localized string similar to The file '{0}' has been loaded..

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Model_Field_MaxLength_Generic'></a>
### Model_Field_MaxLength_Generic `property`

##### Summary

Looks up a localized string similar to {0} cannot be longer than {1} characters..

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Model_Field_Range_Generic'></a>
### Model_Field_Range_Generic `property`

##### Summary

Looks up a localized string similar to {0} must be in a range between {2} and {1}..

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Model_Field_Required_Generic'></a>
### Model_Field_Required_Generic `property`

##### Summary

Looks up a localized string similar to {0} is a required field..

<a name='P-Magic-Switch-Board-Core-Properties-Resources-Model_Field_StringLength_Generic'></a>
### Model_Field_StringLength_Generic `property`

##### Summary

Looks up a localized string similar to {0} must be between {2} and {1} characters long..

<a name='P-Magic-Switch-Board-Core-Properties-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='T-Magic-Switch-Board-Core-Exceptions-ServiceException'></a>
## ServiceException `type`

##### Namespace

Magic.Switch.Board.Core.Exceptions

##### Summary

The [ServiceException](#T-Magic-Switch-Board-Core-Exceptions-ServiceException 'Magic.Switch.Board.Core.Exceptions.ServiceException') class.

##### Remarks

This exception should only be thrown by services.

<a name='M-Magic-Switch-Board-Core-Exceptions-ServiceException-#ctor-System-String,System-Exception-'></a>
### #ctor(message,innerException) `constructor`

##### Summary

Initializes a new parameterless instance of the [ServiceException](#T-Magic-Switch-Board-Core-Exceptions-ServiceException 'Magic.Switch.Board.Core.Exceptions.ServiceException') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| message | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The exception message. |
| innerException | [System.Exception](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Exception 'System.Exception') | The inner exception. |

<a name='T-Magic-Switch-Board-Core-Statics'></a>
## Statics `type`

##### Namespace

Magic.Switch.Board.Core

##### Summary

The static [Statics](#T-Magic-Switch-Board-Core-Statics 'Magic.Switch.Board.Core.Statics') class.

<a name='P-Magic-Switch-Board-Core-Statics-AssemblyDirectory'></a>
### AssemblyDirectory `property`

##### Summary

The [AssemblyDirectory](#P-Magic-Switch-Board-Core-Statics-AssemblyDirectory 'Magic.Switch.Board.Core.Statics.AssemblyDirectory') property.

<a name='P-Magic-Switch-Board-Core-Statics-AssemblyName'></a>
### AssemblyName `property`

##### Summary

The [AssemblyName](#P-Magic-Switch-Board-Core-Statics-AssemblyName 'Magic.Switch.Board.Core.Statics.AssemblyName') property.

<a name='P-Magic-Switch-Board-Core-Statics-AssemblyVersion'></a>
### AssemblyVersion `property`

##### Summary

The [AssemblyVersion](#P-Magic-Switch-Board-Core-Statics-AssemblyVersion 'Magic.Switch.Board.Core.Statics.AssemblyVersion') property.

<a name='P-Magic-Switch-Board-Core-Statics-CurrentCulture'></a>
### CurrentCulture `property`

##### Summary

The [CurrentCulture](#P-Magic-Switch-Board-Core-Statics-CurrentCulture 'Magic.Switch.Board.Core.Statics.CurrentCulture') property.

<a name='P-Magic-Switch-Board-Core-Statics-DeviceConfigFileName'></a>
### DeviceConfigFileName `property`

##### Summary

The [DeviceConfigFileName](#P-Magic-Switch-Board-Core-Statics-DeviceConfigFileName 'Magic.Switch.Board.Core.Statics.DeviceConfigFileName') property.

<a name='P-Magic-Switch-Board-Core-Statics-LogFileName'></a>
### LogFileName `property`

##### Summary

The [LogFileName](#P-Magic-Switch-Board-Core-Statics-LogFileName 'Magic.Switch.Board.Core.Statics.LogFileName') property.

<a name='M-Magic-Switch-Board-Core-Statics-#cctor'></a>
### #cctor() `method`

##### Summary

The static [Statics](#T-Magic-Switch-Board-Core-Statics 'Magic.Switch.Board.Core.Statics') class constructor.

##### Parameters

This method has no parameters.

<a name='T-Magic-Switch-Board-Core-Helpers-StringWriterHelper'></a>
## StringWriterHelper `type`

##### Namespace

Magic.Switch.Board.Core.Helpers

##### Summary

*Inherit from parent.*

<a name='M-Magic-Switch-Board-Core-Helpers-StringWriterHelper-#ctor-System-Text-Encoding-'></a>
### #ctor(encoding) `constructor`

##### Summary

The [StringWriterHelper](#T-Magic-Switch-Board-Core-Helpers-StringWriterHelper 'Magic.Switch.Board.Core.Helpers.StringWriterHelper') class constructor.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| encoding | [System.Text.Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding 'System.Text.Encoding') |  |

<a name='P-Magic-Switch-Board-Core-Helpers-StringWriterHelper-Encoding'></a>
### Encoding `property`

##### Summary

*Inherit from parent.*

<a name='T-Magic-Switch-Board-Core-Models-Device-Switches'></a>
## Switches `type`

##### Namespace

Magic.Switch.Board.Core.Models.Device

##### Summary

The [Switches](#T-Magic-Switch-Board-Core-Models-Device-Switches 'Magic.Switch.Board.Core.Models.Device.Switches') class

<a name='M-Magic-Switch-Board-Core-Models-Device-Switches-#ctor'></a>
### #ctor() `constructor`

##### Summary

The empty [Switches](#T-Magic-Switch-Board-Core-Models-Device-Switches 'Magic.Switch.Board.Core.Models.Device.Switches') class constructor.

##### Parameters

This constructor has no parameters.

<a name='M-Magic-Switch-Board-Core-Models-Device-Switches-#ctor-Magic-Switch-Board-Core-Enums-SwitchChannels-'></a>
### #ctor(channels) `constructor`

##### Summary

The standard [Switches](#T-Magic-Switch-Board-Core-Models-Device-Switches 'Magic.Switch.Board.Core.Models.Device.Switches') class constructor.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| channels | [Magic.Switch.Board.Core.Enums.SwitchChannels](#T-Magic-Switch-Board-Core-Enums-SwitchChannels 'Magic.Switch.Board.Core.Enums.SwitchChannels') |  |

<a name='P-Magic-Switch-Board-Core-Models-Device-Switches-Channels'></a>
### Channels `property`

##### Summary

The [Channels](#P-Magic-Switch-Board-Core-Models-Device-Switches-Channels 'Magic.Switch.Board.Core.Models.Device.Switches.Channels') property

<a name='T-Magic-Switch-Board-Core-Helpers-XmlHelper`1'></a>
## XmlHelper\`1 `type`

##### Namespace

Magic.Switch.Board.Core.Helpers

##### Summary

The [XmlHelper\`1](#T-Magic-Switch-Board-Core-Helpers-XmlHelper`1 'Magic.Switch.Board.Core.Helpers.XmlHelper`1') class

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T |  |

<a name='M-Magic-Switch-Board-Core-Helpers-XmlHelper`1-#ctor'></a>
### #ctor() `constructor`

##### Summary

The [XmlHelper\`1](#T-Magic-Switch-Board-Core-Helpers-XmlHelper`1 'Magic.Switch.Board.Core.Helpers.XmlHelper`1') constructor

##### Parameters

This constructor has no parameters.

<a name='M-Magic-Switch-Board-Core-Helpers-XmlHelper`1-Deserialize-System-String-'></a>
### Deserialize(xmlString) `method`

##### Summary

The [Deserialize](#M-Magic-Switch-Board-Core-Helpers-XmlHelper`1-Deserialize-System-String- 'Magic.Switch.Board.Core.Helpers.XmlHelper`1.Deserialize(System.String)') method.

##### Returns

An object of the given type.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| xmlString | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |

##### Remarks

Calls the [Deserialize](#M-Magic-Switch-Board-Core-Helpers-XmlHelper`1-Deserialize-System-IO-TextReader- 'Magic.Switch.Board.Core.Helpers.XmlHelper`1.Deserialize(System.IO.TextReader)') method.
Will throw an exception if `xmlString` is `null`.

<a name='M-Magic-Switch-Board-Core-Helpers-XmlHelper`1-Deserialize-System-Xml-XmlDocument-'></a>
### Deserialize(xmlDocument) `method`

##### Summary

The [Deserialize](#M-Magic-Switch-Board-Core-Helpers-XmlHelper`1-Deserialize-System-Xml-XmlDocument- 'Magic.Switch.Board.Core.Helpers.XmlHelper`1.Deserialize(System.Xml.XmlDocument)') method.

##### Returns

An object of the given type.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| xmlDocument | [System.Xml.XmlDocument](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.XmlDocument 'System.Xml.XmlDocument') |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |

##### Remarks

Calls the [Deserialize](#M-Magic-Switch-Board-Core-Helpers-XmlHelper`1-Deserialize-System-IO-TextReader- 'Magic.Switch.Board.Core.Helpers.XmlHelper`1.Deserialize(System.IO.TextReader)') method.
Will throw an exception if `xmlDocument` is `null`.

<a name='M-Magic-Switch-Board-Core-Helpers-XmlHelper`1-Deserialize-System-IO-TextReader-'></a>
### Deserialize(textReader) `method`

##### Summary

The [Deserialize](#M-Magic-Switch-Board-Core-Helpers-XmlHelper`1-Deserialize-System-IO-TextReader- 'Magic.Switch.Board.Core.Helpers.XmlHelper`1.Deserialize(System.IO.TextReader)') method.

##### Returns

An object of the given type.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| textReader | [System.IO.TextReader](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.TextReader 'System.IO.TextReader') |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |

##### Remarks

The method does the actual deserialization process.
Will throw an exception if `textReader` is `null`.

<a name='M-Magic-Switch-Board-Core-Helpers-XmlHelper`1-OnUnknownAttribute-System-Object,System-Xml-Serialization-XmlAttributeEventArgs-'></a>
### OnUnknownAttribute(sender,e) `method`

##### Summary

The [OnUnknownAttribute](#M-Magic-Switch-Board-Core-Helpers-XmlHelper`1-OnUnknownAttribute-System-Object,System-Xml-Serialization-XmlAttributeEventArgs- 'Magic.Switch.Board.Core.Helpers.XmlHelper`1.OnUnknownAttribute(System.Object,System.Xml.Serialization.XmlAttributeEventArgs)') method.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Xml.Serialization.XmlAttributeEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Serialization.XmlAttributeEventArgs 'System.Xml.Serialization.XmlAttributeEventArgs') |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Xml.XmlException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.XmlException 'System.Xml.XmlException') |  |

##### Remarks

Occurs when the System.Xml.Serialization.XmlSerializer encounters an
XML attribute of unknown type during deserialization.

<a name='M-Magic-Switch-Board-Core-Helpers-XmlHelper`1-OnUnknownElement-System-Object,System-Xml-Serialization-XmlElementEventArgs-'></a>
### OnUnknownElement(sender,e) `method`

##### Summary

The [OnUnknownElement](#M-Magic-Switch-Board-Core-Helpers-XmlHelper`1-OnUnknownElement-System-Object,System-Xml-Serialization-XmlElementEventArgs- 'Magic.Switch.Board.Core.Helpers.XmlHelper`1.OnUnknownElement(System.Object,System.Xml.Serialization.XmlElementEventArgs)') method.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Xml.Serialization.XmlElementEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Serialization.XmlElementEventArgs 'System.Xml.Serialization.XmlElementEventArgs') |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Xml.XmlException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.XmlException 'System.Xml.XmlException') |  |

##### Remarks

Occurs when the System.Xml.Serialization.XmlSerializer encounters an 
XML element of unknown type during deserialization.

<a name='M-Magic-Switch-Board-Core-Helpers-XmlHelper`1-OnUnknownNode-System-Object,System-Xml-Serialization-XmlNodeEventArgs-'></a>
### OnUnknownNode(sender,e) `method`

##### Summary

The [OnUnknownNode](#M-Magic-Switch-Board-Core-Helpers-XmlHelper`1-OnUnknownNode-System-Object,System-Xml-Serialization-XmlNodeEventArgs- 'Magic.Switch.Board.Core.Helpers.XmlHelper`1.OnUnknownNode(System.Object,System.Xml.Serialization.XmlNodeEventArgs)') method.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sender | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| e | [System.Xml.Serialization.XmlNodeEventArgs](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Serialization.XmlNodeEventArgs 'System.Xml.Serialization.XmlNodeEventArgs') |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Xml.XmlException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.XmlException 'System.Xml.XmlException') |  |

##### Remarks

Occurs when the System.Xml.Serialization.XmlSerializer encounters an 
XML node of unknown type during deserialization.

<a name='M-Magic-Switch-Board-Core-Helpers-XmlHelper`1-Serialize-`0,System-Text-Encoding-'></a>
### Serialize(obj,encoding) `method`

##### Summary

The [Serialize](#M-Magic-Switch-Board-Core-Helpers-XmlHelper`1-Serialize-`0,System-Text-Encoding- 'Magic.Switch.Board.Core.Helpers.XmlHelper`1.Serialize(`0,System.Text.Encoding)') method.

##### Returns

An object of type [XmlDocument](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.XmlDocument 'System.Xml.XmlDocument')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [\`0](#T-`0 '`0') |  |
| encoding | [System.Text.Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding 'System.Text.Encoding') |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |

##### Remarks

Calls the [StringSerialize](#M-Magic-Switch-Board-Core-Helpers-XmlHelper`1-StringSerialize-`0,System-Text-Encoding- 'Magic.Switch.Board.Core.Helpers.XmlHelper`1.StringSerialize(`0,System.Text.Encoding)') method.
Will throw an exception if `obj` is `null`.

<a name='M-Magic-Switch-Board-Core-Helpers-XmlHelper`1-StringSerialize-`0,System-Text-Encoding-'></a>
### StringSerialize(obj,encoding) `method`

##### Summary

The [StringSerialize](#M-Magic-Switch-Board-Core-Helpers-XmlHelper`1-StringSerialize-`0,System-Text-Encoding- 'Magic.Switch.Board.Core.Helpers.XmlHelper`1.StringSerialize(`0,System.Text.Encoding)') method.

##### Returns

An object of type [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [\`0](#T-`0 '`0') |  |
| encoding | [System.Text.Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding 'System.Text.Encoding') |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |

##### Remarks

Calls the [WriterSerialize](#M-Magic-Switch-Board-Core-Helpers-XmlHelper`1-WriterSerialize-`0,System-Text-Encoding- 'Magic.Switch.Board.Core.Helpers.XmlHelper`1.WriterSerialize(`0,System.Text.Encoding)') method.
Will throw an exception if `obj` is `null`.

<a name='M-Magic-Switch-Board-Core-Helpers-XmlHelper`1-WriterSerialize-`0,System-Text-Encoding-'></a>
### WriterSerialize(obj,encoding) `method`

##### Summary

The [WriterSerialize](#M-Magic-Switch-Board-Core-Helpers-XmlHelper`1-WriterSerialize-`0,System-Text-Encoding- 'Magic.Switch.Board.Core.Helpers.XmlHelper`1.WriterSerialize(`0,System.Text.Encoding)') method.

##### Returns

An object of type [TextWriter](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.TextWriter 'System.IO.TextWriter')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [\`0](#T-`0 '`0') |  |
| encoding | [System.Text.Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding 'System.Text.Encoding') |  |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') |  |

##### Remarks

The method does the actual serialization process.
Since the encoding parameter can be [Nullable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Nullable 'System.Nullable'), it is set to [UTF8](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding.UTF8 'System.Text.Encoding.UTF8') here at the latest.
Will throw an exception if `obj` is `null`.
