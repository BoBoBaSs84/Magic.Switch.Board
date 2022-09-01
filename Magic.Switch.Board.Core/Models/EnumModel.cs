namespace Magic.Switch.Board.Core.Models;

public class EnumModel<T> where T : Enum, IConvertible
{
	public T Enum { get; set; }
	public string Name { get; set; }
	public string ShortName { get; set; }
	public string Description { get; set; }
}
