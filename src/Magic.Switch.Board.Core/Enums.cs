using System.ComponentModel.DataAnnotations;
using System.Reflection;

using Magic.Switch.Board.Core.Models;
using Magic.Switch.Board.Core.Properties;

using static Magic.Switch.Board.Core.Properties.Resources;

namespace Magic.Switch.Board.Core;

/// <summary>
/// The <see cref="Enums"/> class.
/// </summary>
/// <remarks>
/// The static class contains all enumerators required for the core component.
/// </remarks>
public static class Enums
{
	#region enums
	/// <summary>
	/// The <see cref="LogLevel"/> enums.
	/// </summary>
	public enum LogLevel
	{
		/// <summary>
		/// The <see cref="Trace"/> log level type enum.
		/// </summary>
		[Display(ResourceType = typeof(Resources),
			Name = nameof(Enum_LogLevel_Trace_Name),
			Description = nameof(Enum_LogLevel_Trace_Description))]
		Trace = 0,
		/// <summary>
		/// The <see cref="Debug"/> log level type enum.
		/// </summary>
		[Display(ResourceType = typeof(Resources),
			Name = nameof(Enum_LogLevel_Debug_Name),
			Description = nameof(Enum_LogLevel_Debug_Description))]
		Debug = 1,
		/// <summary>
		/// The <see cref="Information"/> log level type enum.
		/// </summary>
		[Display(ResourceType = typeof(Resources),
			Name = nameof(Enum_LogLevel_Information_Name),
			Description = nameof(Enum_LogLevel_Information_Description))]
		Information = 2,
		/// <summary>
		/// The <see cref="Warning"/> log level type enum.
		/// </summary>
		[Display(ResourceType = typeof(Resources),
			Name = nameof(Enum_LogLevel_Warning_Name),
			Description = nameof(Enum_LogLevel_Warning_Description))]
		Warning = 3,
		/// <summary>
		/// The <see cref="Error"/> log level type enum.
		/// </summary>
		[Display(ResourceType = typeof(Resources),
			Name = nameof(Enum_LogLevel_Error_Name),
			Description = nameof(Enum_LogLevel_Error_Description))]
		Error = 4,
		/// <summary>
		/// The <see cref="Critical"/> log level type enum.
		/// </summary>
		[Display(ResourceType = typeof(Resources),
			Name = nameof(Enum_LogLevel_Critical_Name),
			Description = nameof(Enum_LogLevel_Critical_Description))]
		Critical = 5,
		/// <summary>
		/// The <see cref="None"/> log level type enum.
		/// </summary>
		[Display(ResourceType = typeof(Resources),
			Name = nameof(Enum_LogLevel_None_Name),
			Description = nameof(Enum_LogLevel_None_Description))]
		None = 6
	}

	/// <summary>
	/// The <see cref="SwitchChannels"/> enums.
	/// </summary>
	[Flags]
	public enum SwitchChannels
	{
		/// <summary>
		/// The <see cref="CH01"/> enum is the "Switch Channel 1".
		/// </summary>
		[Display(ResourceType = typeof(Resources), Name = nameof(Enum_SwitchChannel_1_Name))]
		CH01 = 1,
		/// <summary>
		/// The <see cref="CH02"/> enum is the "Switch Channel 2".
		/// </summary>
		[Display(ResourceType = typeof(Resources), Name = nameof(Enum_SwitchChannel_2_Name))]
		CH02 = 2,
		/// <summary>
		/// The <see cref="CH03"/> enum is the "Switch Channel 3".
		/// </summary>
		[Display(ResourceType = typeof(Resources), Name = nameof(Enum_SwitchChannel_3_Name))]
		CH03 = 4,
		/// <summary>
		/// The <see cref="CH04"/> enum is the "Switch Channel 4".
		/// </summary>
		[Display(ResourceType = typeof(Resources), Name = nameof(Enum_SwitchChannel_4_Name))]
		CH04 = 8,
		/// <summary>
		/// The <see cref="CH05"/> enum is the "Switch Channel 5".
		/// </summary>
		[Display(ResourceType = typeof(Resources), Name = nameof(Enum_SwitchChannel_5_Name))]
		CH05 = 16,
		/// <summary>
		/// The <see cref="CH06"/> enum is the "Switch Channel 6".
		/// </summary>
		[Display(ResourceType = typeof(Resources), Name = nameof(Enum_SwitchChannel_6_Name))]
		CH06 = 32,
		/// <summary>
		/// The <see cref="CH07"/> enum is the "Switch Channel 7".
		/// </summary>
		[Display(ResourceType = typeof(Resources), Name = nameof(Enum_SwitchChannel_7_Name))]
		CH07 = 64,
		/// <summary>
		/// The <see cref="CH08"/> enum is the "Switch Channel 8".
		/// </summary>
		[Display(ResourceType = typeof(Resources), Name = nameof(Enum_SwitchChannel_8_Name))]
		CH08 = 128
	}

