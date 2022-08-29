using Magic.Switch.Board.Core.Models.Device;
using Magic.Switch.Board.ViewModels.Base;

namespace Magic.Switch.Board.ViewModels;

/// <summary>
/// The <see cref="ConfigurationVM"/> class is the view model class for the model class <see cref="Configuration"/>.
/// </summary>
public sealed class ConfigurationVM : ViewModelBase<Configuration>
{
	/// <summary>
	/// The <see cref="ConfigurationVM"/> class constructor.
	/// </summary>
	/// <param name="configuration"></param>
	public ConfigurationVM(Configuration configuration) : base(configuration)
	{
	}

	public Guid Id { get => GetProperty<Guid>(); set => SetProperty(value); }
}
