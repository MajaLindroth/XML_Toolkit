using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BH.oM.XML
{
    [Serializable]
    [XmlRoot(ElementName = "ImportExportRecord", IsNullable = false)]
    public class SurveysObject : elmhurstXMLObject
    {
        [XmlElement("Survey")]
        public Survey[] surveys = new List<Survey> { new Survey() }.ToArray();
    }

    [Serializable]
    [XmlRoot(ElementName = "ImportExportRecord", IsNullable = false)]
    public class Survey : elmhurstXMLObject
    {
        [XmlElement("Status")]
        public bool statusNil = true;

        [XmlElement("SurveyID")]
        public int surveyID = 8365;

        [XmlElement("SurveyorID")]
        public int surveyorID = 1;

        [XmlElement("Guid")]
        public Guid guid = Guid.NewGuid();

        [XmlElement("LastModif")]
        public DateTime lastModify = DateTime.Now;

        [XmlElement("IsPrimary")]
        public bool isPrimary = true;

        [XmlElement("Surveyor")]
        public String surveyor = "Admin";

        [XmlElement("UserReference")]
        public String userReference = "001";

        [XmlElement("DwellingOrientation")]
        public String dwellingOrientation = "Unknown";

        [XmlElement("CalculationType")]
        public String calculationType = "NewBuildAsDesigned";

        [XmlElement("Tenure")]
        public Tenure tenure = new Tenure();

        [XmlElement("TransactionType")]
        public TransactionType tType = new TransactionType();

        [XmlElement("SimpleComplianceScotland")]
        public bool simpleComplianceScotland = false;

        [XmlElement("Created")]
        public DateTime created = DateTime.Now;

        [XmlElement("AmendmentDate")]
        public DateTime amendmentDate = DateTime.Now;

        [XmlElement("ReportIssueDate")]
        public bool reportIssueDateNil = true;

        [XmlElement("EpcLodgementDate")]
        public bool epcLodgementDateNil = true;

        [XmlElement("LastMassUpdateChange")]
        public bool lastMassUpdateChangeNil = true;

        [XmlElement("Notes")]
        public String notes = "";

        [XmlElement("PropertyType1")]
        public String propertyType1 = "Flat";

        [XmlElement("PropertyType2")]
        public String propertyType2 = "MidTerrace";

        [XmlElement("PositionOfFlat")]
        public String positionOfFlat = "MidFloorFlat";

        [XmlElement("FlatWhichFloor")]
        public int flatWhichFloor = 1;

        [XmlElement("FlatFloorsAbove")]
        public int flatFloorsAbove = 0;

        [XmlElement("NumberOfStoreys")]
        public int numberOfStoreys = 1;

        [XmlElement("DateBuilt")]
        public int dateBuilt = DateTime.Now.Year;

        [XmlElement("ShelteredSides")]
        public int shelteredSides = 3;

        [XmlElement("SunlightShade")]
        public String sunlightShade = "AverageOrUnknown";

        [XmlElement("LivingArea")]
        public double livingArea = 15.86;

        [XmlElement("ThermalMass")]
        public String thermalMass = "SimpleCalculation";

        [XmlElement("ThermalMassSimple")]
        public String thermalMassSimple = "Low";

        [XmlElement("ThermalMassValue")]
        public int thermalMassValue = 100;

        [XmlElement("ThermalBridgesCalculation")]
        public String thermalBridgesCalculation = "Default";

        [XmlElement("ThermalBridgesYvalue")]
        public double thermalBridgesYValue = 0.15;

        [XmlElement("ThermalBridgesDescription")]
        public String thermalBridgesDescription = "";

        [XmlElement("CalculateOverheating")]
        public bool calculateOverheating = true;

        [XmlElement("WindowsInHotWeather")]
        public String windowsInHotWeather = "WindowsHalfOpen";

        [XmlElement("CrossVentilation")]
        public bool crossVentilation = false;

        [XmlElement("NightVentilation")]
        public bool nightVentilation = false;

        [XmlElement("AirChangeRate")]
        public int airChangeRate = 2;

        [XmlElement("ChimneysMHS")]
        public int chimneysMHS = 0;

        [XmlElement("ChimneysSHS")]
        public int chimneysSHS = 0;

        [XmlElement("ChimneysOther")]
        public int chimneysOther = 0;

        [XmlElement("OpenFluesMHS")]
        public int openFluesMHS = 0;

        [XmlElement("OpenFluesSHS")]
        public int openFluesSHS = 0;

        [XmlElement("OpenFluesOther")]
        public int openFluesOther = 0;

        [XmlElement("IntermittentFans")]
        public int intermittentFans = 0;

        [XmlElement("PassiveVents")]
        public int passiveVents = 0;

        [XmlElement("FluelessGasFires")]
        public int fluelessGasFires = 0;

        [XmlElement("LightFittings")]
        public int lightFittings = 1;

        [XmlElement("LELFittings")]
        public int lelFittings = 1;

        [XmlElement("ExternalLightsFitted")]
        public bool externalLightsfitted = false;

        [XmlElement("ExternalLELsFitted")]
        public bool externalLELsFitted = false;

        [XmlElement("ElectricityTariff")]
        public String electricityTariff = "Standard";

        [XmlElement("SolarPanelPresent")]
        public bool solarPanelPresent = false;

        [XmlElement("PressureTest")]
        public bool pressureTest = true;

        [XmlElement("DesignedQ50")]
        public int designedQ50 = 3;

        [XmlElement("AsBuiltQ50")]
        public int asBuiltQ50 = 15;

        [XmlElement("PropertyTested")]
        public bool propertyTested = false;

        [XmlElement("SmokeControlArea")]
        public String smokeControlArea = "Unknown";

        [XmlElement("ThermallySeparated")]
        public String thermallySeparated = "NoConservatory";

        [XmlElement("DraughtProofing")]
        public int draughtProofing = 100;

        [XmlElement("DraughtLobby")]
        public bool daughtyLobby = false;

        [XmlElement("TerrainType")]
        public String terrainType = "Urban";

        [XmlElement("Floor1AreaCalculated")]
        public bool floor1AreaCalculated = false;

        [XmlElement("PhotovoltaicUnitApportionedEnergy")]
        public int photovoltaicUnitApportionedEnergy = 0;

        [XmlElement("PhotovoltaicUnitType")]
        public String photovoltaicUnitType = "None";

        [XmlElement("BuildingParts")]
        public BuildingPartsObject buildingParts = new BuildingPartsObject();

        [XmlElement("OpeningTypes")]
        public OpeningTypesObject openType = new OpeningTypesObject();

        [XmlElement("Openings")]
        public OpeningObjectElmhurst opening = new OpeningObjectElmhurst();

        [XmlElement("StandardWidths")]
        public StandardWidthsObject standardWidths = new StandardWidthsObject();

        [XmlElement("StandardHeights")]
        public StandardHeightsObject standardHeights = new StandardHeightsObject();

        [XmlElement("ThermalBridges")]
        public ThermalBridges thermalBridges = new ThermalBridges();

        [XmlElement("MechanicalVentilation")]
        public MechanicalVentilation mechanicalVentilation = new MechanicalVentilation();

        [XmlElement("MechanicalVentilationDecentralised")]
        public MechanicalVentilationDecentralised mechanicalVentilationDecentralised = new MechanicalVentilationDecentralised();

        [XmlElement("HeatingsInteraction")]
        public String heatingsInteration = "SeparatePartsOfHouse";

        [XmlElement("CommunityHeating")]
        public CommunityHeatingObject communityHeatingObject = new CommunityHeatingObject();

        [XmlElement("WaterHeatingSystem")]
        public WaterHeatingSystemObject waterHeatingSystemObject = new WaterHeatingSystemObject();

        [XmlElement("TotalRooms")]
        public int totalRooms = 0;

        [XmlElement("RelatedPartyDisclosure")]
        public RelatedPartyDisclosure relatedPartyDisclosure = new RelatedPartyDisclosure();

        [XmlElement("Recomm_E")]
        public bool recommE = true;

        [XmlElement("Recomm_N")]
        public bool recommN = true;

        [XmlElement("Recomm_U")]
        public bool recommU = true;

        [XmlElement("Recomm_V2")]
        public bool recommV2 = true;

        [XmlElement("PrintEnergyChartScotland")]
        public bool printEnergyChartScotland = true;

        [XmlElement("PrintEnergyReportScotland")]
        public bool printEnergyReportScotland = true;

        [XmlElement("IATSReference")]
        public int iatsReference = 12345678;

        [XmlElement("IATSDataExists")]
        public bool iatsDataExists = false;

        [XmlElement("IATSTestDate")]
        public bool iatsTestDateNil = true;
    }

    [Serializable]
    [XmlRoot(ElementName = "ImportExportRecord", IsNullable = false)]
    public class Tenure : elmhurstXMLObject
    {
        [XmlElement("Code")]
        public String code = "ND";

        [XmlElement("Text")]
        public String text = "Unknown";
    }

    [Serializable]
    [XmlRoot(ElementName = "ImportExportRecord", IsNullable = false)]
    public class TransactionType : elmhurstXMLObject
    {
        [XmlElement("Code")]
        public String code = "6";

        [XmlElement("Text")]
        public String text = "New dwelling";
    }

    [Serializable]
    [XmlRoot(ElementName = "ImportExportRecord", IsNullable = false)]
    public class ThermalBridges : elmhurstXMLObject
    {

    }

    [Serializable]
    [XmlRoot(ElementName = "ImportExportRecord", IsNullable = false)]
    public class MechanicalVentilation : elmhurstXMLObject
    {
        [XmlElement("DateType")]
        public String dataType = "Database";

        [XmlElement("Type")]
        public String type = "BalancedWithHeatRecovery";

        [XmlElement("SedbukRefNo")]
        public int sedbukRefNo = 500289;

        [XmlElement("ManufacturerSFP")]
        public double manufacturerSFP = 0.52;

        [XmlElement("DuctType")]
        public String ductType = "SemiRigid";

        [XmlElement("WetRooms")]
        public int wetRooms = 3;

        [XmlElement("BrandModel")]
        public String brandModel = "vv";

        [XmlElement("MVHRDuctInsulated")]
        public bool mvhrDuctInsulated = true;

        [XmlElement("MVHREfficiency")]
        public int mvhrEfficiency = 90;

        [XmlElement("ApprovedInstallation")]
        public bool approvedInstallation = true;

        [XmlElement("DuctPCDFIndex")]
        public int ductPCDFIndex = 520018;
    }

    [Serializable]
    [XmlRoot(ElementName = "ImportExportRecord", IsNullable = false)]
    public class MechanicalVentilationDecentralised : elmhurstXMLObject
    {

    }

    [Serializable]
    [XmlRoot(ElementName = "ImportExportRecord", IsNullable = false)]
    public class RelatedPartyDisclosure : elmhurstXMLObject
    {
        [XmlElement("RelatedPartyDiscosureID")] //Should this not be disclosure...? This is how it is spelt in the example file
        public int relatedPartyDisclosureID = 1;

        [XmlElement("Description")]
        public String description = "No related party";
    }
}