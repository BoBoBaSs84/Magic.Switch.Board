using Magic.Switch.Board.Core.Properties;
using System.ComponentModel;
using System.Reflection;

namespace Magic.Switch.Board.Core;

/// <summary>
/// The <see cref="Enums"/> class
/// </summary>
public static class Enums
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	public enum LogLevel
	{
		[LocalizedDescription("Enum_LogLevel_Trace_Description")]
		Trace = 0,
		[LocalizedDescription("Enum_LogLevel_Debug_Description")]
		Debug = 1,
		[LocalizedDescription("Enum_LogLevel_Information_Description")]
		Information = 2,
		[LocalizedDescription("Enum_LogLevel_Warning_Description")]
		Warning = 3,
		[LocalizedDescription("Enum_LogLevel_Error_Description")]
		Error = 4,
		[LocalizedDescription("Enum_LogLevel_Critical_Description")]
		Critical = 5,
		[LocalizedDescription("Enum_LogLevel_None_Description")]
		None = 6
	}

	[Flags]
	public enum SwitchChannels
	{
		[LocalizedDescription("Enum_SwitchChannels_1")]
		Ch1 = 1,
		[LocalizedDescription("Enum_SwitchChannels_2")]
		Ch2 = 2,
		[LocalizedDescription("Enum_SwitchChannels_3")]
		Ch3 = 4,
		[LocalizedDescription("Enum_SwitchChannels_4")]
		Ch4 = 8,
		[LocalizedDescription("Enum_SwitchChannels_5")]
		Ch5 = 16,
		[LocalizedDescription("Enum_SwitchChannels_6")]
		Ch6 = 32,
		[LocalizedDescription("Enum_SwitchChannels_7")]
		Ch7 = 64,
		[LocalizedDescription("Enum_SwitchChannels_8")]
		Ch8 = 128
	}

	[Flags]
	public enum LoopChannels
	{
		[LocalizedDescription("Enum_LoopChannels_1")]
		Ch1 = 1,
		[LocalizedDescription("Enum_LoopChannels_2")]
		Ch2 = 2,
		[LocalizedDescription("Enum_LoopChannels_3")]
		Ch3 = 4,
		[LocalizedDescription("Enum_LoopChannels_4")]
		Ch4 = 8,
		[LocalizedDescription("Enum_LoopChannels_5")]
		Ch5 = 16,
		[LocalizedDescription("Enum_LoopChannels_6")]
		Ch6 = 32,
		[LocalizedDescription("Enum_LoopChannels_7")]
		Ch7 = 64,
		[LocalizedDescription("Enum_LoopChannels_8")]
		Ch8 = 128
	}

	public enum MidiMessageType
	{
		[LocalizedDescription("Enum_MidiMessageType_PCM")]
		PCM = 1,
		[LocalizedDescription("Enum_MidiMessageType_CCM")]
		CCM = 2
	}

	public enum MidiChannel
	{
		[Description("Enum_MidiChannel_1")]
		Ch1 = 1,
		[Description("Enum_MidiChannel_2")]
		Ch2 = 2,
		[Description("Enum_MidiChannel_3")]
		Ch3 = 3,
		[Description("Enum_MidiChannel_4")]
		Ch4 = 4,
		[Description("Enum_MidiChannel_5")]
		Ch5 = 5,
		[Description("Enum_MidiChannel_6")]
		Ch6 = 6,
		[Description("Enum_MidiChannel_7")]
		Ch7 = 7,
		[Description("Enum_MidiChannel_8")]
		Ch8 = 8,
		[Description("Enum_MidiChannel_9")]
		Ch9 = 9,
		[Description("Enum_MidiChannel_10")]
		Ch10 = 10,
		[Description("Enum_MidiChannel_11")]
		Ch11 = 11,
		[Description("Enum_MidiChannel_12")]
		Ch12 = 12,
		[Description("Enum_MidiChannel_13")]
		Ch13 = 13,
		[Description("Enum_MidiChannel_14")]
		Ch14 = 14,
		[Description("Enum_MidiChannel_15")]
		Ch15 = 15,
		[Description("Enum_MidiChannel_16")]
		Ch16 = 16
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	/// <summary>
	/// The <see cref="GetDescription{T}(T)"/> extension method will try to get the <see cref="DescriptionAttribute"/> of an enum if used
	/// </summary>
	/// <remarks>
	/// If the enum has no description property, the enum name will be returned.
	/// </remarks>
	/// <typeparam name="T"></typeparam>
	/// <param name="enumValue"></param>
	/// <returns><see cref="string"/> which can be <see cref="Nullable"/></returns>
	public static string GetDescription<T>(this T enumValue) where T : Enum, IConvertible
	{
		FieldInfo? fieldInfo = enumValue.GetType().GetField(enumValue.ToString());

		if (fieldInfo is not null)
		{
			DescriptionAttribute[]? attributes = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];
			if (attributes is not null && attributes.Length > 0)
				return attributes[0].Description;
		}
		return enumValue.ToString();
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
	public static List<T> GetListFromEnum<T>(this T @enum) where T : Enum
		=> Enum.GetValues(@enum.GetType()).Cast<T>().ToList();

	/// <summary>
	/// The <see cref="GetEnumsWithDescription{T}(T)"/> method should return a dictornary with enums and their description.
	/// </summary>
	/// <remarks>
	/// If the enum has no description property, the enum name will be returned.
	/// </remarks>
	/// <typeparam name="T"></typeparam>
	/// <param name="enum"></param>
	/// <returns>A dictionary with enums and their description.</returns>
	public static Dictionary<T, string> GetEnumsWithDescription<T>(this T @enum) where T : Enum, IConvertible
	{
		List<T> enumList = Enum.GetValues(@enum.GetType()).Cast<T>().ToList();
		Dictionary<T, string> dictToReturn = new();
		foreach (T e in enumList)
			dictToReturn.Add(e, e.GetDescription());
		return dictToReturn;
	}

	/// <summary>
	/// The <see cref="LocalizedDescriptionAttribute"/> class.
	/// </summary>	
	private class LocalizedDescriptionAttribute : DescriptionAttribute
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="LocalizedDescriptionAttribute"/> class.
		/// </summary>
		/// <param name="resKey">The resource key to look up.</param>
		public LocalizedDescriptionAttribute(string resKey) : base(Localize(resKey))
		{
		}

		/// <summary>
		/// The <see cref="Localize(string)"/> method will try to find the localized string for the <paramref name="resKey"/>.
		/// </summary>
		/// <param name="resKey"></param>
		/// <returns>The localized looked up string.</returns>
		private static string Localize(string resKey)
		{
			string stringToReturn = Resources.ResourceManager.GetString(resKey, Resources.Culture)!;
			return stringToReturn ?? "Not found.";
		}
	}
}