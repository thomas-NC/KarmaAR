using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using UnityEngine;

[XmlRoot("IndicesCollection")]
public class IndicesCollection
{
    [XmlArray("Indices")]
    [XmlArrayItem("Indice")]
    public List<Indice> indicesCollection = new List<Indice>();

    public static IndicesCollection loadData(string path)
    {
        /*XmlSerializer serializer = new XmlSerializer(typeof(IndicesCollection));
        using (FileStream stream = new FileStream(path, FileMode.Open))
        {
            IndicesCollection indices = serializer.Deserialize(stream) as IndicesCollection;
            return indices;
        }*/
       
            TextAsset monxml = Resources.Load<TextAsset>(path);
          
            XmlSerializer serializer = new XmlSerializer(typeof(IndicesCollection));

            StringReader reader = new StringReader(monxml.text);

            IndicesCollection indices = serializer.Deserialize(reader) as IndicesCollection;

            return indices;
        
        


    }
}
