using System;
using System.Xml.Serialization;

namespace BH.oM.XML
{
    [Serializable]
    [XmlRoot(ElementName = "report", IsNullable = false)]
    public class VentilationObject : argyleXMLObject
    {
        [XmlElement]
        public int chimneyCount = 0;

        [XmlElement]
        public int openFlueCount = 1;

        [XmlElement]
        public int intermittentFansCount = 3;

        [XmlElement]
        public int passiveVentcount = 0;

        [XmlElement]
        public int fluelessGasFireCount = 0;

        [XmlElement]
        public int shelteredSidesCount = 2;

        [XmlElement]
        public int pressureTest = 2;

        [XmlElement]
        public int q50 = 4;

        [XmlElement]
        public String percentageOfDraughtProofed = ""; //Find proper object type

        [XmlElement]
        public bool hasDraughtLobby = false;

        [XmlElement]
        public String floorType = "";

        [XmlElement]
        public String wallType = "";

        [XmlElement]
        public String mechanicalSFP = "";

        [XmlElement]
        public String isMechanicalVentApproved = "";

        [XmlElement]
        public string makeModel = "";

        [XmlElement]
        public int wetRoomCount = -100;

        [XmlElement]
        public string mechanicalVentDuctsIndex = "";

        [XmlElement]
        public int kitchenRoomFansCount = -100;

        [XmlElement]
        public int kitchenRoomFansPower = -100;

        [XmlElement]
        public int nonKitchenRoomFansCount = -100;

        [XmlElement]
        public int nonKitchenRoomFansPower = -100;

        [XmlElement]
        public int kitchenDuctFansCount = -100;

        [XmlElement]
        public int kitchenDuctFansPower = -100;

        [XmlElement]
        public int nonKitchenDuctFansCount = -100;

        [XmlElement]
        public int nonKitchenDuctFansPower = -100;

        [XmlElement]
        public int kitchenWallFansCount = -100;

        [XmlElement]
        public int kitchenWallFansPower = -100;

        [XmlElement]
        public int nonKitchenWallFansCount = -100;

        [XmlElement]
        public int nonKitchenWallFansPower = -100;
    }
}
