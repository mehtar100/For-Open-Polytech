using System.Xml.Serialization;

namespace Rakesh.Models
{
    [XmlRoot ("Data")]
    public class Company
    {
        [XmlElement ("id")]
        public  int Id { get; set; }
        [XmlElement ("name")]
        public string name { get; set; }
        [XmlElement("description")]
        public string description { get; set; }
    }
}
