﻿using Magic.Switch.Board.Core.Contracts.Services;
using Magic.Switch.Board.Core.Models.Device;
using Magic.Switch.Board.UI.Logic.BaseTypes;
using Magic.Switch.Board.UI.Logic.ViewModels.Device;
using System.ComponentModel;
using System.Windows.Data;
using System.Windows.Input;
using static Magic.Switch.Board.UI.Logic.Statics;

namespace Magic.Switch.Board.UI.Logic.ViewModels;

/// <summary>
/// The <see cref="MainViewModel"/> class.
/// </summary>
public sealed class MainViewModel : ViewModelBase
{
	private readonly ILoggerService _logger;
	private readonly IDeviceConfigService _deviceConfigService;
	private readonly IEnumService _enumService;

	/// <summary>
	/// The <see cref="MainViewModel"/> class constructor.
	/// </summary>
	public MainViewModel(ILoggerService logger, IDeviceConfigService deviceConfigService, IEnumService enumService)
	{
		_logger = logger;
		_deviceConfigService = deviceConfigService;
		_enumService = enumService;
		IList<Configuration> configurations = GetConfigurations();
		ConfigurationsView = CollectionViewSource.GetDefaultView(configurations);
		ConfigurationsView.CurrentChanged += OnConfigurationSelectionChanged;

		IReadOnlyList<Core.Models.EnumModel<Core.Enums.MidiMessageType>> list = _enumService.GetMidiMessageTypes();
	}

	public void OnConfigurationSelectionChanged(object? sender, EventArgs e)
	{
		if (sender is not ICollectionView configurationsView)
			return;
		if (configurationsView.CurrentItem is not Configuration configuration)
			return;

		Progress = configurationsView.CurrentPosition;
		ConfigurationView = new(configuration);
	}

	/// <summary>The <see cref="ApplicationVersion"/> property.</summary>
	public string ApplicationVersion { get; }

	public ICollectionView ConfigurationsView { get; }


	private ConfigurationVM configurationView;
	public ConfigurationVM ConfigurationView { get => configurationView; set => SetProperty(ref configurationView, value); }

	// TODO: Some random configs for now ...
	private List<Configuration> GetConfigurations()
	{
		List<Configuration> configList = new();
		for (int i = 0; i < 10000; i++)
		{
			Configuration config = _deviceConfigService.Create(Guid.NewGuid().ToString(), AssemblyVersion);
			if (i == 1000)
			{
				config.Name = "Super War RIG";
				config.Description = "The Tatra T815, aka the \"The War Rig\", is a custom vehicle driven by Imperator Furiosa in Mad Max Fury Road.";
				config.Channels.Add(
					new Channel("Clean with reverb",
					new Input(Core.Enums.MidiChannel.CH01, Core.Enums.MidiMessageType.PCM, 13),
					new Output(Core.Enums.MidiChannel.CH03, Core.Enums.MidiMessageType.PCM, 145),
					new Switches(Core.Enums.SwitchChannels.CH01 | Core.Enums.SwitchChannels.CH02),
					new Loops(Core.Enums.LoopChannels.CH01)));
				config.Channels.Add(
					new Channel("Distortion with reverb",
					new Input(Core.Enums.MidiChannel.CH01, Core.Enums.MidiMessageType.PCM, 14),
					new Output(Core.Enums.MidiChannel.CH03, Core.Enums.MidiMessageType.PCM, 146),
					new Switches(Core.Enums.SwitchChannels.CH01 | Core.Enums.SwitchChannels.CH02 | Core.Enums.SwitchChannels.CH03),
					new Loops(Core.Enums.LoopChannels.CH01 | Core.Enums.LoopChannels.CH02)));
				(bool success, string message) = _deviceConfigService.Write("D:\\", "Test.xml", config);
			}
			configList.Add(config);
		}
		return configList;
	}

	private RelayCommand? openChildCommand;
	public ICommand OpenChildCommand => openChildCommand ??= new RelayCommand(OpenChild);

	private void OpenChild()
	{
	}

	private RelayCommand? addPersonCommand;
	public ICommand AddPersonCommand => addPersonCommand ??= new RelayCommand(AddPerson);

	private void AddPerson()
	{
	}

	private double progress;

	public double Progress { get => progress; set => SetProperty(ref progress, value); }
}