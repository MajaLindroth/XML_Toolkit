using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BH.oM.XML
{
    [Serializable]
    [XmlRoot(ElementName = "report", IsNullable = false)]
    public class DimensionObject : argyleXMLObject
    {
        [XmlElement("MAIN")]
        public MainArea main = new MainArea();
    }

    [Serializable]
    [XmlRoot(ElementName = "report", IsNullable = false)]
    public class MainArea : argyleXMLObject
    {
        [XmlElement("dimension")]
        public Dimension[] dimensions = new List<Dimension> { new Dimension() }.ToArray();
    }

    [Serializable]
    [XmlRoot(ElementName = "report", IsNullable = false)]
    public class Dimension : argyleXMLObject
    {
        [XmlElement]
        public int floor = 0;

        [XmlElement]
        public double floorArea = 74.3;

        [XmlElement]
        public double roomHeight = 2.5;

        [XmlElement]
        public String headLoosWall = ""; //Need to confirm object type

        [XmlElement]
        public String partyWallLength = ""; //Need to confirm object type
    }
}