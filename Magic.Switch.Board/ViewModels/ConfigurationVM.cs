using Magic.Switch.Board.Core.Models.Device;
using Magic.Switch.Board.ViewModels.Base;
using System.Collections.ObjectModel;

namespace Magic.Switch.Board.ViewModels;

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
		PropertyChanged += OnViewModelPropertyChanged;
	}

	public Guid Id { get => id; set => SetProperty(ref id, value); }

	public string ApplicationVersion { get => applicationVersion; set => SetProperty(ref applicationVersion, value); }

	public string ConfigurationVersion { get => configurationVersion; set => SetProperty(ref configurationVersion, value); }

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