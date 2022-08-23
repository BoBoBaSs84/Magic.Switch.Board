using System.Windows;
using static Magic.Switch.Board.Properties.Settings;

namespace Magic.Switch.Board.Views;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	/// <summary>
	/// The <see cref="MainWindow"/> constructor
	/// </summary>
	public MainWindow()
	{
		InitializeComponent();
		TextBox.Text = Default.Language;
	}
}