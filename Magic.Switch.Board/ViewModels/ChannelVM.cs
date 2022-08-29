using Magic.Switch.Board.Core.Models.Device;
using Magic.Switch.Board.ViewModels.Base;

namespace Magic.Switch.Board.ViewModels;

/// <summary>
/// The <see cref="ChannelVM"/> class is the view model class for the model class <see cref="Channel"/>.
/// </summary>
public sealed class ChannelVM : ViewModelBase<Channel>
{
	/// <summary>
	/// The <see cref="ChannelVM"/> class constructor.
	/// </summary>
	/// <param name="channel"></param>
	public ChannelVM(Channel channel) : base(channel)
	{
	}
}
