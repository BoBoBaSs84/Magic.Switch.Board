namespace Magic.Switch.Board.Core.Models;

/// <summary>
/// The <see cref="EnumModel{T}"/> class.
/// </summary>
/// <remarks>
/// The class contains all additional information about an enumerator.
/// </remarks>
/// <typeparam name="T"></typeparam>
public class EnumModel<T> where T : Enum
{
	/// <summary>
	/// Initializes a new instance of the <see cref="EnumModel{T}"/> class.
	/// </summary>
	/// <param name="enumValue">The enumerator itself.</param>
	/// <param name="name">The localized enumerator name.</param>
	/// <param name="shortName">The localized enumerator short name.</param>
	/// <param name="description">The localized enumerator short name.</param>
	public EnumModel(T enumValue, string name, string shortName, string description)
	{
		Enum = enumValue;
		Name = name;
		ShortName = shortName;
		Description = description;
	}

	/// <summary>
	/// The <see cref="Enum"/> property.
	/// </summary>
	/// <remarks>
	/// The enumerator itself.
	/// </remarks>
	public T Enum { get; private set; }

	/// <summary>
	/// The <see cref="Name"/> property.
	/// </summary>
	/// <remarks>
	/// The localized enumerator name.
	/// </remarks>
	public string Name { get; private set; }

	/// <summary>
	/// The <see cref="ShortName"/> property.
	/// </summary>
	/// <remarks>
	/// The localized enumerator short name.
	/// </remarks>
	public string ShortName { get; private set; }

	/// <summary>
	/// The <see cref="Description"/> property.
	/// </summary>
	/// <remarks>
	/// The localized enumerator short name.
	/// </remarks>
	public string Description { get; private set; }
}
