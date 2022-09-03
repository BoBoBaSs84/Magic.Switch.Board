using Magic.Switch.Board.Core.Models.Device;
using Magic.Switch.Board.UI.Logic.BaseTypes;
using Magic.Switch.Board.UI.Logic.Properties;
using System.ComponentModel.DataAnnotations;
using static Magic.Switch.Board.UI.Logic.Properties.Resources;

namespace Magic.Switch.Board.UI.Logic.ViewModels.Device;

/// <summary>
/// The <see cref="ChannelVM"/> class is the view model class for the model class <see cref="Channel"/>.
/// </summary>
public sealed class ChannelVM : ViewModelBase<Channel>
{
	private Guid id;
	private string name = string.Empty;
	private string? description;
	private DateTime created;
	private DateTime? updated;
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
	[Display(ResourceType = typeof(Resources), Name = nameof(ViewModel_Display_Name_Id))]
	public Guid Id { get => id; private set => SetProperty(ref id, value); }

	/// <summary>The <see cref="Name"/> property.</summary>
	[Display(ResourceType = typeof(Resources), Name = nameof(ViewModel_Display_Name_Name))]
	public string Name { get => name; set => SetPropertyAndValidate(ref name, value); }

	/// <summary>The <see cref="Description"/> property.</summary>
	[Display(ResourceType = typeof(Resources), Name = nameof(ViewModel_Display_Name_Description))]
	public string? Description { get => description; set => SetPropertyAndValidate(ref description, value); }

	/// <summary>The <see cref="Created"/> property.</summary>
	[Display(ResourceType = typeof(Resources), Name = nameof(ViewModel_Display_Name_Created))]
	public DateTime Created { get => created; set => SetProperty(ref created, value); }

	/// <summary>The <see cref="Updated"/> property.</summary>
	[Display(ResourceType = typeof(Resources), Name = nameof(ViewModel_Display_Name_Updated))]
	public DateTime? Updated { get => updated; set => SetProperty(ref updated, value); }

	/// <summary>The <see cref="Input"/> property.</summary>
	[Display(ResourceType = typeof(Resources), Name = nameof(ViewModel_Display_Name_Input))]
	public InputVM Input { get => input; set => SetProperty(ref input, value); }

	/// <summary>The <see cref="Output"/> property.</summary>
	[Display(ResourceType = typeof(Resources), Name = nameof(ViewModel_Display_Name_Output))]
	public OutputVM? Output { get => output; set => SetProperty(ref output, value); }

	/// <summary>The <see cref="Switches"/> property.</summary>
	[Display(ResourceType = typeof(Resources), Name = nameof(ViewModel_Display_Name_Switches))]
	public SwitchesVM? Switches { get => switches; set => SetProperty(ref switches, value); }

	/// <summary>The <see cref="Loops"/> property.</summary>
	[Display(ResourceType = typeof(Resources), Name = nameof(ViewModel_Display_Name_Loops))]
	public LoopsVM? Loops { get => loops; set => SetProperty(ref loops, value); }

	private void Initialize()
	{
		Id = Model.Id;
		Name = Model.Name;
		Description = Model.Description;
		Created = Model.CreatedAt;
		Updated = Model.UpdatedAt;
		Input = new(Model.Input);
		if (Model.Output is not null)
			Output = new(Model.Output);
		if (Model.Switches is not null)
			Switches = new(Model.Switches);
		if (Model.Loops is not null)
			Loops = new(Model.Loops);
	}
}
