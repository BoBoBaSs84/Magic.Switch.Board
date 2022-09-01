﻿using Magic.Switch.Board.Core.Models.Device;
using Magic.Switch.Board.UI.Logic.BaseTypes;
using Magic.Switch.Board.UI.Logic.Properties;
using System.ComponentModel.DataAnnotations;
using static Magic.Switch.Board.UI.Logic.Properties.Resources;

namespace Magic.Switch.Board.UI.Logic.ViewModels.Device;

/// <summary>
/// The <see cref="ConfigurationVM"/> class is the view model class for the model class <see cref="Configuration"/>.
/// </summary>
public sealed class ConfigurationVM : ViewModelBase<Configuration>
{
	private Guid id;
	private string name = string.Empty;
	private string? remarks;
	private string applicationVersion = string.Empty;
	private string configurationVersion = string.Empty;
	private List<ChannelVM> channels = new();
	private DateTime created;
	private DateTime updated;

	/// <summary>
	/// Initializes a new instance of the <see cref="ConfigurationVM"/> class.
	/// </summary>
	/// <param name="configuration">The domain configuration model.</param>
	public ConfigurationVM(Configuration configuration) : base(configuration)
	{
		Initialize();
		PropertyChanged += OnPropertyChangedPropagate;
	}

	/// <summary>The <see cref="Id"/> property.</summary>
	[Display(Name = nameof(ViewModel_Display_Name_Id),
		ShortName = nameof(ViewModel_Display_Name_Id),
		Description = nameof(ViewModel_Display_Name_Id),
		AutoGenerateField = true,
		Prompt = "Hallo",
		ResourceType = typeof(Resources))]
	public Guid Id { get => id; private set => SetProperty(ref id, value); }

	/// <summary>The <see cref="Name"/> property.</summary>
	[Display(Name = nameof(ViewModel_Display_Name_Name), ResourceType = typeof(Resources))]
	public string Name { get => name; set => SetPropertyAndValidate(ref name, value); }

	/// <summary>The <see cref="Remarks"/> property.</summary>
	[Display(Name = nameof(ViewModel_Display_Name_Remarks), ResourceType = typeof(Resources))]
	public string? Remarks { get => remarks; set => SetPropertyAndValidate(ref remarks, value); }

	/// <summary>The <see cref="ApplicationVersion"/> property.</summary>
	[Display(Name = nameof(ViewModel_Display_Name_Application_Version), ResourceType = typeof(Resources))]
	public string ApplicationVersion { get => applicationVersion; private set => SetProperty(ref applicationVersion, value); }

	/// <summary>The <see cref="ConfigurationVersion"/> property.</summary>
	[Display(Name = nameof(ViewModel_Display_Name_Configuration_Version), ResourceType = typeof(Resources))]
	public string ConfigurationVersion { get => configurationVersion; private set => SetProperty(ref configurationVersion, value); }

	/// <summary>The <see cref="Channels"/> property.</summary>
	[Display(Name = nameof(ViewModel_Display_Name_Channels), ResourceType = typeof(Resources))]
	public List<ChannelVM> Channels { get => channels; set => SetProperty(ref channels, value); }

	/// <summary>The <see cref="Created"/> property.</summary>
	[Display(Name = nameof(ViewModel_Display_Name_Created), ResourceType = typeof(Resources))]
	public DateTime Created { get => created; set => SetProperty(ref created, value); }

	/// <summary>The <see cref="Updated"/> property.</summary>
	[Display(Name = nameof(ViewModel_Display_Name_Updated), ResourceType = typeof(Resources))]
	public DateTime Updated { get => updated; set => SetProperty(ref updated, value); }

	private void Initialize()
	{
		Id = Model.Id;
		Name = Model.Name;
		Remarks = Model.Description;
		ApplicationVersion = Model.ApplicationVersion;
		ConfigurationVersion = Model.ConfigurationVersion;
		foreach (Channel channel in Model.Channels)
			Channels.Add(new(channel));
		Created = Model.Created;
		Updated = Model.Updated;
	}
}