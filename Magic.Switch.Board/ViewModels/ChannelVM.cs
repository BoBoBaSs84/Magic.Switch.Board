using Magic.Switch.Board.Core.Models.Device;
using Magic.Switch.Board.ViewModels.Base;

namespace Magic.Switch.Board.ViewModels;

/// <summary>
/// The <see cref="ChannelVM"/> class is the view model class for the model class <see cref="Channel"/>.
/// </summary>
public sealed class ChannelVM : ViewModelBase<Channel>
{
	private Guid id;
	private string name = default!;
	private Input input = default!;
	private Output? output;
	private Switches? switches;
	private Loops? loops;

	/// <summary>
	/// Initializes a new instance of the <see cref="ChannelVM"/> class.
	/// </summary>
	/// <param name="channel">The domain channel model.</param>
	public ChannelVM(Channel channel) : base(channel)
	{
		Initialize();
		PropertyChanged += OnViewModelPropertyChanged;
	}

	public Guid Id { get => id; set => SetProperty(ref id, value); }
	public string Name { get => name; set => SetPropertyAndValidate(ref name, value); }
	public Input Input { get => input; set => SetProperty(ref input, value); }
	public Output? Output { get => output; set => SetProperty(ref output, value); }
	public Switches? Switches { get => switches; set => SetProperty(ref switches, value); }
	public Loops? Loops { get => loops; set => SetProperty(ref loops, value); }

	private void Initialize()
	{
		Id = Model.Id;
		Name = Model.Name;
		Input = Model.Input;
		Output = Model.Output;
		Switches = Model.Switches;
		Loops = Model.Loops;
	}
}