	/// <summary>
	/// The <see cref="LoopChannels"/> enums.
	/// </summary>
	[Flags]
	public enum LoopChannels
	{
		/// <summary>
		/// The <see cref="CH01"/> enum is the "Loop Channel 1".
		/// </summary>
		[Display(ResourceType = typeof(Resources), Name = nameof(Enum_LoopChannel_1_Name))]
		CH01 = 1,
		/// <summary>
		/// The <see cref="CH02"/> enum is the "Loop Channel 2".
		/// </summary>
		[Display(ResourceType = typeof(Resources), Name = nameof(Enum_LoopChannel_2_Name))]
		CH02 = 2,
		/// <summary>
		/// The <see cref="CH03"/> enum is the "Loop Channel 3".
		/// </summary>
		[Display(ResourceType = typeof(Resources), Name = nameof(Enum_LoopChannel_3_Name))]
		CH03 = 4,
		/// <summary>
		/// The <see cref="CH04"/> enum is the "Loop Channel 4".
		/// </summary>
		[Display(ResourceType = typeof(Resources), Name = nameof(Enum_LoopChannel_4_Name))]
		CH04 = 8,
		/// <summary>
		/// The <see cref="CH05"/> enum is the "Loop Channel 5".
		/// </summary>
		[Display(ResourceType = typeof(Resources), Name = nameof(Enum_LoopChannel_5_Name))]
		CH05 = 16,
		/// <summary>
		/// The <see cref="CH06"/> enum is the "Loop Channel 6".
		/// </summary>
		[Display(ResourceType = typeof(Resources), Name = nameof(Enum_LoopChannel_6_Name))]
		CH06 = 32,
		/// <summary>
		/// The <see cref="CH07"/> enum is the "Loop Channel 7".
		/// </summary>
		[Display(ResourceType = typeof(Resources), Name = nameof(Enum_LoopChannel_7_Name))]
		CH07 = 64,
		/// <summary>
		/// The <see cref="CH08"/> enum is the "Loop Channel 8".
		/// </summary>
		[Display(ResourceType = typeof(Resources), Name = nameof(Enum_LoopChannel_8_Name))]
		CH08 = 128
	}

	/// <summary>
	/// The <see cref="MidiMessageType"/> enums.
	/// </summary>
	public enum MidiMessageType
	{
		/// <summary>
		/// The <see cref="PCM"/> enum is the "Program Change Message".
		/// </summary>
		[Display(ResourceType = typeof(Resources),
			Name = nameof(Enum_MidiMessageType_PCM_Name),
			ShortName = nameof(Enum_MidiMessageType_PCM_ShortName),
			Description = nameof(Enum_MidiMessageType_PCM_Description))]
		PCM = 1,
		/// <summary>
		/// The <see cref="CCM"/> enum is the "Control Change Message".
		/// </summary>
		[Display(ResourceType = typeof(Resources),
			Name = nameof(Enum_MidiMessageType_CCM_Name),
			ShortName = nameof(Enum_MidiMessageType_CCM_ShortName),
			Description = nameof(Enum_MidiMessageType_CCM_Description))]
		CCM = 2
	}

