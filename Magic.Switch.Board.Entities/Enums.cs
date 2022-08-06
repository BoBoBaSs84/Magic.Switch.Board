using System.ComponentModel;
using System.Reflection;

namespace Magic.Switch.Board.Entities;

/// <summary>
/// The <see cref="Enums"/> class
/// </summary>
public static class Enums
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
	[Flags]
	public enum SwitchChannels
	{
		[Description("Switch Channel 1")]
		Ch1 = 1,
		[Description("Switch Channel 2")]
		Ch2 = 2,
		[Description("Switch Channel 3")]
		Ch3 = 4,
		[Description("Switch Channel 4")]
		Ch4 = 8,
		[Description("Switch Channel 5")]
		Ch5 = 16,
		[Description("Switch Channel 6")]
		Ch6 = 32,
		[Description("Switch Channel 7")]
		Ch7 = 64,
		[Description("Switch Channel 8")]
		Ch8 = 128
	}
	[Flags]
	public enum LoopChannels
	{
		[Description("Loop Channel 1")]
		Ch1 = 1,
		[Description("Loop Channel 2")]
		Ch2 = 2,
		[Description("Loop Channel 3")]
		Ch3 = 4,
		[Description("Loop Channel 4")]
		Ch4 = 8,
		[Description("Loop Channel 5")]
		Ch5 = 16,
		[Description("Loop Channel 6")]
		Ch6 = 32,
		[Description("Loop Channel 7")]
		Ch7 = 64,
		[Description("Loop Channel 8")]
		Ch8 = 128
	}
	public enum MidiMessageType
	{
		[Description("Program Change Message")]
		PCM = 1,
		[Description("Control Change Message")]
		CCM = 2
	}
	public enum MidiChannel
	{
		[Description("Midi Channel 1")]
		Ch1 = 1,
		[Description("Midi Channel 2")]
		Ch2 = 2,
		[Description("Midi Channel 3")]
		Ch3 = 3,
		[Description("Midi Channel 4")]
		Ch4 = 4,
		[Description("Midi Channel 5")]
		Ch5 = 5,
		[Description("Midi Channel 6")]
		Ch6 = 6,
		[Description("Midi Channel 7")]
		Ch7 = 7,
		[Description("Midi Channel 8")]
		Ch8 = 8,
		[Description("Midi Channel 9")]
		Ch9 = 9,
		[Description("Midi Channel 10")]
		Ch10 = 10,
		[Description("Midi Channel 11")]
		Ch11 = 11,
		[Description("Midi Channel 12")]
		Ch12 = 12,
		[Description("Midi Channel 13")]
		Ch13 = 13,
		[Description("Midi Channel 14")]
		Ch14 = 14,
		[Description("Midi Channel 15")]
		Ch15 = 15,
		[Description("Midi Channel 16")]
		Ch16 = 16
	}
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
	/// <summary>
	/// The <see cref="GetDescription{T}(T)"/> extension method will try to get the <see cref="DescriptionAttribute"/> of an enum if used
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <param name="enumValue"></param>
	/// <returns><see cref="string"/> which can be <see cref="Nullable"/></returns>
	public static string GetDescription<T>(this T enumValue) where T : struct, IConvertible
	{
		FieldInfo? fieldInfo = enumValue.GetType().GetField(enumValue.ToString()!);

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
}