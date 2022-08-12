using Magic.Switch.Board.Contracts.Application;
using Magic.Switch.Board.Services.Application.Interfaces;
using System.Windows;
using static Magic.Switch.Board.Statics;

namespace Magic.Switch.Board.Views;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	private readonly ConfigurationViewModel _configurationViewModel;

	/// <summary>
	/// The <see cref="MainWindow"/> constructor
	/// </summary>
	public MainWindow(IConfigurationService configurationService)
	{
		InitializeComponent();
		_configurationViewModel = new(configurationService, AssemblyVersion);
		DataContext = _configurationViewModel;
	}
}
