using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Magic.Switch.Board.Services.Helpers;

/// <summary>
/// The <see cref="XmlHelper{T}"/> class
/// </summary>
/// <typeparam name="T"></typeparam>
internal sealed class XmlHelper<T> where T : class
{
	private readonly XmlSerializer xmlSerializer;
	private readonly XmlWriterSettings xmlWriterSettings;
	private readonly XmlReaderSettings xmlReaderSettings;

	/// <summary>
	/// The <see cref="XmlHelper{T}"/> constructor
	/// </summary>
	public XmlHelper()
	{
		xmlSerializer = new XmlSerializer(typeof(T));
		xmlWriterSettings = new XmlWriterSettings() { NewLineHandling = NewLineHandling.None };
		xmlReaderSettings = new XmlReaderSettings() { IgnoreWhitespace = true };

		xmlSerializer.UnknownAttribute += OnUnknownAttribute;
		xmlSerializer.UnknownElement += OnUnknownElement;
		xmlSerializer.UnknownNode += OnUnknownNode;
	}

	/// <summary>
	/// The <see cref="Deserialize(string)"/> method.
	/// </summary>
	/// <remarks>
	/// Calls the <see cref="Deserialize(TextReader)"/> method.
	/// </remarks>
	/// <param name="xmlString"></param>
	/// <returns>An object of the given type.</returns>
	public T? Deserialize(string xmlString)
	{
		TextReader reader = new StringReader(xmlString);
		return Deserialize(reader);
	}

	/// <summary>
	/// The <see cref="Deserialize(XmlDocument)"/> method.
	/// </summary>
	/// <remarks>
	/// Calls the <see cref="Deserialize(TextReader)"/> method.
	/// </remarks>
	/// <param name="xmlDocument"></param>
	/// <returns>An object of the given type.</returns>
	public T? Deserialize(XmlDocument xmlDocument)
	{
		TextReader reader = new StringReader(xmlDocument.OuterXml);
		return Deserialize(reader);
	}

	/// <summary>
	/// The <see cref="Deserialize(TextReader)"/> method.
	/// </summary>
	/// <remarks>
	/// The method does the actual deserialization process.
	/// </remarks>
	/// <param name="textReader"></param>
	/// <returns>An object of the given type.</returns>
	public T? Deserialize(TextReader textReader)
	{
		using XmlReader xmlReader = XmlReader.Create(textReader, xmlReaderSettings);
		T? obj = (T)xmlSerializer.Deserialize(xmlReader)!;
		textReader.Close();
		return obj;
	}

