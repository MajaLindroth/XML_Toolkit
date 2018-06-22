using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BH.oM.XML
{
    [Serializable]
    [XmlRoot(ElementName = "report", IsNullable = false)]
    public class FloObject : argyleXMLObject
    {
        [XmlElement("item")]
        public FloItem[] florItems = new List<FloItem> { new FloItem() }.ToArray();
    }

    [Serializable]
    [XmlRoot(ElementName = "report", IsNullable = false)]
    public class FloItem : argyleXMLObject
    {
        [XmlElement]
        public int storey = 0;

        [XmlElement]
        public int type = 2;

        [XmlElement]
        public double area = 74.3;

        [XmlElement]
        public double height = 2.5;

        [XmlElement]
        public double uValue = 0.16;

        [XmlElement]
        public int kValue = 80;

        [XmlElement]
        public int kValue_below = -100;

        [XmlElement]
        public String description = "";

        [XmlElement]
        public int isExposedFloor = 0;
    }
}
