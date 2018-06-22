using System;
using System.Xml.Serialization;

namespace BH.oM.XML
{
    [Serializable]
    [XmlRoot(ElementName = "report", IsNullable = false)]
    public class WaterHeatingSystemObject : argyleXMLObject
    {
        [XmlElement("WHS")]
        public String whs = "HWP";

        [XmlElement("WaterHeatingType")]
        public String waterHeatingType = "CommunityHeating";

        [XmlElement("LowWaterUse")]
        public bool lowWaterUse = true;

        [XmlElement("ImmersionHeaterType")]
        public String immersionHeaterType = "";

        [XmlElement("SummerImmersion")]
        public bool summerImmersion = false;

        [XmlElement("SuplementaryImmersion")]
        public bool suplementaryImmersion = false;

        [XmlElement("ImmersionOnlyHeatingHotWater")]
        public bool immersionOnlyHeatingHotwater = false;

        [XmlElement("ThermalStore")]
        public String thermalStore = "None";

        [XmlElement("ThermalStorePipework")]
        public String thermalStorePipework = "WithinASingleCasing";

        [XmlElement("HotWaterCylinder")]
        public String hotWaterCylinder = "None";

        [XmlElement("InsulationType")]
        public String insulationType = "Foam";

        [XmlElement("InsulationThickness")]
        public int insulationThickness = 160;

        [XmlElement("Volume")]
        public int volume = 100;

        [XmlElement("CylinderStat")]
        public bool cylinderStat = true;

        [XmlElement("PipeworkInsulation")]
        public String pipeworkInsulation = "FUllyInsulated";

        [XmlElement("InHeatedSpace")]
        public bool inHeatedSpace = true;

        [XmlElement("InAiringCupboard")]
        public bool inAiringCupboard = false;

        [XmlElement("SeparateTimeControl")]
        public bool separateTimeControl = false;

        [XmlElement("LossFactor")]
        public int lossFactor = 0;

        [XmlElement("SolarPanelType")]
        public String solarPanelType = "";

        [XmlElement("SolarAreaType")]
        public String solarAreaType = "";

        [XmlElement("SolarArea")]
        public double solarArea = 0;

        [XmlElement("SolarNi")]
        public double solarNi = 0;

        [XmlElement("SolarA1")]
        public double solarA1 = 0;

        [XmlElement("SolarA2")]
        public double solarA2 = 0;

        [XmlElement("SolarAGRatio")]
        public double solarAGHRatio = 0;

        [XmlElement("SolarPanelOrientation")]
        public String solarPanelOrientation = "";

        [XmlElement("SolarElevationType")]
        public String solarElevationType = "";

        [XmlElement("SolarOvershadingType")]
        public String solarOvershaingType = "";

        [XmlElement("SolarVolume")]
        public double solarVolume = 0;

        [XmlElement("SolarPumpElectricallyPowered")]
        public bool solarPumpElectricallyPowered = false;

        [XmlElement("SolarCombinedCylinder")]
        public bool solarCombinedCylinder = false;

        [XmlElement("ShowersInProperty")]
        public String showersInProperty = "NonElectricOnly";

    }
}