using Magic.Switch.Board.Core.Models.Device;
using Magic.Switch.Board.UI.Logic.BaseTypes;
using Magic.Switch.Board.UI.Logic.Properties;
using System.ComponentModel.DataAnnotations;
using static Magic.Switch.Board.Core.Enums;
using static Magic.Switch.Board.UI.Logic.Properties.Resources;

namespace Magic.Switch.Board.UI.Logic.ViewModels.Device;

/// <summary>
/// The <see cref="InputVM"/> class is the view model class for the model class <see cref="Input"/>.
/// </summary>
public class InputVM : ViewModelBase<Input>
{
	private MidiChannel midiChannel;
	private MidiMessageType messageType;
	private int number;

	/// <summary>
	/// Initializes a new instance of the <see cref="InputVM"/> class.
	/// </summary>
	/// <param name="model">The domain channel model.</param>
	public InputVM(Input model) : base(model)
	{
		Initialize();
		PropertyChanged += OnPropertyChangedPropagate;
	}

	/// <summary>The <see cref="MidiChannel"/> property.</summary>
	[Display(Name = nameof(ViewModel_Display_Name_MidiChannel), ResourceType = typeof(Resources))]
	public MidiChannel MidiChannel { get => midiChannel; set => SetPropertyAndValidate(ref midiChannel, value); }

	/// <summary>The <see cref="MessageType"/> property.</summary>
	[Display(Name = nameof(ViewModel_Display_Name_MessageType), ResourceType = typeof(Resources))]
	public MidiMessageType MessageType { get => messageType; set => SetPropertyAndValidate(ref messageType, value); }

	/// <summary>The <see cref="Number"/> property.</summary>
	[Display(Name = nameof(ViewModel_Display_Name_Number), ResourceType = typeof(Resources))]
	public int Number { get => number; set => SetPropertyAndValidate(ref number, value); }

	private void Initialize()
	{
		MidiChannel = Model.MidiChannel;
		MessageType = Model.MessageType;
		Number = Model.Number;
	}
}
