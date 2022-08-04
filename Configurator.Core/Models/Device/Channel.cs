using System.Xml.Serialization;

namespace Configurator.Core.Models.Device
{
	/// <summary>
	/// The <see cref="Channel"/> class
	/// </summary>
	[XmlRoot(ElementName = nameof(Channel), IsNullable = false)]
	public class Channel
	{
		/// <summary>
		/// The empty <see cref="Channel"/> constructor
		/// </summary>
		public Channel()
		{
			Id = Guid.NewGuid();
			Name = string.Empty;
			Input = new();
			Output = default;
			Switches = default;
			Loops = default;
		}

		/// <summary>
		/// The <see cref="Channel"/> constructor
		/// </summary>
		/// <param name="name">The name of the channel configuration.</param>
		/// <param name="input">The input parameters the channel listens to.</param>
		/// <param name="output">The output parameters the channel should send.</param>
		/// <param name="switches">The switches the channel should switch.</param>
		/// <param name="loops">The loops the channel should switch.</param>
		/// <exception cref="ArgumentNullException"></exception>
		public Channel(string name, Input input, Output output, Switches switches, Loops loops)
		{
			Id = Guid.NewGuid();
			Name = name ?? throw new ArgumentNullException(nameof(name)); ;
			Input = input ?? throw new ArgumentNullException(nameof(input));
			Output = output ?? throw new ArgumentNullException(nameof(output));
			Switches = switches ?? throw new ArgumentNullException(nameof(switches));
			Loops = loops ?? throw new ArgumentNullException(nameof(loops));
		}

		/// <summary>
		/// The <see cref="Id"/> property
		/// </summary>
		[XmlAttribute(AttributeName = nameof(Id))]
		public Guid Id { get; set; }

		/// <summary>
		/// The <see cref="Name"/> property
		/// </summary>
		[XmlElement(ElementName = nameof(Name), IsNullable = false)]
		public string Name { get; set; }

		/// <summary>
		/// The <see cref="Input"/> property
		/// </summary>
		[XmlElement(ElementName = nameof(Input), IsNullable = false)]
		public Input Input { get; set; }

		/// <summary>
		/// The <see cref="Output"/> property, can be <see cref="Nullable"/>
		/// </summary>
		[XmlElement(ElementName = nameof(Output), IsNullable = false)]
		public Output? Output { get; set; }

		/// <summary>
		/// The <see cref="Switches"/> property, can be <see cref="Nullable"/>
		/// </summary>
		[XmlElement(ElementName = nameof(Switches), IsNullable = false)]
		public Switches? Switches { get; set; }

		/// <summary>
		/// The <see cref="Loops"/> property, can be <see cref="Nullable"/>
		/// </summary>
		[XmlElement(ElementName = nameof(Loops), IsNullable = false)]
		public Loops? Loops { get; set; }
	}
}
