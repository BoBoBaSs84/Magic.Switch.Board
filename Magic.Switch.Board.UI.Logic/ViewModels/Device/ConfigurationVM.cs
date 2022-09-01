using Magic.Switch.Board.Core.Models.Device;
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
	private string? description;
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
		PropertyChanged += OnPropertyChangedSetUpdate;
	}

	private void OnPropertyChangedSetUpdate(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
	{
		if (sender is not ConfigurationVM configurationVM)
			return;
		if (e.PropertyName is not null && !e.PropertyName.Equals(nameof(Updated)))
			configurationVM.Updated = DateTime.Now;
	}

	/// <summary>The <see cref="Id"/> property.</summary>
	[Display(ResourceType = typeof(Resources),
		Name = nameof(ViewModel_Display_Name_Id),
		ShortName = nameof(ViewModel_Display_Name_Id),
		Description = nameof(ViewModel_Display_Name_Id))]
	public Guid Id { get => id; private set => SetPropertyNoNotify(ref id, value); }

	/// <summary>The <see cref="Name"/> property.</summary>
	[Display(Name = nameof(ViewModel_Display_Name_Name), ResourceType = typeof(Resources))]
	public string Name { get => name; set => SetPropertyAndValidate(ref name, value); }

	/// <summary>The <see cref="Description"/> property.</summary>
	[Display(Name = nameof(ViewModel_Display_Name_Description), ResourceType = typeof(Resources))]
	public string? Description { get => description; set => SetPropertyAndValidate(ref description, value); }

	/// <summary>The <see cref="Created"/> property.</summary>
	[Display(Name = nameof(ViewModel_Display_Name_Created), ResourceType = typeof(Resources))]
	public DateTime Created { get => created; set => SetPropertyNoNotify(ref created, value); }

	/// <summary>The <see cref="Updated"/> property.</summary>
	[Display(Name = nameof(ViewModel_Display_Name_Updated), ResourceType = typeof(Resources))]
	public DateTime Updated { get => updated; set => SetProperty(ref updated, value); }

	/// <summary>The <see cref="ApplicationVersion"/> property.</summary>
	[Display(Name = nameof(ViewModel_Display_Name_Application_Version), ResourceType = typeof(Resources))]
	public string ApplicationVersion { get => applicationVersion; private set => SetPropertyNoNotify(ref applicationVersion, value); }

	/// <summary>The <see cref="ConfigurationVersion"/> property.</summary>
	[Display(Name = nameof(ViewModel_Display_Name_Configuration_Version), ResourceType = typeof(Resources))]
	public string ConfigurationVersion { get => configurationVersion; private set => SetPropertyNoNotify(ref configurationVersion, value); }

	/// <summary>The <see cref="Channels"/> property.</summary>
	[Display(Name = nameof(ViewModel_Display_Name_Channels), ResourceType = typeof(Resources))]
	public List<ChannelVM> Channels { get => channels; set => SetProperty(ref channels, value); }

	private void Initialize()
	{
		Id = Model.Id;
		Name = Model.Name;
		Description = Model.Description;
		Created = Model.Created;
		Updated = Model.Updated;
		ApplicationVersion = Model.ApplicationVersion;
		ConfigurationVersion = Model.ConfigurationVersion;
		foreach (Channel channel in Model.Channels)
			Channels.Add(new(channel));
	}
}