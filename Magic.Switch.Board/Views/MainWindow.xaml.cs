using Magic.Switch.Board.ViewModels;
using System.Windows;

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
		DataContext = App.GetService<MainViewModel>();
	}
}