using Configurator.Core.Models.Device.Base;
using System.Xml.Serialization;

namespace Configurator.Core.Models.Device
{
	/// <summary>
	/// The <see cref="Input"/> class
	/// </summary>
	[XmlRoot(ElementName = nameof(Input), IsNullable = false)]
	public class Input : InputOutputBase
	{
		/// <summary>
		/// The empty <see cref="Input"/> contructor
		/// </summary>
		public Input()
		{
			MidiChannel = Enums.MidiChannel.Ch1;
			MessageType = Enums.MidiMessageType.PCM;
			Number = default;
		}

		/// <summary>
		/// The <see cref="Input"/> constructor
		/// </summary>
		/// <param name="midiChannel"></param>
		/// <param name="messageType"></param>
		/// <param name="number"></param>
		public Input(Enums.MidiChannel midiChannel, Enums.MidiMessageType messageType, int number)
		{
			MidiChannel = midiChannel;
			MessageType = messageType;
			Number = number;
		}
	}
}
