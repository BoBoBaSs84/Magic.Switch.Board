using System.ComponentModel.DataAnnotations;

using Magic.Switch.Board.Core.Models.Device;
using Magic.Switch.Board.UI.Logic.BaseTypes;
using Magic.Switch.Board.UI.Logic.Properties;

using static Magic.Switch.Board.UI.Logic.Properties.Resources;

namespace Magic.Switch.Board.UI.Logic.ViewModels.Device;

/// <summary>
/// The <see cref="ChannelVM"/> class is the view model class for the model class <see cref="Channel"/>.
/// </summary>
public sealed class ChannelVM : ViewModelBase<Channel>
{
	private Guid _id;
	private string _name = string.Empty;
	private string? _description;
	private DateTime _created;
	private DateTime? _updated;
	private InputVM _input = default!;
	private OutputVM? _output;
	private SwitchesVM? _switches;
	private LoopsVM? _loops;

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
	[Display(ResourceType = typeof(Resources), Name = nameof(ViewModel_Display_Name_Id))]
	public Guid Id { get => _id; private set => SetProperty(ref _id, value); }

	/// <summary>The <see cref="Name"/> property.</summary>
	[Display(ResourceType = typeof(Resources), Name = nameof(ViewModel_Display_Name_Name))]
	public string Name { get => _name; set => SetPropertyAndValidate(ref _name, value); }

	/// <summary>The <see cref="Description"/> property.</summary>
	[Display(ResourceType = typeof(Resources), Name = nameof(ViewModel_Display_Name_Description))]
	public string? Description { get => _description; set => SetPropertyAndValidate(ref _description, value); }

	/// <summary>The <see cref="Created"/> property.</summary>
	[Display(ResourceType = typeof(Resources), Name = nameof(ViewModel_Display_Name_Created))]
	public DateTime Created { get => _created; set => SetProperty(ref _created, value); }

	/// <summary>The <see cref="Updated"/> property.</summary>
	[Display(ResourceType = typeof(Resources), Name = nameof(ViewModel_Display_Name_Updated))]
	public DateTime? Updated { get => _updated; set => SetProperty(ref _updated, value); }

	/// <summary>The <see cref="Input"/> property.</summary>
	[Display(ResourceType = typeof(Resources), Name = nameof(ViewModel_Display_Name_Input))]
	public InputVM Input { get => _input; set => SetProperty(ref _input, value); }

	/// <summary>The <see cref="Output"/> property.</summary>
	[Display(ResourceType = typeof(Resources), Name = nameof(ViewModel_Display_Name_Output))]
	public OutputVM? Output { get => _output; set => SetProperty(ref _output, value); }

	/// <summary>The <see cref="Switches"/> property.</summary>
	[Display(ResourceType = typeof(Resources), Name = nameof(ViewModel_Display_Name_Switches))]
	public SwitchesVM? Switches { get => _switches; set => SetProperty(ref _switches, value); }

	/// <summary>The <see cref="Loops"/> property.</summary>
	[Display(ResourceType = typeof(Resources), Name = nameof(ViewModel_Display_Name_Loops))]
	public LoopsVM? Loops { get => _loops; set => SetProperty(ref _loops, value); }

	private void Initialize()
	{
		Id = Model.Id;
		Name = Model.Name;
		Description = Model.Description;
		Created = Model.Created;
		Updated = Model.Updated;
		Input = new(Model.Input);
		if (Model.Output is not null)
			Output = new(Model.Output);
		if (Model.Switches is not null)
			Switches = new(Model.Switches);
		if (Model.Loops is not null)
			Loops = new(Model.Loops);
	}
}
