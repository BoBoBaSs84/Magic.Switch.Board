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
		private readonly Type type;
		private readonly XmlSerializer xmlSerializer;
		private readonly XmlWriterSettings xmlWriterSettings;
		private readonly XmlReaderSettings xmlReaderSettings;

		/// <summary>
		/// The standard constructor
		/// </summary>
		public XmlSerializerDeserializer()
		{
			type = typeof(T);
			xmlSerializer = new XmlSerializer(type);
			xmlWriterSettings = new XmlWriterSettings()
			{
				CheckCharacters = true,
				Indent = false,
				OmitXmlDeclaration = false,
				NewLineHandling = NewLineHandling.None
			};
			xmlReaderSettings = new XmlReaderSettings()
			{
				CheckCharacters = true
			};
			xmlSerializer.UnknownAttribute += OnUnknownAttribute;
			xmlSerializer.UnknownElement += OnUnknownElement;
			xmlSerializer.UnknownNode += OnUnknownNode;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="obj"></param>
		/// <param name="encoding"></param>
		/// <returns><see cref="string"/></returns>
		public string Serialize(T obj, Encoding? encoding)
		{
			encoding ??= Encoding.UTF8;
			xmlWriterSettings.Encoding = encoding;
			using StringWriter stringWriter = new StringWriterWithEncoding(encoding);
			using XmlWriter xmlWriter = XmlWriter.Create(stringWriter, xmlWriterSettings);
			xmlSerializer.Serialize(xmlWriter, obj);
			return stringWriter.ToString();
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="xmlString"></param>
		/// <returns></returns>
		public T? Deserialize(string xmlString)
		{
			try
			{
				using StringReader stringReader = new(xmlString);
				using XmlReader xmlReader = XmlReader.Create(stringReader, xmlReaderSettings);
				if (!xmlSerializer.CanDeserialize(xmlReader))
					return default;
				return (T?)xmlSerializer.Deserialize(xmlReader);
			}
			catch (Exception ex)
			{
				Console.WriteLine($"{ex.Message}");
			}
			return default;
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
