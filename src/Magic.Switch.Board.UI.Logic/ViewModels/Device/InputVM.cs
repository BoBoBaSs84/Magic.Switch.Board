using System.ComponentModel.DataAnnotations;

using Magic.Switch.Board.Core.Models.Device;
using Magic.Switch.Board.UI.Logic.BaseTypes;
using Magic.Switch.Board.UI.Logic.Properties;

using static Magic.Switch.Board.Core.Enums;
using static Magic.Switch.Board.UI.Logic.Properties.Resources;

namespace Magic.Switch.Board.UI.Logic.ViewModels.Device;

/// <summary>
/// The <see cref="InputVM"/> class is the view model class for the model class <see cref="Input"/>.
/// </summary>
public class InputVM : ViewModelBase<Input>
{
	private MidiChannel _midiChannel;
	private MidiMessageType _messageType;
	private int _number;

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
	[Display(ResourceType = typeof(Resources), Name = nameof(ViewModel_Display_Name_MidiChannel))]
	public MidiChannel MidiChannel { get => _midiChannel; set => SetProperty(ref _midiChannel, value); }

	/// <summary>The <see cref="MessageType"/> property.</summary>
	[Display(ResourceType = typeof(Resources), Name = nameof(ViewModel_Display_Name_MessageType))]
	public MidiMessageType MessageType { get => _messageType; set => SetProperty(ref _messageType, value); }

	/// <summary>The <see cref="Number"/> property.</summary>
	[Display(ResourceType = typeof(Resources), Name = nameof(ViewModel_Display_Name_Number))]
	public int Number { get => _number; set => SetPropertyAndValidate(ref _number, value); }

	private void Initialize()
	{
		MidiChannel = Model.MidiChannel;
		MessageType = Model.MessageType;
		Number = Model.Number;
	}
}
