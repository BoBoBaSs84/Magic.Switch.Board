using Magic.Switch.Board.Contracts;
using Magic.Switch.Board.Services.Device.Interfaces;
using Magic.Switch.Board.Services.Logging.Interfaces;
using System.Windows;
using static Magic.Switch.Board.Statics;

namespace Magic.Switch.Board.Views;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	/// <summary>
	/// The <see cref="MainWindow"/> constructor
	/// </summary>
	public MainWindow(ILoggerService logger, IDeviceConfigService deviceConfigService)
	{
		InitializeComponent();
		DataContext = new MainViewModel(logger, deviceConfigService, AssemblyVersion);
	}
}