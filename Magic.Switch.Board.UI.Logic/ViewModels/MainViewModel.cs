using Magic.Switch.Board.Core.Contracts.Services;
using Magic.Switch.Board.Core.Models.Device;
using Magic.Switch.Board.UI.Logic.BaseTypes;
using Magic.Switch.Board.UI.Logic.ViewModels.Device;
using System.ComponentModel;
using System.Windows.Data;
using System.Windows.Input;

namespace Magic.Switch.Board.UI.Logic.ViewModels;

/// <summary>
/// The <see cref="MainViewModel"/> class.
/// </summary>
public sealed class MainViewModel : ViewModelBase
{
	private readonly ILoggerService _logger;
	private readonly IDeviceConfigService _deviceConfigService;

	/// <summary>
	/// The <see cref="MainViewModel"/> class constructor.
	/// </summary>
	public MainViewModel(ILoggerService logger, IDeviceConfigService deviceConfigService)
	{
		_logger = logger;
		_deviceConfigService = deviceConfigService;
		IList<ConfigurationVM> configurations = GetConfigurations();
		ConfigurationsView = CollectionViewSource.GetDefaultView(configurations);
		ConfigurationsView.CurrentChanged += OnConfigurationSelectionChanged;
	}

	public void OnConfigurationSelectionChanged(object? sender, EventArgs e)
	{
		if (sender is not ICollectionView configurationsView)
			return;
		if (configurationsView.CurrentItem is not ConfigurationVM configuration)
			return;

		ConfigurationView = configuration;
	}



	public ICollectionView ConfigurationsView { get; }

	public ConfigurationVM ConfigurationView { get; set; }

	// TODO: Some random configs for now ...
	private List<ConfigurationVM> GetConfigurations()
	{
		List<ConfigurationVM> configList = new();
		for (int i = 0; i < 100; i++)
		{
			Configuration config = _deviceConfigService.Create(Statics.AssemblyVersion);
			configList.Add(new ConfigurationVM(config));
		}
		return configList;
	}

	private RelayCommand openChildCommand;
	public ICommand OpenChildCommand => openChildCommand ??= new RelayCommand(OpenChild);

	private void OpenChild()
	{
	}

	private RelayCommand addPersonCommand;
	public ICommand AddPersonCommand => addPersonCommand ??= new RelayCommand(AddPerson);

	private void AddPerson()
	{
	}

	private double progress;

	public double Progress { get => progress; set => SetProperty(ref progress, value); }
}