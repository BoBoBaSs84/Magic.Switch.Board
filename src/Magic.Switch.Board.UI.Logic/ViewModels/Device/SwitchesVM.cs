﻿using System.ComponentModel.DataAnnotations;

using Magic.Switch.Board.Core.Models.Device;
using Magic.Switch.Board.UI.Logic.BaseTypes;
using Magic.Switch.Board.UI.Logic.Properties;

using static Magic.Switch.Board.Core.Enums;
using static Magic.Switch.Board.UI.Logic.Properties.Resources;

namespace Magic.Switch.Board.UI.Logic.ViewModels.Device;

/// <summary>
/// The <see cref="SwitchesVM"/> class is the view model class for the model class <see cref="Loops"/>.
/// </summary>
public class SwitchesVM : ViewModelBase<Switches>
{
	private SwitchChannelType _channels;

	/// <summary>
	/// Initializes a new instance of the <see cref="LoopsVM"/> class.
	/// </summary>
	/// <param name="model">The domain channel model.</param>
	public SwitchesVM(Switches model) : base(model)
	{
		Initialize();
		PropertyChanged += OnPropertyChangedPropagate;
	}

	/// <summary>The <see cref="Channels"/> property.</summary>
	[Display(ResourceType = typeof(Resources), Name = nameof(ViewModel_Display_Name_Channels))]
	public SwitchChannelType Channels { get => _channels; set => SetProperty(ref _channels, value); }

	private void Initialize() => Channels = Model.Channels;
}
