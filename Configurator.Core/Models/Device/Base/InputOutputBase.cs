using System.Xml.Serialization;

namespace Configurator.Core.Models.Device.Base
{
	/// <summary>
	/// The <see cref="InputOutputBase"/> class
	/// </summary>
	public abstract class InputOutputBase
	{
		/// <summary>
		/// The <see cref="MidiChannel"/> property
		/// </summary>
		[XmlAttribute(AttributeName = nameof(MidiChannel))]
		public Enums.MidiChannel MidiChannel { get; set; }

		/// <summary>
		/// The <see cref="MessageType"/> property
		/// </summary>
		[XmlAttribute(AttributeName = nameof(MessageType))]
		public Enums.MidiMessageType MessageType { get; set; }

		/// <summary>
		/// The <see cref="Number"/> property
		/// </summary>
		[XmlAttribute(AttributeName = nameof(Number))]
		public int Number { get; set; }
	}
}
