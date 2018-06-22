using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BH.oM.XML
{
    [Serializable]
    [XmlRoot(ElementName = "ImportExportRecord", IsNullable = false)]
    public class CommunityHeatingObject : elmhurstXMLObject
    {
        [XmlElement("Type")]
        public String type = "SpaceAndWaterCombined";

        [XmlElement("DistributionLossSpace")]
        public String distributionLossSpace = "Post1991Temp100";

        [XmlElement("Ctrl")]
        public String ctrl = "CCL";

        [XmlElement("DistributionLossWater")]
        public String distributionLossWater = "";

        [XmlElement("ChargingLinked")]
        public bool chargingLinked = false;

        [XmlElement("HeatSource")]
        public HeatSource heatSource = new HeatSource();

        [XmlElement("DistributionLossSpaceValue")]
        public int distributionLossSpaceValue = 0;

        [XmlElement("DistributionLossWaterValue")]
        public int distributionsLossWaterValue = 0;

        [XmlElement("SpacePCDFIndex")]
        public int spacePCDFIndex = 0;

        [XmlElement("WaterPCDFIndex")]
        public int waterPCDFIndex = 0;
        
    }

    [Serializable]
    [XmlRoot(ElementName = "ImportExportRecord", IsNullable = false)]
    public class HeatSource : elmhurstXMLObject
    {
        [XmlElement("CommunityHeatSourceRec")]
        public CommunityHeatSource[] communityHeatSources = new List<CommunityHeatSource> { new CommunityHeatSource() }.ToArray();
    }

    [Serializable]
    [XmlRoot(ElementName = "ImportExportRecord", IsNullable = false)]
    public class CommunityHeatSource : elmhurstXMLObject
    {
        [XmlElement("Source")]
        public String source = "Boilers";

        [XmlElement("Fraction")]
        public double fraction = 100;

        [XmlElement("FuelType")]
        public String fuelType = "MainsGas";

        [XmlElement("OverallEfficiency")]
        public double overallEfficiency = 91;

        [XmlElement("HeatPowerRatio")]
        public int heatPowerRatio = 0;

        [XmlElement("ElectricalEfficiency")]
        public double electricalEfficiency = 0;

        [XmlElement("HeatEfficiency")]
        public double heatEfficiency = 0;

        [XmlElement("HeatingUse")]
        public String heatingUse = "SpaceAndWater";
    }
}