	/// <summary>
	/// The <see cref="Serialize(T, Encoding?)"/> method.
	/// </summary>
	/// <remarks>
	/// Calls the <see cref="StringSerialize(T, Encoding?)"/> method.
	/// </remarks>
	/// <param name="obj"></param>
	/// <param name="encoding"></param>
	/// <returns>An object of type <see cref="XmlDocument"/></returns>
	public XmlDocument Serialize(T obj, Encoding? encoding)
	{
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
	/// </remarks>
	/// <param name="obj"></param>
	/// <param name="encoding"></param>
	/// <returns>An object of type <see cref="string"/></returns>
	public string StringSerialize(T obj, Encoding? encoding)
	{
		TextWriter textWriter = WriterSerialize(obj, encoding);
		string? xmlString = textWriter.ToString();
		textWriter.Close();
		if (xmlString is null)
			return string.Empty;
		return xmlString;
	}

	/// <summary>
	/// The <see cref="WriterSerialize(T, Encoding?)"/> method.
	/// </summary>
	/// <remarks>
	/// The method does the actual serialization process.
	/// Since the encoding parameter can be <see cref="Nullable"/>, it is set to <see cref="Encoding.UTF8"/> here at the latest.
	/// </remarks>
	/// <param name="obj"></param>
	/// <param name="encoding"></param>
	/// <returns>An object of type <see cref="TextWriter"/></returns>
	public TextWriter WriterSerialize(T obj, Encoding? encoding)
	{
		encoding ??= Encoding.UTF8;
		xmlWriterSettings.Encoding = encoding;
		using StringWriter stringWriter = new StringWriterHelper(encoding);
		using XmlWriter xmlWriter = XmlWriter.Create(stringWriter, xmlWriterSettings);
		xmlSerializer.Serialize(stringWriter, obj);
		stringWriter.Flush();
		return stringWriter;
	}

	/// <summary>
	/// The <see cref="ReadFile(string)"/> method deserializes the file to an object and returns the object.
	/// </summary>
	/// <remarks>
	/// File name can include the path.
	/// </remarks>
	/// <param name="fileName"></param>
	/// <returns>The object or null.</returns>
	/// <exception cref="ArgumentNullException"></exception>
	/// <exception cref="FileNotFoundException"></exception>
	/// <exception cref="XmlException"></exception>
	public static T? ReadFile(string fileName)
	{
		if (fileName is null)
			throw new ArgumentNullException(nameof(fileName));

		if (!File.Exists(fileName))
			throw new FileNotFoundException("File not found.", fileName);

		string readText = File.ReadAllText(fileName);
		if (readText is null)
			return default;

		try
		{
			XmlHelper<T> serializer = new();
			T? obj = serializer.Deserialize(readText);
			return obj;
		}
		catch (Exception ex)
		{
			throw new XmlException(ex.Message, ex.InnerException);
		}
	}

	/// <summary>
	/// The <see cref="WriteFile(string, T, Encoding?)"/> method serializes the object to file and and saves the file to disk.
	/// </summary>
	/// <remarks>
	/// File name can include the path. If encoding is null <see cref="Encoding.UTF8"/> is used.
	/// </remarks>
	/// <param name="fileName"></param>
	/// <param name="obj"></param>
	/// <param name="encoding"></param>
	/// <returns>True or false depending on the outcome.</returns>
	/// <exception cref="ArgumentNullException"></exception>
	/// <exception cref="XmlException"></exception>
	public static bool WriteFile(string fileName, T obj, Encoding? encoding)
	{
		if (fileName is null)
			throw new ArgumentNullException(nameof(fileName));

		if (obj is null)
			throw new ArgumentNullException(nameof(obj));

		encoding ??= Encoding.UTF8;

		try
		{
			XmlHelper<T> serializer = new();
			string xmlString = serializer.Serialize(obj, encoding).OuterXml;
			File.WriteAllText(fileName, xmlString, encoding);
			return true;
		}
		catch (Exception ex)
		{
			throw new XmlException(ex.Message, ex.InnerException);
		}
	}

	/// <summary>
	/// The <see cref="OnUnknownNode(object?, XmlNodeEventArgs)"/> method.
	/// </summary>
	/// <remarks>
	/// Occurs when the System.Xml.Serialization.XmlSerializer encounters an 
	/// XML node of unknown type during deserialization.
	/// </remarks>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	/// <exception cref="XmlException"></exception>
	private void OnUnknownNode(object? sender, XmlNodeEventArgs e) =>
		throw new XmlException($"Error during deserialisation. " +
			$"Unkown node found, name: '{e.Name}' of type: '{e.NodeType}'");

	/// <summary>
	/// The <see cref="OnUnknownElement(object?, XmlElementEventArgs)"/> method.
	/// </summary>
	/// <remarks>
	/// Occurs when the System.Xml.Serialization.XmlSerializer encounters an 
	/// XML element of unknown type during deserialization.
	/// </remarks>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	/// <exception cref="XmlException"></exception>
	private void OnUnknownElement(object? sender, XmlElementEventArgs e) =>
		throw new XmlException($"Error during deserialisation. " +
			$"Unkown element found, name: '{e.Element.Name}' at line: {e.LineNumber} position: {e.LinePosition}");

	/// <summary>
	/// The <see cref="OnUnknownAttribute(object?, XmlAttributeEventArgs)"/> method.
	/// </summary>
	/// <remarks>
	/// Occurs when the System.Xml.Serialization.XmlSerializer encounters an
	/// XML attribute of unknown type during deserialization.
	/// </remarks>
	/// <param name="sender"></param>
	/// <param name="e"></param>
	/// <exception cref="XmlException"></exception>
	private void OnUnknownAttribute(object? sender, XmlAttributeEventArgs e) =>
		throw new XmlException($"Error during deserialisation. " +
			$"Unkown attribute found, name: '{e.Attr.Name}' at line: {e.LineNumber} position: {e.LinePosition}");
}
