﻿using Magic.Switch.Board.Core.Models.Device;
using Magic.Switch.Board.Properties;
using Magic.Switch.Board.ViewModels.Base;
using System.ComponentModel.DataAnnotations;
using static Magic.Switch.Board.Core.Enums;
using static Magic.Switch.Board.Properties.Resources;

namespace Magic.Switch.Board.ViewModels.Device;

/// <summary>
/// The <see cref="SwitchesVM"/> class is the view model class for the model class <see cref="Loops"/>.
/// </summary>
public class SwitchesVM : ViewModelBase<Switches>
{
	private SwitchChannels channels;

	/// <summary>
	/// Initializes a new instance of the <see cref="LoopsVM"/> class.
	/// </summary>
	/// <param name="model">The domain channel model.</param>
	public SwitchesVM(Switches model) : base(model)
	{
		Initialize();
		PropertyChanged += OnViewModelPropertyChanged;
	}

	/// <summary>The <see cref="Channels"/> property.</summary>
	[Display(Name = nameof(ViewModel_Display_Name_Channels), ResourceType = typeof(Resources))]
	public SwitchChannels Channels { get => channels; set => SetPropertyAndValidate(ref channels, value); }

	private void Initialize() => Channels = Model.Channels;
}