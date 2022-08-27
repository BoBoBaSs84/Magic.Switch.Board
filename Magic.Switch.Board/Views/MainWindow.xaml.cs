﻿using Magic.Switch.Board.Core.Contracts.Services;
using Magic.Switch.Board.ViewModels;
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