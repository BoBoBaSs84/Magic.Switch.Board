using System.Text;
using System.Xml;
using System.Xml.Serialization;

using Magic.Switch.Board.Core.Exceptions;

using static Magic.Switch.Board.Core.Properties.Resources;

namespace Magic.Switch.Board.Core.Helpers;

/// <summary>
/// The <see cref="XmlHelper{T}"/> class.
/// </summary>
/// <typeparam name="T">The object to transform.</typeparam>
internal sealed class XmlHelper<T> where T : class
{
	private readonly XmlSerializer _xmlSerializer;
	private readonly XmlWriterSettings _xmlWriterSettings;
	private readonly XmlReaderSettings _xmlReaderSettings;

	/// <summary>
	/// Initializes a new instance of the <see cref="XmlHelper{T}"/> class.
	/// </summary>
	public XmlHelper()
	{
		_xmlSerializer = new XmlSerializer(typeof(T));
		_xmlWriterSettings = new XmlWriterSettings()
		{
			CheckCharacters = true,
			CloseOutput = true,
			NewLineHandling = NewLineHandling.None
		};
		_xmlReaderSettings = new XmlReaderSettings()
		{
			CheckCharacters = true,
			CloseInput = true,
			IgnoreWhitespace = true
		};

		_xmlSerializer.UnknownAttribute += OnUnknownAttribute;
		_xmlSerializer.UnknownElement += OnUnknownElement;
		_xmlSerializer.UnknownNode += OnUnknownNode;
		_xmlSerializer.UnreferencedObject += OnUnreferencedObject;
	}

	/// <summary>
	/// The <see cref="Deserialize(string)"/> method.
	/// </summary>
	/// <remarks>
	/// Calls the <see cref="Deserialize(TextReader)"/> method.
	/// Will throw an exception if <paramref name="xmlString"/> is <see langword="null"/>.
	/// </remarks>
	/// <param name="xmlString"></param>
	/// <returns>An object of the given type.</returns>
	/// <exception cref="ArgumentNullException"></exception>
	public T? Deserialize(string xmlString)
	{
		if (xmlString is null)
			throw new ArgumentNullException(nameof(xmlString));

		TextReader reader = new StringReader(xmlString);
		return Deserialize(reader);
	}

	/// <summary>
	/// The <see cref="Deserialize(XmlDocument)"/> method.
	/// </summary>
	/// <remarks>
	/// Calls the <see cref="Deserialize(TextReader)"/> method.
	/// Will throw an exception if <paramref name="xmlDocument"/> is <see langword="null"/>.
	/// </remarks>
	/// <param name="xmlDocument"></param>
	/// <returns>An object of the given type.</returns>
	/// <exception cref="ArgumentNullException"></exception>
	public T? Deserialize(XmlDocument xmlDocument)
	{
		if (xmlDocument is null)
			throw new ArgumentNullException(nameof(xmlDocument));

		TextReader reader = new StringReader(xmlDocument.OuterXml);
		return Deserialize(reader);
	}

	/// <summary>
	/// The <see cref="Deserialize(TextReader)"/> method.
	/// </summary>
	/// <remarks>
	/// The method does the actual deserialization process.
	/// Will throw an exception if <paramref name="textReader"/> is <see langword="null"/>.
	/// </remarks>
	/// <param name="textReader"></param>
	/// <returns>An object of the given type.</returns>
	/// <exception cref="ArgumentNullException"></exception>
	public T? Deserialize(TextReader textReader)
	{
		if (textReader is null)
			throw new ArgumentNullException(nameof(textReader));

		using XmlReader xmlReader = XmlReader.Create(textReader, _xmlReaderSettings);
		T? obj = (T)_xmlSerializer.Deserialize(xmlReader)!;
		textReader.Close();
		return obj;
	}

	/// <summary>
	/// The <see cref="Serialize(T, Encoding?)"/> method.
	/// </summary>
	/// <remarks>
	/// Calls the <see cref="StringSerialize(T, Encoding?)"/> method.
	/// Will throw an exception if <paramref name="obj"/> is <see langword="null"/>.
	/// </remarks>
	/// <param name="obj"></param>
	/// <param name="encoding"></param>
	/// <returns>An object of type <see cref="XmlDocument"/></returns>
	/// <exception cref="ArgumentNullException"></exception>
	public XmlDocument Serialize(T obj, Encoding? encoding)
	{
		if (obj is null)
			throw new ArgumentNullException(nameof(obj));

		string xmlString = StringSerialize(obj, encoding);
		XmlDocument xmlDocument = new();
		xmlDocument.LoadXml(xmlString);
		return xmlDocument;
	}

