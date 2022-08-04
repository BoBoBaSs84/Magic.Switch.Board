using System.ComponentModel;

namespace Configurator.Core
{
	public static class Enums
	{
		[Flags]
		public enum SwitchChannels
		{
			[Description("None Switch Channel is used")]
			None = 0,
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
			[Description("None Loop Channel is used")]
			None = 0,
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
			Ch1 = 1,
			Ch2 = 2,
			Ch3 = 3,
			Ch4 = 4,
			Ch5 = 5,
			Ch6 = 6,
			Ch7 = 7,
			Ch8 = 8,
			Ch9 = 9,
			Ch10 = 10,
			Ch11 = 11,
			Ch12 = 12,
			Ch13 = 13,
			Ch14 = 14,
			Ch15 = 15,
			Ch16 = 16
		}
	}
}
