using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Magic.Switch.Board.Core.Models.Device;

/// <summary>
/// The <see cref="Channel"/> class.
/// </summary>
[XmlRoot(ElementName = nameof(Channel), IsNullable = false)]
public class Channel
{
	/// <summary>
	/// The empty <see cref="Channel"/> class constructor.
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
	/// The standard <see cref="Channel"/> class constructor.
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
	/// The <see cref="Id"/> property.
	/// </summary>
	[JsonPropertyName(nameof(Id))]
	[XmlAttribute(AttributeName = nameof(Id))]
	public Guid Id { get; set; }

	/// <summary>
	/// The <see cref="Name"/> property, can not be <see langword="null"/>.
	/// </summary>
	[JsonPropertyName(nameof(Name))]
	[XmlElement(ElementName = nameof(Name), IsNullable = false)]
	public string Name { get; set; }

	/// <summary>
	/// The <see cref="Input"/> property, can not be <see langword="null"/>.
	/// </summary>
	[JsonPropertyName(nameof(Input))]
	[XmlElement(ElementName = nameof(Input), IsNullable = false)]
	public Input Input { get; set; }

	/// <summary>
	/// The <see cref="Output"/> property, can be <see langword="null"/>.
	/// </summary>
	[JsonPropertyName(nameof(Output))]
	[XmlElement(ElementName = nameof(Output), IsNullable = false)]
	public Output? Output { get; set; }

	/// <summary>
	/// The <see cref="Switches"/> property, can be <see langword="null"/>.
	/// </summary>
	[JsonPropertyName(nameof(Switches))]
	[XmlElement(ElementName = nameof(Switches), IsNullable = false)]
	public Switches? Switches { get; set; }

	/// <summary>
	/// The <see cref="Loops"/> property, can be <see langword="null"/>.
	/// </summary>
	[JsonPropertyName(nameof(Loops))]
	[XmlElement(ElementName = nameof(Loops), IsNullable = false)]
	public Loops? Loops { get; set; }
}