	/// <summary>
	/// The <see cref="StringSerialize(T, Encoding?)"/> method.
	/// </summary>
	/// <remarks>
	/// Calls the <see cref="WriterSerialize(T, Encoding?)"/> method.
	/// Will throw an exception if <paramref name="obj"/> is <see langword="null"/>.
	/// </remarks>
	/// <param name="obj"></param>
	/// <param name="encoding"></param>
	/// <returns>An object of type <see cref="string"/></returns>
	/// <exception cref="ArgumentNullException"></exception>
	public string StringSerialize(T obj, Encoding? encoding)
	{
		if (obj is null)
			throw new ArgumentNullException(nameof(obj));

		TextWriter textWriter = WriterSerialize(obj, encoding);
		string? xmlString = textWriter.ToString();
		textWriter.Close();
		return xmlString is null ? string.Empty : xmlString;
	}

	/// <summary>
	/// The <see cref="WriterSerialize(T, Encoding?)"/> method.
	/// </summary>
	/// <remarks>
	/// The method does the actual serialization process.
	/// Since the encoding parameter can be <see cref="Nullable"/>, it is set to <see cref="Encoding.UTF8"/> here at the latest.
	/// Will throw an exception if <paramref name="obj"/> is <see langword="null"/>.
	/// </remarks>
	/// <param name="obj"></param>
	/// <param name="encoding"></param>
	/// <returns>An object of type <see cref="TextWriter"/></returns>
	/// <exception cref="ArgumentNullException"></exception>
	public TextWriter WriterSerialize(T obj, Encoding? encoding)
	{
		if (obj is null)
			throw new ArgumentNullException(nameof(obj));

		encoding ??= Encoding.UTF8;
		_xmlWriterSettings.Encoding = encoding;
		using StringWriter stringWriter = new StringWriterHelper(encoding);
		using XmlWriter xmlWriter = XmlWriter.Create(stringWriter, _xmlWriterSettings);
		_xmlSerializer.Serialize(stringWriter, obj);
		stringWriter.Flush();
		return stringWriter;
	}

	#region private methods
	/// <summary>
	/// The <see cref="OnUnknownNode(object?, XmlNodeEventArgs)"/> method.
	/// </summary>
	/// <remarks>
	/// Occurs when the System.Xml.Serialization.XmlSerializer encounters an 
	/// XML node of unknown type during deserialization.
	/// </remarks>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	/// <exception cref="XmlHelperException"></exception>
	private void OnUnknownNode(object? sender, XmlNodeEventArgs e)
	{
		string exceptionMessage =
			string.Format(Culture, Error_Xml_Unknown_Node, e.Name, e.NodeType);
		throw new XmlHelperException(exceptionMessage);
	}


	/// <summary>
	/// The <see cref="OnUnknownElement(object?, XmlElementEventArgs)"/> method.
	/// </summary>
	/// <remarks>
	/// Occurs when the System.Xml.Serialization.XmlSerializer encounters an 
	/// XML element of unknown type during deserialization.
	/// </remarks>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	/// <exception cref="XmlHelperException"></exception>
	private void OnUnknownElement(object? sender, XmlElementEventArgs e)
	{
		string exceptionMessage =
			string.Format(Culture, Error_Xml_Unknown_Element, e.Element.Name, e.LineNumber, e.LinePosition);
		throw new XmlHelperException(exceptionMessage);
	}


	/// <summary>
	/// The <see cref="OnUnknownAttribute(object?, XmlAttributeEventArgs)"/> method.
	/// </summary>
	/// <remarks>
	/// Occurs when the System.Xml.Serialization.XmlSerializer encounters an
	/// XML attribute of unknown type during deserialization.
	/// </remarks>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	/// <exception cref="XmlHelperException"></exception>
	private void OnUnknownAttribute(object? sender, XmlAttributeEventArgs e)
	{
		string exceptionMessage =
			string.Format(Culture, Error_Xml_Unknown_Attribute, e.Attr.Name, e.LineNumber, e.LinePosition);
		throw new XmlHelperException(exceptionMessage);
	}


	/// <summary>
	/// The <see cref="OnUnreferencedObject(object?, UnreferencedObjectEventArgs)"/> method.
	/// </summary>
	/// <remarks>
	/// Occurs during deserialization of a SOAP-encoded XML stream, when the System.Xml.Serialization.XmlSerializer
	/// encounters a recognized type that is not used or is unreferenced.
	/// </remarks>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	/// <exception cref="XmlHelperException"></exception>
	private void OnUnreferencedObject(object? sender, UnreferencedObjectEventArgs e)
	{
		string exceptionMessage =
			string.Format(Culture, Error_Xml_Unreferenced_Object, e.UnreferencedObject, e.UnreferencedId);
		throw new XmlHelperException(exceptionMessage);
	}
	#endregion
}
