using Magic.Switch.Board.Core.Models.Device;
using Magic.Switch.Board.UI.Logic.BaseTypes;
using Magic.Switch.Board.UI.Logic.Properties;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using static Magic.Switch.Board.UI.Logic.Properties.Resources;

namespace Magic.Switch.Board.UI.Logic.ViewModels.Device;

/// <summary>
/// The <see cref="ConfigurationVM"/> class is the view model class for the model class <see cref="Configuration"/>.
/// </summary>
public sealed class ConfigurationVM : ViewModelBase<Configuration>
{
	private Guid id;
	private string applicationVersion = default!;
	private string configurationVersion = default!;
	private ObservableCollection<ChannelVM> channels = new();

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
	[Display(Name = nameof(ViewModel_Display_Name_Id), ResourceType = typeof(Resources))]
	public Guid Id { get => id; private set => SetProperty(ref id, value); }

	/// <summary>The <see cref="ApplicationVersion"/> property.</summary>
	[Display(Name = nameof(ViewModel_Display_Name_Application_Version), ResourceType = typeof(Resources))]
	public string ApplicationVersion { get => applicationVersion; set => SetProperty(ref applicationVersion, value); }

	/// <summary>The <see cref="ConfigurationVersion"/> property.</summary>
	[Display(Name = nameof(ViewModel_Display_Name_Configuration_Version), ResourceType = typeof(Resources))]
	public string ConfigurationVersion { get => configurationVersion; set => SetProperty(ref configurationVersion, value); }

	/// <summary>The <see cref="Channels"/> property.</summary>
	[Display(Name = nameof(ViewModel_Display_Name_Channels), ResourceType = typeof(Resources))]
	public ObservableCollection<ChannelVM> Channels { get => channels; set => SetProperty(ref channels, value); }

	private void Initialize()
	{
		Id = Model.Id;
		ApplicationVersion = Model.ApplicationVersion;
		ConfigurationVersion = Model.ConfigurationVersion;
		foreach (Channel channel in Model.Channels)
			Channels.Add(new(channel));
	}
}