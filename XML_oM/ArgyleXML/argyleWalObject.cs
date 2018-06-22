using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BH.oM.XML
{
    [Serializable]
    [XmlRoot(ElementName = "report", IsNullable = false)]
    public class WalObject : argyleXMLObject
    {
        [XmlElement("item")]
        public WalItem[] walItems = new List<WalItem> { new WalItem() }.ToArray();
    }

    [Serializable]
    [XmlRoot(ElementName = "report", IsNullable = false)]
    public class WalItem : argyleXMLObject
    {
        [XmlElement]
        public int id = 1;

        [XmlElement]
        public String description = "";

        [XmlElement]
        public int type = 2;

        [XmlElement]
        public double area = 199.68;

        [XmlElement]
        public double uValue = 0.15;

        [XmlElement]
        public double kValue = 60;

        [XmlElement]
        public bool isCurtainWalling = false;
    }
}
