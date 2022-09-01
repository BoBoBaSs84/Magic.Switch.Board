using Magic.Switch.Board.Core.Models;
using Magic.Switch.Board.Core.Properties;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using static Magic.Switch.Board.Core.Properties.Resources;

namespace Magic.Switch.Board.Core;

/// <summary>
/// The <see cref="Enums"/> class.
/// </summary>
public static class Enums
{
	#region enums
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	public enum LogLevel
	{
		[Display(ResourceType = typeof(Resources),
			Name = nameof(Enum_LogLevel_Trace_Name),
			Description = nameof(Enum_LogLevel_Trace_Description))]
		Trace = 0,
		[Display(ResourceType = typeof(Resources),
			Name = nameof(Enum_LogLevel_Debug_Name),
			Description = nameof(Enum_LogLevel_Debug_Description))]
		Debug = 1,
		[Display(ResourceType = typeof(Resources),
			Name = nameof(Enum_LogLevel_Information_Name),
			Description = nameof(Enum_LogLevel_Information_Description))]
		Information = 2,
		[Display(ResourceType = typeof(Resources),
			Name = nameof(Enum_LogLevel_Warning_Name),
			Description = nameof(Enum_LogLevel_Warning_Description))]
		Warning = 3,
		[Display(ResourceType = typeof(Resources),
			Name = nameof(Enum_LogLevel_Error_Name),
			Description = nameof(Enum_LogLevel_Error_Description))]
		Error = 4,
		[Display(ResourceType = typeof(Resources),
			Name = nameof(Enum_LogLevel_Critical_Name),
			Description = nameof(Enum_LogLevel_Critical_Description))]
		Critical = 5,
		[Display(ResourceType = typeof(Resources),
			Name = nameof(Enum_LogLevel_None_Name),
			Description = nameof(Enum_LogLevel_None_Description))]
		None = 6
	}

	[Flags]
	public enum SwitchChannels
	{
		[Display(ResourceType = typeof(Resources),
			Name = nameof(Enum_SwitchChannel_1_Name))]
		CH01 = 1,
		[Display(ResourceType = typeof(Resources),
			Name = nameof(Enum_SwitchChannel_2_Name))]
		CH02 = 2,
		[Display(ResourceType = typeof(Resources),
			Name = nameof(Enum_SwitchChannel_3_Name))]
		CH03 = 4,
		[Display(ResourceType = typeof(Resources),
			Name = nameof(Enum_SwitchChannel_4_Name))]
		CH04 = 8,
		[Display(ResourceType = typeof(Resources),
			Name = nameof(Enum_SwitchChannel_5_Name))]
		CH05 = 16,
		[Display(ResourceType = typeof(Resources),
			Name = nameof(Enum_SwitchChannel_6_Name))]
		CH06 = 32,
		[Display(ResourceType = typeof(Resources),
			Name = nameof(Enum_SwitchChannel_7_Name))]
		CH07 = 64,
		[Display(ResourceType = typeof(Resources),
			Name = nameof(Enum_SwitchChannel_8_Name))]
		CH08 = 128
	}

	[Flags]
	public enum LoopChannels
	{
		[Display(ResourceType = typeof(Resources),
			Name = nameof(Enum_LoopChannel_1_Name))]
		CH01 = 1,
		[Display(ResourceType = typeof(Resources),
			Name = nameof(Enum_LoopChannel_2_Name))]
		CH02 = 2,
		[Display(ResourceType = typeof(Resources),
			Name = nameof(Enum_LoopChannel_3_Name))]
		CH03 = 4,
		[Display(ResourceType = typeof(Resources),
			Name = nameof(Enum_LoopChannel_4_Name))]
		CH04 = 8,
		[Display(ResourceType = typeof(Resources),
			Name = nameof(Enum_LoopChannel_5_Name))]
		CH05 = 16,
		[Display(ResourceType = typeof(Resources),
			Name = nameof(Enum_LoopChannel_6_Name))]
		CH06 = 32,
		[Display(ResourceType = typeof(Resources),
			Name = nameof(Enum_LoopChannel_7_Name))]
		CH07 = 64,
		[Display(ResourceType = typeof(Resources),
			Name = nameof(Enum_LoopChannel_8_Name))]
		CH08 = 128
	}

	public enum MidiMessageType
	{
		[Display(ResourceType = typeof(Resources),
			Name = nameof(Enum_MidiMessageType_PCM_Name),
			Description = nameof(Enum_MidiMessageType_PCM_Description))]
		PCM = 1,
		[Display(ResourceType = typeof(Resources),
			Name = nameof(Enum_MidiMessageType_CCM_Name),
			Description = nameof(Enum_MidiMessageType_CCM_Description))]
		CCM = 2
	}

