using Magic.Switch.Board.Contracts;
using Magic.Switch.Board.Services.Logging.Interfaces;
using System.Windows;

namespace Magic.Switch.Board.Views;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	private readonly ILoggerService _logger;
	private readonly MainViewModel _mainViewModel;

	/// <summary>
	/// The <see cref="MainWindow"/> constructor
	/// </summary>
	public MainWindow(ILoggerService logger)
	{
		InitializeComponent();
		_logger = logger;
		_mainViewModel = new MainViewModel(_logger);
		DataContext = _mainViewModel;
	}
}