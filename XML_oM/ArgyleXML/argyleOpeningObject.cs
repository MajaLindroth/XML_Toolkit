using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BH.oM.XML
{
    [Serializable]
    [XmlRoot(ElementName = "report", IsNullable = false)]
    public class OpeningObject : argyleXMLObject
    {
        [XmlElement]
        public int overshading = 2;

        [XmlElement("item")]
        public OpeningItem[] openingItems = new List<OpeningItem> { new OpeningItem() }.ToArray();
    }

    [Serializable]
    [XmlRoot(ElementName = "report", IsNullable = false)]
    public class OpeningItem: argyleXMLObject
    {
        [XmlElement]
        public int id = 1;

        [XmlElement]
        public int dataSource = 2;

        [XmlElement]
        public int type = 4;

        [XmlElement]
        public int glazingType = 3;

        [XmlElement]
        public bool isArgonFilled = false;

        [XmlElement]
        public string frameType = ""; //Find proper object type

        [XmlElement]
        public String glazingGap = ""; //Find proper object type

        [XmlElement]
        public double frameFactor = 0.7;

        [XmlElement]
        public double gValue = 0.57;

        [XmlElement]
        public double uValue = 1.2;

        [XmlElement]
        public String description = "Lorem ipsum dolor sit amet";

        [XmlElement]
        public int location = 1;

        [XmlElement]
        public int orientation = 3;

        [XmlElement]
        public double width = 1.8;

        [XmlElement]
        public double height = 1.2;

        [XmlElement]
        public String pitch = ""; //Find proper object type

        [XmlElement("EPCGroupNumber")]
        public int epcGroupNumber = 1;
    }
}
