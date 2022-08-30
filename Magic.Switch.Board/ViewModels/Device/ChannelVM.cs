using Magic.Switch.Board.Core.Models.Device;
using Magic.Switch.Board.Properties;
using Magic.Switch.Board.ViewModels.Base;
using System.ComponentModel.DataAnnotations;
using static Magic.Switch.Board.Properties.Resources;

namespace Magic.Switch.Board.ViewModels.Device;

/// <summary>
/// The <see cref="ChannelVM"/> class is the view model class for the model class <see cref="Channel"/>.
/// </summary>
public sealed class ChannelVM : ViewModelBase<Channel>
{
	private Guid id;
	private string name = default!;
	private InputVM input = default!;
	private OutputVM? output;
	private SwitchesVM? switches;
	private LoopsVM? loops;

	/// <summary>
	/// Initializes a new instance of the <see cref="ChannelVM"/> class.
	/// </summary>
	/// <param name="channel">The domain channel model.</param>
	public ChannelVM(Channel channel) : base(channel)
	{
		Initialize();
		PropertyChanged += OnPropertyChangedPropagate;
	}

	/// <summary>The <see cref="Id"/> property.</summary>
	[Display(Name = nameof(ViewModel_Display_Name_Id), ResourceType = typeof(Resources))]
	public Guid Id { get => id; private set => SetProperty(ref id, value); }

	/// <summary>The <see cref="Name"/> property.</summary>
	[Display(Name = nameof(ViewModel_Display_Name_Name), ResourceType = typeof(Resources))]
	public string Name { get => name; set => SetPropertyAndValidate(ref name, value); }

	/// <summary>The <see cref="Input"/> property.</summary>
	[Display(Name = nameof(ViewModel_Display_Name_Input), ResourceType = typeof(Resources))]
	public InputVM Input { get => input; set => SetProperty(ref input, value); }

	/// <summary>The <see cref="Output"/> property.</summary>
	[Display(Name = nameof(ViewModel_Display_Name_Output), ResourceType = typeof(Resources))]
	public OutputVM? Output { get => output; set => SetProperty(ref output, value); }

	/// <summary>The <see cref="Switches"/> property.</summary>
	[Display(Name = nameof(ViewModel_Display_Name_Switches), ResourceType = typeof(Resources))]
	public SwitchesVM? Switches { get => switches; set => SetProperty(ref switches, value); }

	/// <summary>The <see cref="Loops"/> property.</summary>
	[Display(Name = nameof(ViewModel_Display_Name_Loops), ResourceType = typeof(Resources))]
	public LoopsVM? Loops { get => loops; set => SetProperty(ref loops, value); }

	private void Initialize()
	{
		Id = Model.Id;
		Name = Model.Name;
		Input = new(Model.Input);
		if (Model.Output is not null)
			Output = new(Model.Output);
		if (Model.Switches is not null)
			Switches = new(Model.Switches);
		if (Model.Loops is not null)
			Loops = new(Model.Loops);
	}
}