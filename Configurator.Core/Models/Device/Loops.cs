using System.Xml.Serialization;

namespace Configurator.Core.Models.Device
{
	/// <summary>
	/// The <see cref="Loops"/> class
	/// </summary>
	[XmlRoot(ElementName = nameof(Loops), IsNullable = false)]
	public class Loops
	{
		/// <summary>
		/// The empty <see cref="Loops"/> constructor
		/// </summary>
		public Loops()
		{
			Channels = default;
		}

		/// <summary>
		/// The <see cref="Loops"/> constructor
		/// </summary>
		/// <param name="channels"></param>
		public Loops(Enums.LoopChannels channels)
		{
			Channels = channels;
		}

		/// <summary>
		/// The <see cref="Channels"/> property
		/// </summary>
		[XmlAttribute(AttributeName = nameof(Channels))]
		public Enums.LoopChannels Channels { get; set; }
	}
}
