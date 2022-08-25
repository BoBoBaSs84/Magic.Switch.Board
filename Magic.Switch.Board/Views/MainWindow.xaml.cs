using System.Drawing;
using System.IO;
using System.Windows;
using Magic.Switch.Board.Contracts;
using Magic.Switch.Board.Services.Logging.Interfaces;

namespace Magic.Switch.Board.Views;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	private readonly ILoggerService _logger;

	/// <summary>
	/// The <see cref="MainWindow"/> constructor
	/// </summary>
	public MainWindow(ILoggerService logger)
	{
		_logger = logger;
		InitializeComponent();
		DataContext = new MainViewModel(_logger);
	}
}