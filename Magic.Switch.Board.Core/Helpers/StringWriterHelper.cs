using System.Text;
using static Magic.Switch.Board.Core.Statics;

namespace Magic.Switch.Board.Core.Helpers;

/// <inheritdoc/>
internal sealed class StringWriterHelper : StringWriter
{
	private readonly Encoding m_Encoding;

	/// <summary>
	/// The <see cref="StringWriterHelper"/> class constructor.
	/// </summary>
	/// <param name="encoding"></param>
	public StringWriterHelper(Encoding encoding)
		: base(new StringBuilder(), CurrentCulture) => m_Encoding = encoding;

	/// <inheritdoc/>
	public override Encoding Encoding => m_Encoding;
}