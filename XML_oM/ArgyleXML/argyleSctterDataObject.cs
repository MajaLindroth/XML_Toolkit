using System;
using System.Xml.Serialization;

namespace BH.oM.XML
{
    [Serializable]
    [XmlRoot(ElementName = "report", IsNullable = false)]
    public class SctterDataObject : argyleXMLObject
    {
        [XmlElement("boilerData_mainGas")]
        public String boilerDataMainGas = ""; //Find proper object type

        [XmlElement("boilerData_LPG")]
        public String boilerDataLPG = ""; //Find proper object type

        [XmlElement("boilerData_oil")]
        public String boilerDataOil = ""; //Find proper object type

        [XmlElement("boilerData_woodPellets")]
        public String boilerDataWoodPellets = ""; //Find proper object type

        [XmlElement("controlData_mainGas")]
        public String controlDataMainGas = ""; //Find proper object type

        [XmlElement("controlData_LPG")]
        public String controlDataLPG = ""; //Find proper object type

        [XmlElement("controlData_oil")]
        public String controlDataOil = ""; //Find proper object type

        [XmlElement("wwhrsData_1")]
        public String wwhrsData1 = ""; //Find proper object type

        [XmlElement("wwhrsData_2")]
        public String wwhrsData2 = ""; //Find proper object type
    }
}
