namespace Magic.Switch.Board.Core.Models;

/// <summary>
/// The <see cref="EnumModel{T}"/> class.
/// </summary>
/// <remarks>
/// The class contains all additional information about an enumerator.
/// </remarks>
/// <typeparam name="T"></typeparam>
/// <param name="enumValue">The enumerator itself.</param>
/// <param name="name">The localized enumerator name.</param>
/// <param name="shortName">The localized enumerator short name.</param>
/// <param name="description">The localized enumerator short name.</param>
public sealed class EnumModel<T>(T enumValue, string name, string shortName, string description) where T : Enum
{

	/// <summary>
	/// The <see cref="Enum"/> property.
	/// </summary>
	/// <remarks>
	/// The enumerator itself.
	/// </remarks>
	public T Enum => enumValue;

	/// <summary>
	/// The <see cref="Name"/> property.
	/// </summary>
	/// <remarks>
	/// The localized enumerator name.
	/// </remarks>
	public string Name => name;

	/// <summary>
	/// The <see cref="ShortName"/> property.
	/// </summary>
	/// <remarks>
	/// The localized enumerator short name.
	/// </remarks>
	public string ShortName => shortName;

	/// <summary>
	/// The <see cref="Description"/> property.
	/// </summary>
	/// <remarks>
	/// The localized enumerator short name.
	/// </remarks>
	public string Description => description;
}