	/// <summary>
	/// The <see cref="MidiChannel"/> enums.
	/// </summary>
	public enum MidiChannel
	{
		/// <summary>
		/// The <see cref="CH01"/> enum is the "Midi Channel 1".
		/// </summary>
		[Display(ResourceType = typeof(Resources), Name = nameof(Enum_MidiChannel_1_Name))]
		CH01 = 1,
		/// <summary>
		/// The <see cref="CH02"/> enum is the "Midi Channel 2".
		/// </summary>
		[Display(ResourceType = typeof(Resources), Name = nameof(Enum_MidiChannel_2_Name))]
		CH02 = 2,
		/// <summary>
		/// The <see cref="CH03"/> enum is the "Midi Channel 3".
		/// </summary>
		[Display(ResourceType = typeof(Resources), Name = nameof(Enum_MidiChannel_3_Name))]
		CH03 = 3,
		/// <summary>
		/// The <see cref="CH04"/> enum is the "Midi Channel 4".
		/// </summary>
		[Display(ResourceType = typeof(Resources), Name = nameof(Enum_MidiChannel_4_Name))]
		CH04 = 4,
		/// <summary>
		/// The <see cref="CH05"/> enum is the "Midi Channel 5".
		/// </summary>
		[Display(ResourceType = typeof(Resources), Name = nameof(Enum_MidiChannel_5_Name))]
		CH05 = 5,
		/// <summary>
		/// The <see cref="CH06"/> enum is the "Midi Channel 6".
		/// </summary>
		[Display(ResourceType = typeof(Resources), Name = nameof(Enum_MidiChannel_6_Name))]
		CH06 = 6,
		/// <summary>
		/// The <see cref="CH07"/> enum is the "Midi Channel 7".
		/// </summary>
		[Display(ResourceType = typeof(Resources), Name = nameof(Enum_MidiChannel_7_Name))]
		CH07 = 7,
		/// <summary>
		/// The <see cref="CH08"/> enum is the "Midi Channel 8".
		/// </summary>
		[Display(ResourceType = typeof(Resources), Name = nameof(Enum_MidiChannel_8_Name))]
		CH08 = 8,
		/// <summary>
		/// The <see cref="CH09"/> enum is the "Midi Channel 9".
		/// </summary>
		[Display(ResourceType = typeof(Resources), Name = nameof(Enum_MidiChannel_9_Name))]
		CH09 = 9,
		/// <summary>
		/// The <see cref="CH10"/> enum is the "Midi Channel 10".
		/// </summary>
		[Display(ResourceType = typeof(Resources), Name = nameof(Enum_MidiChannel_10_Name))]
		CH10 = 10,
		/// <summary>
		/// The <see cref="CH11"/> enum is the "Midi Channel 11".
		/// </summary>
		[Display(ResourceType = typeof(Resources), Name = nameof(Enum_MidiChannel_11_Name))]
		CH11 = 11,
		/// <summary>
		/// The <see cref="CH12"/> enum is the "Midi Channel 12".
		/// </summary>
		[Display(ResourceType = typeof(Resources), Name = nameof(Enum_MidiChannel_12_Name))]
		CH12 = 12,
		/// <summary>
		/// The <see cref="CH13"/> enum is the "Midi Channel 13".
		/// </summary>
		[Display(ResourceType = typeof(Resources), Name = nameof(Enum_MidiChannel_13_Name))]
		CH13 = 13,
		/// <summary>
		/// The <see cref="CH14"/> enum is the "Midi Channel 14".
		/// </summary>
		[Display(ResourceType = typeof(Resources), Name = nameof(Enum_MidiChannel_14_Name))]
		CH14 = 14,
		/// <summary>
		/// The <see cref="CH15"/> enum is the "Midi Channel 15".
		/// </summary>
		[Display(ResourceType = typeof(Resources), Name = nameof(Enum_MidiChannel_15_Name))]
		CH15 = 15,
		/// <summary>
		/// The <see cref="CH16"/> enum is the "Midi Channel 16".
		/// </summary>
		[Display(ResourceType = typeof(Resources), Name = nameof(Enum_MidiChannel_16_Name))]
		CH16 = 16
	}
	#endregion

	#region enum extension methods
	/// <summary>
	/// The <see cref="GetEnumDescription{T}(T)"/> extension method will try to get the <see cref="DisplayAttribute.Description"/>.
	/// </summary>
	/// <remarks>
	/// The <see cref="DisplayAttribute.GetDescription"/> method is used, so strings will be returned localized.
	/// </remarks>
	/// <typeparam name="T">The enmuerator itself.</typeparam>
	/// <param name="enumValue">The value of the enumerator.</param>
	/// <returns>The <see cref="DisplayAttribute.Description"/> or the <paramref name="enumValue"/> as string.</returns>
	public static string GetEnumDescription<T>(this T enumValue) where T : Enum
	{
		DisplayAttribute? attribute = enumValue.GetDisplayAttribute();
		return attribute is not null ? attribute.GetDescription() ?? enumValue.ToString() : enumValue.ToString();
	}

	/// <summary>
	/// The <see cref="GetEnumName{T}(T)"/> extension method will try to get the <see cref="DisplayAttribute.Name"/>.
	/// </summary>
	/// <remarks>
	/// The <see cref="DisplayAttribute.GetName"/> method is used, so strings will be returned localized.
	/// </remarks>
	/// <typeparam name="T">The enmuerator itself.</typeparam>
	/// <param name="enumValue">The value of the enumerator.</param>
	/// <returns>The <see cref="DisplayAttribute.Name"/> or the <paramref name="enumValue"/> as string.</returns>
	public static string GetEnumName<T>(this T enumValue) where T : Enum
	{
		DisplayAttribute? attribute = enumValue.GetDisplayAttribute();
		return attribute is not null ? attribute.GetName() ?? enumValue.ToString() : enumValue.ToString();
	}

