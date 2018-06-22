using System;
using System.Xml.Serialization;

namespace BH.oM.XML
{
    [Serializable]
    [XmlRoot(ElementName = "report", IsNullable = false)]
    public class WindTurbineObject : argyleXMLObject
    {
        [XmlElement]
        public int count = 0;

        [XmlElement]
        public int hubHeight = -100;

        [XmlElement]
        public int rotorDiameter = -100;

        [XmlElement]
        public int terrainType = 1;
    }
}
