using System;
using System.Xml.Serialization;

namespace BH.oM.XML
{
    [Serializable]
    [XmlRoot(ElementName = "report", IsNullable = false)]
    public class SehsObject : argyleXMLObject
    {
        [XmlElement]
        public int heatingCategory = 10;

        [XmlElement]
        public int dataSource = 3;

        [XmlElement]
        public int heatingDescription = 633;

        [XmlElement]
        public int fuel = 20;

        [XmlElement]
        public int flue = 1;

        [XmlElement("HETASApproved")]
        public bool hetasApproved = true;

        [XmlElement]
        public int declaredEfficiency = -100;
    }
}