	/// <summary>
	/// The <see cref="GetEnumShortName{T}(T)"/> extension method will try to get the <see cref="DisplayAttribute.ShortName"/>.
	/// </summary>
	/// <remarks>
	/// The <see cref="DisplayAttribute.GetShortName"/> method is used, so strings will be returned localized.
	/// </remarks>
	/// <typeparam name="T">The enmuerator itself.</typeparam>
	/// <param name="enumValue">The value of the enumerator.</param>
	/// <returns>The <see cref="DisplayAttribute.ShortName"/> or the <paramref name="enumValue"/> as string.</returns>
	public static string GetEnumShortName<T>(this T enumValue) where T : Enum
	{
		DisplayAttribute? attribute = enumValue.GetDisplayAttribute();
		return attribute is not null ? attribute.GetShortName() ?? enumValue.ToString() : enumValue.ToString();
	}

	/// <summary>
	/// The <see cref="FlagsToList{T}(T)"/> extension method returns a <see cref="List{T}"/>
	/// </summary>
	/// <typeparam name="T">The enmuerator itself.</typeparam>
	/// <param name="enumFlags"></param>
	/// <returns>A <see cref="List{T}"/> of the provided enum flags.</returns>
	public static List<T> FlagsToList<T>(this T enumFlags) where T : Enum
	{
		List<T> list = [];
		foreach (T flagToCheck in Enum.GetValues(typeof(T)))
			if (enumFlags.HasFlag(flagToCheck))
				list.Add(flagToCheck);
		return list;
	}

	/// <summary>
	/// The <see cref="GetListFromEnum{T}(T)"/> method should return a list of all enumerators of the given type of enum.
	/// </summary>
	/// <typeparam name="T">The enmuerator itself.</typeparam>
	/// <param name="enumValue">The value of the enumerator.</param>
	/// <returns>A list of all enums of the provided type.</returns>
	public static List<T> GetListFromEnum<T>(this T enumValue) where T : Enum
		=> Enum.GetValues(enumValue.GetType()).Cast<T>().ToList();

	/// <summary>
	/// The <see cref="GetEnumsWithDescription{T}(T)"/> method should return a dictornary with enums and their description.
	/// </summary>
	/// <remarks>
	/// If the enum has no description property, the enum name will be returned.
	/// </remarks>
	/// <typeparam name="T">The enmuerator itself.</typeparam>
	/// <param name="enumValue">The value of the enumerator.</param>
	/// <returns>A dictionary with enums and their description.</returns>
	public static Dictionary<T, string> GetEnumsWithDescription<T>(this T enumValue) where T : Enum
	{
		List<T> enumList = Enum.GetValues(enumValue.GetType()).Cast<T>().ToList();
		Dictionary<T, string> dictToReturn = [];
		foreach (T e in enumList)
			dictToReturn.Add(e, e.GetEnumDescription());
		return dictToReturn;
	}

	/// <summary>
	/// The <see cref="GetDisplayAttribute{T}(T)"/> method should return the <see cref="DisplayAttribute"/> from the enum.
	/// </summary>
	/// <remarks>
	/// Will return null if the enum is not decorated with the <see cref="DisplayAttribute"/>.
	/// </remarks>
	/// <typeparam name="T">The enmuerator itself.</typeparam>
	/// <param name="enumValue">The value of the enumerator.</param>
	/// <returns>The <see cref="DisplayAttribute"/> or <see langword="null"/>.</returns>
	private static DisplayAttribute? GetDisplayAttribute<T>(this T enumValue) where T : Enum
	{
		FieldInfo? fieldInfo = enumValue.GetType().GetField(enumValue.ToString());
		return fieldInfo is not null ? fieldInfo.GetCustomAttribute<DisplayAttribute>() : default;
	}

	/// <summary>
	/// The <see cref="GetEnumModelList{T}(T)"/> should return a list of the <see cref="EnumModel{T}"/>.
	/// </summary>
	/// <typeparam name="T">The enmuerator itself.</typeparam>
	/// <param name="enumValue">The value of the enumerator.</param>
	/// <returns>A list of type <see cref="EnumModel{T}"/></returns>
	public static List<EnumModel<T>> GetEnumModelList<T>(this T enumValue) where T : Enum
	{
		List<T> enumList = Enum.GetValues(enumValue.GetType()).Cast<T>().ToList();
		List<EnumModel<T>> listToReturn = [];
		foreach (T e in enumList)
		{
			EnumModel<T> em = new(e, e.GetEnumName(), e.GetEnumShortName(), e.GetEnumDescription());
			listToReturn.Add(em);
		}
		return listToReturn;
	}
	#endregion
}
