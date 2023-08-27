using System.Windows;

using Magic.Switch.Board.UI.Logic.ViewModels;

namespace Magic.Switch.Board.UI.Views;

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