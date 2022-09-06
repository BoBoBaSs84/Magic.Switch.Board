using Magic.Switch.Board.Core.Models.BaseTypes.Device;
using Magic.Switch.Board.Core.Properties;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Xml.Serialization;
using static Magic.Switch.Board.Core.Properties.Resources;

namespace Magic.Switch.Board.Core.Models.Device;

/// <summary>
/// The <see cref="Channel"/> class.
/// </summary>
/// <remarks>
/// Inherits the properties from <see cref="NamedBase"/> class.
/// </remarks>
[XmlRoot(ElementName = nameof(Channel), IsNullable = false)]
public class Channel : NamedBase
{
	/// <summary>
	/// Initializes a new parameterless instance of the <see cref="Channel"/> class.
	/// </summary>
	public Channel() : base()
	{
		Input = new();
		Output = default;
		Switches = default;
		Loops = default;
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="Channel"/> class.
	/// </summary>
	/// <param name="name">The name of the channel configuration. Will throw an exception if <see langword="null"/></param>
	/// <param name="input">The input parameters the channel listens to. Will throw an exception if <see langword="null"/></param>
	/// <param name="output">The output parameters the channel should send. Will throw an exception if <see langword="null"/></param>
	/// <param name="switches">The switches the channel should switch. Will throw an exception if <see langword="null"/></param>
	/// <param name="loops">The loops the channel should switch. Will throw an exception if <see langword="null"/></param>
	/// <exception cref="ArgumentNullException"></exception>
	public Channel(string name, Input input, Output output, Switches switches, Loops loops) : base(name)
	{
		Input = input ?? throw new ArgumentNullException(nameof(input));
		Output = output ?? throw new ArgumentNullException(nameof(output));
		Switches = switches ?? throw new ArgumentNullException(nameof(switches));
		Loops = loops ?? throw new ArgumentNullException(nameof(loops));
	}

	/// <summary>
	/// The <see cref="Input"/> property, can not be <see langword="null"/>.
	/// </summary>
	[Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = nameof(Model_Field_Required_Generic))]
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
