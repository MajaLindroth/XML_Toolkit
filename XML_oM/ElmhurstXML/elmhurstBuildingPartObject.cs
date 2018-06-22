using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BH.oM.XML
{
    [Serializable]
    [XmlRoot(ElementName = "ImportExportRecord", IsNullable = false)]
    public class BuildingPartsObject : elmhurstXMLObject
    {
        [XmlElement("BuildingPart")]
        public BuildingPart[] buildingParts= new List<BuildingPart> { new BuildingPart() }.ToArray();
    }

    [Serializable]
    [XmlRoot(ElementName = "ImportExportRecord", IsNullable = false)]
    public class BuildingPart : elmhurstXMLObject
    {
        [XmlElement("RoomInRoofFloor")]
        public int roomInRoofFloor = 0;

        [XmlElement("PropertyAgeBand")]
        public bool propertyAgeBandNil = true;

        [XmlElement("Basement")]
        public bool basement = false;

        [XmlElement("TimberFloorSealed")]
        public bool timerFloorSealed = false;

        [XmlElement("StoreyMeasurements")]
        public StoreyMeasurmenets storeyMeasurmenets = new StoreyMeasurmenets();

        [XmlElement("ExternalWalls")]
        public ExternalWalls externalWalls = new ExternalWalls();

        [XmlElement("PartyWalls")]
        public PartyWalls partyWalls = new PartyWalls();

        [XmlElement("InternalWalls")]
        public InternalWalls internalWalls = new InternalWalls();

        [XmlElement("ExternalRoofs")]
        public ExternalRoofs externalRoofs = new ExternalRoofs();

        [XmlElement("PartyRoofs")]
        public PartyRoofs partyRoofs = new PartyRoofs();

        [XmlElement("InternalCeilings")]
        public InternalCeilings internalCeilings = new InternalCeilings();

        [XmlElement("HeatlossFloors")]
        public HeatlossFloors heatlossFloors = new HeatlossFloors();

        [XmlElement("PartyFloors")]
        public PartyFloors partyFloors = new PartyFloors();

        [XmlElement("InternalFloors")]
        public InternalFloors internalFloors = new InternalFloors();
    }

    [Serializable]
    [XmlRoot(ElementName = "ImportExportRecord", IsNullable = false)]
    public class StoreyMeasurmenets : elmhurstXMLObject
    {
        [XmlElement("StoreyMeasurementRec")]
        public StoreyMeasurmenetRec[] storeyMeasurmenetRecs = new List<StoreyMeasurmenetRec> { new StoreyMeasurmenetRec() }.ToArray();
    }

    [Serializable]
    [XmlRoot(ElementName = "ImportExportRecord", IsNullable = false)]
    public class StoreyMeasurmenetRec : elmhurstXMLObject
    {
        [XmlElement("InternalPerimeter")]
        public double internalPermiter = 21.15;

        [XmlElement("InternalFloorArea")]
        public double internalFloorArea = 88.23;

        [XmlElement("StoreyHeight")]
        public double storyeHeight = 2.5;
    }

    [Serializable]
    [XmlRoot(ElementName = "ImportExportRecord", IsNullable = false)]
    public class ExternalWalls : elmhurstXMLObject
    {
        [XmlElement("WallRec")]
        public WallRec wallRec = new WallRec();
    }

    [Serializable]
    [XmlRoot(ElementName = "ImportExportRecord", IsNullable = false)]
    public class WallRec : elmhurstXMLObject
    {
        [XmlElement("Description")]
        public String description = "External Wall 1";

        [XmlElement("Type")]
        public int type = 0;

        [XmlElement("Construction")]
        public String construction = "CavityWallDensePlasterDenseLightweight";

        [XmlElement("UValue")]
        public double uValue = 0.12;

        [XmlElement("UValueCalculationID")]
        public int uValueCalculationID = 0;

        [XmlElement("UValueCalculated")]
        public double uValueCalculated = -2147483648;

        [XmlElement("KappaCalculated")]
        public double kappaCalculated = -2147483648;

        [XmlElement("ShelterFactor")]
        public int shelterFactor = 0;

        [XmlElement("ShelterCode")]
        public bool shelterCodeNil = true;

        [XmlElement("Kappa")]
        public int kappa = 140;

        [XmlElement("AreaCalculationType")]
        public String areaCalculationType = "Calculate";

        [XmlElement("Area")]
        public double area = 52.88;

        [XmlElement("OpeningsArea")]
        public double openingsArea = 18.51;

        [XmlElement("NettArea")]
        public double nettArea = 34.37;
    }

    [Serializable]
    [XmlRoot(ElementName = "ImportExportRecord", IsNullable = false)]
    public class PartyWalls : elmhurstXMLObject
    {
    }

    [Serializable]
    [XmlRoot(ElementName = "ImportExportRecord", IsNullable = false)]
    public class InternalWalls : elmhurstXMLObject
    {
    }

    [Serializable]
    [XmlRoot(ElementName = "ImportExportRecord", IsNullable = false)]
    public class ExternalRoofs : elmhurstXMLObject
    {
    }

    [Serializable]
    [XmlRoot(ElementName = "ImportExportRecord", IsNullable = false)]
    public class PartyRoofs : elmhurstXMLObject
    {
        [XmlElement("RoofRec")]
        public RoofRec roofRec = new RoofRec();
    }

    [Serializable]
    [XmlRoot(ElementName = "ImportExportRecord", IsNullable = false)]
    public class RoofRec : elmhurstXMLObject
    {
        [XmlElement("Description")]
        public String description = "Party Ceilings 1";

        [XmlElement("Type")]
        public bool typeNil = true;

        [XmlElement("StoreyIndex")]
        public int storeyIndex = 1;

        [XmlElement("Construction")]
        public String construction = "Other";

        [XmlElement("UValue")]
        public double uValue = 0;

        [XmlElement("UValueCalculationID")]
        public int uValueCalculationID = 0;

        [XmlElement("UValueCalculated")]
        public double uValueCalculated = -2147483648;

        [XmlElement("KappaCalculated")]
        public double kappCalculated = -2147483648;

        [XmlElement("ShelterFactor")]
        public int shelterFactor = 0;

        [XmlElement("ShelterCode")]
        public bool shelterCodeNil = true;

        [XmlElement("Kappa")]
        public int kappa = 0;

        [XmlElement("AreaCalculationType")]
        public bool areaCalculationTypeNil = true;

        [XmlElement("Area")]
        public double area = 88.23;

        [XmlElement("OpeningsArea")]
        public double openingsArea = 0;

        [XmlElement("NettArea")]
        public double nettArea = 0;
    }

    [Serializable]
    [XmlRoot(ElementName = "ImportExportRecord", IsNullable = false)]
    public class InternalCeilings : elmhurstXMLObject
    {
    }

    [Serializable]
    [XmlRoot(ElementName = "ImportExportRecord", IsNullable = false)]
    public class HeatlossFloors : elmhurstXMLObject
    {
    }

    [Serializable]
    [XmlRoot(ElementName = "ImportExportRecord", IsNullable = false)]
    public class PartyFloors : elmhurstXMLObject
    {
        [XmlElement("FloorRec")]
        public FloorRec floorRec = new FloorRec();
    }

    [Serializable]
    [XmlRoot(ElementName = "ImportExportRecord", IsNullable = false)]
    public class FloorRec : elmhurstXMLObject
    {
        [XmlElement("Description")]
        public String description = "Party Floor 1";

        [XmlElement("Type")]
        public int type = 0;

        [XmlElement("Construction")]
        public String construction = "Other";

        [XmlElement("UValue")]
        public double uValue = 0;

        [XmlElement("UValueCalculationID")]
        public int uValueCalculationID = 0;

        [XmlElement("UValueCalculated")]
        public double uValueCalculated = -2147483648;

        [XmlElement("KappaCalculated")]
        public double kappCalculated = -2147483648;

        [XmlElement("ShelterFactor")]
        public int shelterFactor = 0;

        [XmlElement("ShelterCode")]
        public String shelterCode = "None";

        [XmlElement("Kappa")]
        public int kappa = 0;

        [XmlElement("Area")]
        public double area = 88.23;

        [XmlElement("StoreyIndex")]
        public int storeyIndex = 1;

        [XmlElement("TimberFloorSealed")]
        public bool timerFloorSealed = false;
    }

    [Serializable]
    [XmlRoot(ElementName = "ImportExportRecord", IsNullable = false)]
    public class InternalFloors : elmhurstXMLObject
    {
    }
}