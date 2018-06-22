using System;
using System.Xml.Serialization;

namespace BH.oM.XML
{
    [Serializable]
    [XmlRoot(ElementName = "report", IsNullable = false)]
    public class WathsObject : argyleXMLObject
    {
        [XmlElement]
        public bool haSHotWaterCylinder = false;

        [XmlElement]
        public int thermalStore = 1;

        [XmlElement]
        public int cylinderVolume = -100;

        [XmlElement]
        public int heatLossSource = -100;

        [XmlElement]
        public int cylinderInsulation = -100;

        [XmlElement]
        public int cylinderThickness = -100;

        [XmlElement]
        public int measuredHeatLoss = -100;

        [XmlElement]
        public int cylinderHeadExchangeArea = -100;

        [XmlElement]
        public bool thermalStoreNearBoiler = false;

        [XmlElement]
        public bool thermalStoreOrCPSUInAiringCupboard = false;

        [XmlElement]
        public int waterHeatingCode = 901;

        [XmlElement]
        public int waterFuelCode = 1;

        [XmlElement]
        public String immersionHeatingType = ""; //Find proper object type

        [XmlElement]
        public int primaryPipeworkInsulation = -100;

        [XmlElement]
        public bool hotWaterSeparatelyTimed = false;

        [XmlElement]
        public bool hasCylinderThermostat = false;

        [XmlElement]
        public bool cylinderInHeatedSpace = false;

        [XmlElement]
        public bool immersionForSummerUse = false;

        [XmlElement]
        public fghrsItem fghrs = new fghrsItem();
    }

    [Serializable]
    [XmlRoot(ElementName = "report", IsNullable = false)]
    public class fghrsItem : argyleXMLObject
    {
        [XmlElement]
        public String fghrsIndexNo = "060024";

        [XmlElement("fghrs_data")]
        public String fghrsData = ""; //Find proper object type
    }
}
