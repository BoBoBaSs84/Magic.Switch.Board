using System.ComponentModel.DataAnnotations;

using Magic.Switch.Board.Core.Models.Device;
using Magic.Switch.Board.UI.Logic.BaseTypes;
using Magic.Switch.Board.UI.Logic.Properties;

using static Magic.Switch.Board.UI.Logic.Properties.Resources;

namespace Magic.Switch.Board.UI.Logic.ViewModels.Device;

/// <summary>
/// The <see cref="ConfigurationVM"/> class is the view model class for the model class <see cref="Configuration"/>.
/// </summary>
public sealed class ConfigurationVM : ViewModelBase<Configuration>
{
	private Guid _id;
	private string _name = string.Empty;
	private string? _description;
	private string _applicationVersion = string.Empty;
	private string _configurationVersion = string.Empty;
	private ICollection<ChannelVM> _channels = new List<ChannelVM>();
	private DateTime _created;
	private DateTime? _updated;

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
		if (e.PropertyName is not null && !e.PropertyName.Equals(nameof(Updated), StringComparison.Ordinal))
			configurationVM.Updated = DateTime.Now;
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

	/// <summary>The <see cref="ApplicationVersion"/> property.</summary>
	[Display(ResourceType = typeof(Resources), Name = nameof(ViewModel_Display_Name_Application_Version))]
	public string ApplicationVersion { get => _applicationVersion; private set => SetProperty(ref _applicationVersion, value); }

	/// <summary>The <see cref="ConfigurationVersion"/> property.</summary>
	[Display(ResourceType = typeof(Resources), Name = nameof(ViewModel_Display_Name_Configuration_Version))]
	public string ConfigurationVersion { get => _configurationVersion; private set => SetProperty(ref _configurationVersion, value); }

	/// <summary>The <see cref="Channels"/> property.</summary>
	[Display(ResourceType = typeof(Resources), Name = nameof(ViewModel_Display_Name_Channels))]
	public ICollection<ChannelVM> Channels { get => _channels; set => SetProperty(ref _channels, value); }

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
