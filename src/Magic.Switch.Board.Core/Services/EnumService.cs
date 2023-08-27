using Magic.Switch.Board.Core.Contracts.Services;
using Magic.Switch.Board.Core.Exceptions;
using Magic.Switch.Board.Core.Models;

using static Magic.Switch.Board.Core.Enums;
using static Magic.Switch.Board.Core.Properties.Resources;

namespace Magic.Switch.Board.Core.Services;

/// <summary>
/// The <see cref="EnumService"/> class implements the members of the <see cref="IEnumService"/> interface.
/// </summary>
public class EnumService : IEnumService
{
	private readonly ILoggerService _logger;

	/// <summary>
	/// Initializes a new instance of the <see cref="EnumService"/> class.
	/// </summary>
	/// <param name="logger">The logger service.</param>
	public EnumService(ILoggerService logger) => _logger = logger;

	/// <inheritdoc cref="IEnumService.GetLogLevels"/>
	/// <exception cref="ServiceException"></exception>
	public IReadOnlyList<EnumModel<LogLevel>> GetLogLevels()
	{
		try
		{
			return LogLevel.None.GetEnumModelList();
		}
		catch (Exception ex)
		{
			_logger.Error($"{ex.Message}");
			throw new ServiceException(Error_While_Fetching_Enum_List, ex);
		}
	}

	/// <inheritdoc cref="IEnumService.GetLoopChannels"/>
	/// <exception cref="ServiceException"></exception>
	public IReadOnlyList<EnumModel<LoopChannels>> GetLoopChannels()
	{
		try
		{
			return LoopChannels.CH01.GetEnumModelList();
		}
		catch (Exception ex)
		{
			_logger.Error($"{ex.Message}");
			throw new ServiceException(Error_While_Fetching_Enum_List, ex);
		}
	}

	/// <inheritdoc cref="IEnumService.GetMidiChannels"/>
	/// <exception cref="ServiceException"></exception>
	public IReadOnlyList<EnumModel<MidiChannel>> GetMidiChannels()
	{
		try
		{
			return MidiChannel.CH01.GetEnumModelList();
		}
		catch (Exception ex)
		{
			_logger.Error($"{ex.Message}");
			throw new ServiceException(Error_While_Fetching_Enum_List, ex);
		}
	}

	/// <inheritdoc cref="IEnumService.GetMidiMessageTypes"/>
	/// <exception cref="ServiceException"></exception>
	public IReadOnlyList<EnumModel<MidiMessageType>> GetMidiMessageTypes()
	{
		try
		{
			return MidiMessageType.PCM.GetEnumModelList();
		}
		catch (Exception ex)
		{
			_logger.Error($"{ex.Message}");
			throw new ServiceException(Error_While_Fetching_Enum_List, ex);
		}
	}

	/// <inheritdoc cref="IEnumService.GetSwitchChannels"/>
	/// <exception cref="ServiceException"></exception>
	public IReadOnlyList<EnumModel<SwitchChannels>> GetSwitchChannels()
	{
		try
		{
			return SwitchChannels.CH01.GetEnumModelList();
		}
		catch (Exception ex)
		{
			_logger.Error($"{ex.Message}");
			throw new ServiceException(Error_While_Fetching_Enum_List, ex);
		}
	}
}
