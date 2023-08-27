using System.ComponentModel.DataAnnotations;

using Magic.Switch.Board.Core.Models.Device;
using Magic.Switch.Board.UI.Logic.BaseTypes;
using Magic.Switch.Board.UI.Logic.Properties;

using static Magic.Switch.Board.Core.Enums;
using static Magic.Switch.Board.UI.Logic.Properties.Resources;

namespace Magic.Switch.Board.UI.Logic.ViewModels.Device;

/// <summary>
/// The <see cref="LoopsVM"/> class is the view model class for the model class <see cref="Loops"/>.
/// </summary>
public class LoopsVM : ViewModelBase<Loops>
{
	private LoopChannels channels;

	/// <summary>
	/// Initializes a new instance of the <see cref="LoopsVM"/> class.
	/// </summary>
	/// <param name="model">The domain channel model.</param>
	public LoopsVM(Loops model) : base(model)
	{
		Initialize();
		PropertyChanged += OnPropertyChangedPropagate;
	}

	/// <summary>The <see cref="Channels"/> property.</summary>
	[Display(ResourceType = typeof(Resources), Name = nameof(ViewModel_Display_Name_Channels))]
	public LoopChannels Channels { get => channels; set => SetProperty(ref channels, value); }

	private void Initialize() => Channels = Model.Channels;
}
