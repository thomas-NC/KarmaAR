using System.Xml;
using System.Xml.Serialization;

public class Indice
{
    [XmlAttribute("id")]
    public string id;

    [XmlElement("content")]
    public string content;
}
