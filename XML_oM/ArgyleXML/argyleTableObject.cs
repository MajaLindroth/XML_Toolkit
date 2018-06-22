using System;
using System.Xml.Serialization;

namespace BH.oM.XML
{
    [Serializable]
    [XmlRoot(ElementName = "report", IsNullable = false)]
    public class TableObject : argyleXMLObject
    {
        [XmlElement("fuel_price")]
        public String fuelPrice = ""; //Find proper object type

        [XmlElement("indicative_cost")]
        public String indicativeCost = ""; //Find proper object type

        [XmlElement("RHI_Table")]
        public String rhiTable = ""; //Find proper object type

        [XmlElement("FIT_Table")]
        public String fitTable = ""; //Find proper object type

        [XmlElement("WindSpeed")]
        public String windSpeed = ""; //Find proper object type

        [XmlElement("AverageTemperature")]
        public String averageTemperature = ""; //Find proper object type

        [XmlElement("SolarRadiation")]
        public String solarRadiation = ""; //Find proper object type

        [XmlElement]
        public String latitude = ""; //Find proper object type

        [XmlElement("eco_measures")]
        public String ecoMeasures = ""; //Find proper object type
    }
}
