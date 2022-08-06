using System.Text;

namespace Magic.Switch.Board.Services.Helpers;

/// <inheritdoc/>
internal sealed class StringWriterHelper : StringWriter
{
	private readonly Encoding m_Encoding;

	/// <summary>
	/// The <see cref="StringWriterHelper"/> class constructor
	/// </summary>
	/// <param name="encoding"></param>
	public StringWriterHelper(Encoding encoding) : base(new StringBuilder()) => m_Encoding = encoding;

	/// <inheritdoc/>
	public override Encoding Encoding
	{
		get => m_Encoding;
	}
}