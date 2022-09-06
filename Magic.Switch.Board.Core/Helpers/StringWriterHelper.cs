using System.Text;
using static Magic.Switch.Board.Core.Statics;

namespace Magic.Switch.Board.Core.Helpers;

/// <inheritdoc/>
internal sealed class StringWriterHelper : StringWriter
{
	private readonly Encoding _encoding;

	/// <summary>
	/// Initializes a new instance of the <see cref="StringWriterHelper"/> class.
	/// </summary>
	/// <param name="encoding"></param>
	public StringWriterHelper(Encoding encoding) : base(new StringBuilder(), CurrentCulture)
		=> _encoding = encoding;

	/// <inheritdoc/>
	public override Encoding Encoding => _encoding;
}
