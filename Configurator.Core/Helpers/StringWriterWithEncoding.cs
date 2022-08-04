using System.Text;

namespace Configurator.Core.Helpers
{
	/// <inheritdoc/>
	internal class StringWriterWithEncoding : StringWriter
	{
		private readonly Encoding m_Encoding;

		/// <summary>
		/// The <see cref="StringWriterWithEncoding"/> class constructor
		/// </summary>
		/// <param name="encoding"></param>
		public StringWriterWithEncoding(Encoding encoding) : base(new StringBuilder()) => m_Encoding = encoding;

		/// <inheritdoc/>
		public override Encoding Encoding
		{
			get => m_Encoding;
		}
	}
}