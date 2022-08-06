using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Configurator.Core.Helpers
{
	/// <summary>
	/// The <see cref="XmlSerializerDeserializer{T}"/> class
	/// </summary>
	/// <typeparam name="T"></typeparam>
	internal class XmlSerializerDeserializer<T> where T : class
	{
		private readonly XmlSerializer xmlSerializer;
		private readonly XmlWriterSettings xmlWriterSettings;
		private readonly XmlReaderSettings xmlReaderSettings;

		/// <summary>
		/// The standard constructor
		/// </summary>
		public XmlSerializerDeserializer()
		{
			xmlSerializer = new XmlSerializer(typeof(T));
			xmlWriterSettings = new XmlWriterSettings() { NewLineHandling = NewLineHandling.None };
			xmlReaderSettings = new XmlReaderSettings() { IgnoreWhitespace = true };

			xmlSerializer.UnknownAttribute += OnUnknownAttribute;
			xmlSerializer.UnknownElement += OnUnknownElement;
			xmlSerializer.UnknownNode += OnUnknownNode;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="xmlString"></param>
		/// <returns></returns>
		public T? Deserialize(string xmlString)
		{
			TextReader reader = new StringReader(xmlString);
			return Deserialize(reader);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="xmlDocument"></param>
		/// <returns></returns>
		public T? Deserialize(XmlDocument xmlDocument)
		{
			TextReader reader = new StringReader(xmlDocument.OuterXml);
			return Deserialize(reader);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="textReader"></param>
		/// <returns></returns>
		public T? Deserialize(TextReader textReader)
		{
			using XmlReader xmlReader = XmlReader.Create(textReader, xmlReaderSettings);
			var obj = (T)xmlSerializer.Deserialize(xmlReader)!;
			textReader.Close();
			return obj;
		}

		/// <summary>
		/// 
		/// </summary>
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
		/// 
		/// </summary>
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
		/// 
		/// </summary>
		/// <param name="obj"></param>
		/// <param name="encoding"></param>
		/// <returns>An object of type <see cref="TextWriter"/></returns>
		public TextWriter WriterSerialize(T obj, Encoding? encoding)
		{
			encoding ??= Encoding.UTF8;
			xmlWriterSettings.Encoding = encoding;
			using StringWriter stringWriter = new StringWriterWithEncoding(encoding);
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
				XmlSerializerDeserializer<T> serializer = new();
				T? obj = serializer.Deserialize(readText);
				return obj;
			}
			catch (Exception) { }
			return default;
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
		public static bool WriteFile(string fileName, T obj, Encoding? encoding)
		{
			if (fileName is null)
				throw new ArgumentNullException(nameof(fileName));

			if (obj is null)
				throw new ArgumentNullException(nameof(obj));

			encoding ??= Encoding.UTF8;

			try
			{
				XmlSerializerDeserializer<T> serializer = new();
				string xmlString = serializer.Serialize(obj, encoding).OuterXml;
				File.WriteAllText(fileName, xmlString, encoding);
				return true;
			}
			catch (Exception) { }
			return false;
		}

		private void OnUnknownNode(object? sender, XmlNodeEventArgs e)
		{
			Console.WriteLine($"Unkown node found, name: '{e.Name}' of type: '{e.NodeType}'");
		}

		private void OnUnknownElement(object? sender, XmlElementEventArgs e)
		{
			Console.WriteLine($"Unkown element found, name: '{e.Element.Name}' at line: {e.LineNumber} position: {e.LinePosition}");
		}

		private void OnUnknownAttribute(object? sender, XmlAttributeEventArgs e)
		{
			Console.WriteLine($"Unkown attribute found, name: '{e.Attr.Name}' at line: {e.LineNumber} position: {e.LinePosition}");
		}
	}
}
