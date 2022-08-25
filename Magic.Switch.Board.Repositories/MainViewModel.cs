using Magic.Switch.Board.Contracts.Base;
using Magic.Switch.Board.Services.Logging.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Magic.Switch.Board.Contracts
{
	/// <summary>
	/// The <see cref="MainViewModel"/> class.
	/// </summary>
	public class MainViewModel : ViewModelBase
	{
		private readonly ILoggerService _logger;

		/// <summary>
		/// The <see cref="MainViewModel"/> class constructor.
		/// </summary>
		/// <param name="logger"></param>
		public MainViewModel(ILoggerService logger)
		{
			_logger = logger;
		}

		private RelayCommand cmdNewFile;
		public ICommand CmdNewFile => cmdNewFile ??= new RelayCommand(PerformCmdNewFile);

		private void PerformCmdNewFile()
		{
			MessageBox.Show("This is a message box message", "message box", MessageBoxButton.OK, MessageBoxImage.Information);
		}
	}
}