	public enum MidiChannel
	{
		[Display(ResourceType = typeof(Resources), Name = nameof(Enum_MidiChannel_1_Name))]
		CH01 = 1,
		[Display(ResourceType = typeof(Resources), Name = nameof(Enum_MidiChannel_2_Name))]
		CH02 = 2,
		[Display(ResourceType = typeof(Resources), Name = nameof(Enum_MidiChannel_3_Name))]
		CH03 = 3,
		[Display(ResourceType = typeof(Resources), Name = nameof(Enum_MidiChannel_4_Name))]
		CH04 = 4,
		[Display(ResourceType = typeof(Resources), Name = nameof(Enum_MidiChannel_5_Name))]
		CH05 = 5,
		[Display(ResourceType = typeof(Resources), Name = nameof(Enum_MidiChannel_6_Name))]
		CH06 = 6,
		[Display(ResourceType = typeof(Resources), Name = nameof(Enum_MidiChannel_7_Name))]
		CH07 = 7,
		[Display(ResourceType = typeof(Resources), Name = nameof(Enum_MidiChannel_8_Name))]
		CH08 = 8,
		[Display(ResourceType = typeof(Resources), Name = nameof(Enum_MidiChannel_9_Name))]
		CH09 = 9,
		[Display(ResourceType = typeof(Resources), Name = nameof(Enum_MidiChannel_10_Name))]
		CH10 = 10,
		[Display(ResourceType = typeof(Resources), Name = nameof(Enum_MidiChannel_11_Name))]
		CH11 = 11,
		[Display(ResourceType = typeof(Resources), Name = nameof(Enum_MidiChannel_12_Name))]
		CH12 = 12,
		[Display(ResourceType = typeof(Resources), Name = nameof(Enum_MidiChannel_13_Name))]
		CH13 = 13,
		[Display(ResourceType = typeof(Resources), Name = nameof(Enum_MidiChannel_14_Name))]
		CH14 = 14,
		[Display(ResourceType = typeof(Resources), Name = nameof(Enum_MidiChannel_15_Name))]
		CH15 = 15,
		[Display(ResourceType = typeof(Resources), Name = nameof(Enum_MidiChannel_16_Name))]
		CH16 = 16
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	#endregion

	#region enum extension methods
	/// <summary>
	/// The <see cref="GetEnumDescription{T}(T)"/> extension method will try to get the <see cref="DisplayAttribute.Description"/>.
	/// </summary>
	/// <remarks>
	/// The <see cref="DisplayAttribute.GetDescription"/> method is used, so strings will be returned localized.
	/// </remarks>
	/// <typeparam name="T"></typeparam>
	/// <param name="enumValue"></param>
	/// <returns>The <see cref="DisplayAttribute.Description"/> or the <paramref name="enumValue"/> as string.</returns>
	public static string GetEnumDescription<T>(this T enumValue) where T : Enum, IConvertible
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
	/// <typeparam name="T"></typeparam>
	/// <param name="enumValue"></param>
	/// <returns>The <see cref="DisplayAttribute.Name"/> or the <paramref name="enumValue"/> as string.</returns>
	public static string GetEnumName<T>(this T enumValue) where T : Enum, IConvertible
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
	/// <typeparam name="T"></typeparam>
	/// <param name="enumValue"></param>
	/// <returns>The <see cref="DisplayAttribute.ShortName"/> or the <paramref name="enumValue"/> as string.</returns>
	public static string GetEnumShortName<T>(this T enumValue) where T : Enum, IConvertible
	{
		DisplayAttribute? attribute = enumValue.GetDisplayAttribute();
		return attribute is not null ? attribute.GetShortName() ?? enumValue.ToString() : enumValue.ToString();
	}

	/// <summary>
	/// The <see cref="FlagsToList{T}(T)"/> extension method returns a <see cref="List{T}"/>
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="enumFlags"></param>
	/// <returns>A <see cref="List{T}"/> of the provided enum flags.</returns>
	public static List<T> FlagsToList<T>(this T enumFlags) where T : Enum, IConvertible
	{
		List<T> list = new();
		foreach (T flagToCheck in Enum.GetValues(typeof(T)))
			if (enumFlags.HasFlag(flagToCheck))
				list.Add(flagToCheck);
		return list;
	}

	/// <summary>
	/// The <see cref="GetListFromEnum{T}(T)"/> method should return a list of all enumerators of the given type of enum.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <returns>A <see cref="List{T}"/> of the provided enum.</returns>
	public static List<T> GetListFromEnum<T>(this T enumValue) where T : Enum
		=> Enum.GetValues(enumValue.GetType()).Cast<T>().ToList();

	/// <summary>
	/// The <see cref="GetEnumsWithDescription{T}(T)"/> method should return a dictornary with enums and their description.
	/// </summary>
	/// <remarks>
	/// If the enum has no description property, the enum name will be returned.
	/// </remarks>
	/// <typeparam name="T"></typeparam>
	/// <param name="enumValue"></param>
	/// <returns>A dictionary with enums and their description.</returns>
	public static Dictionary<T, string> GetEnumsWithDescription<T>(this T enumValue) where T : Enum, IConvertible
	{
		List<T> enumList = Enum.GetValues(enumValue.GetType()).Cast<T>().ToList();
		Dictionary<T, string> dictToReturn = new();
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
	/// <typeparam name="T"></typeparam>
	/// <param name="enumValue">The enum.</param>
	/// <returns>The <see cref="DisplayAttribute"/> or <see langword="null"/>.</returns>
	private static DisplayAttribute? GetDisplayAttribute<T>(this T enumValue) where T : Enum, IConvertible
	{
		FieldInfo? fieldInfo = enumValue.GetType().GetField(enumValue.ToString());
		return fieldInfo is not null ? fieldInfo.GetCustomAttribute<DisplayAttribute>() : default;
	}

	/// <summary>
	/// The <see cref="GetEnumModelList{T}(T)"/> should return a list of the <see cref="EnumModel{T}"/>.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="enumValue">The enum.</param>
	/// <returns>A list of type <see cref="EnumModel{T}"/></returns>
	public static List<EnumModel<T>> GetEnumModelList<T>(this T enumValue) where T : Enum, IConvertible
	{
		List<T> enumList = Enum.GetValues(enumValue.GetType()).Cast<T>().ToList();
		List<EnumModel<T>> listToReturn = new();
		foreach (T e in enumList)
		{
			EnumModel<T> em = new(e, e.GetEnumName(), e.GetEnumShortName(), e.GetEnumDescription());
			listToReturn.Add(em);
		}
		return listToReturn;
	}
	#endregion
}
