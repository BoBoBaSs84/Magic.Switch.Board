using Configurator.Core.Models.Device.Base;
using System.Xml.Serialization;

namespace Configurator.Core.Models.Device
{
	/// <summary>
	/// The <see cref="Output"/> class
	/// </summary>
	[XmlRoot(ElementName = nameof(Output), IsNullable = false)]
	public class Output : InputOutputBase
	{
		/// <summary>
		/// The empty <see cref="Output"/> contructor
		/// </summary>
		public Output()
		{
			MidiChannel = Enums.MidiChannel.Ch1;
			MessageType = Enums.MidiMessageType.PCM;
			Number = default;
		}

		/// <summary>
		/// The <see cref="Output"/> constructor
		/// </summary>
		/// <param name="midiChannel"></param>
		/// <param name="messageType"></param>
		/// <param name="number"></param>
		public Output(Enums.MidiChannel midiChannel, Enums.MidiMessageType messageType, int number)
		{
			Number = number;
			MidiChannel = midiChannel;
			MessageType = messageType;
		}
	}
}
