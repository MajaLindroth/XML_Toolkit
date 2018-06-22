using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BH.oM.XML
{
    [Serializable]
    [XmlRoot(ElementName = "report", IsNullable = false)]
    public class RooObject : argyleXMLObject
    {
        [XmlElement("item")]
        public RooItem[] rooItems = new List<RooItem> { new RooItem() }.ToArray();
    }

    [Serializable]
    [XmlRoot(ElementName = "report", IsNullable = false)]
    public class RooItem : argyleXMLObject
    {
        [XmlElement]
        public int id = 1;

        [XmlElement]
        public int type = 2;

        [XmlElement]
        public double area = 74.3;

        [XmlElement]
        public double uValue = 0.12;

        [XmlElement]
        public int kValue = 9;
    }
}
