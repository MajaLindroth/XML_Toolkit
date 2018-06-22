using System;
using System.Xml.Serialization;

namespace BH.oM.XML
{
    [Serializable]
    [XmlRoot(ElementName = "report", IsNullable = false)]
    public class GeneralDetails : argyleXMLObject
    {
        [XmlElement]
        public String country = "ENG";

        [XmlElement]
        public int region = 3;

        [XmlElement]
        public String postcode = "BD8 7LL"; //From the default file - choose a better default later

        [XmlElement]
        public int ventilationType = 1;

        [XmlElement]
        public int totalNumberOfFixedLightingOutlets = 10;

        [XmlElement]
        public int totalNumberOfLowEnergyFixedLightingOutlets = 8;

        [XmlElement]
        public double livingArea = 37.2;

        [XmlElement]
        public int dwellingDataType = 1;

        [XmlElement]
        public int dwellingOrientation = 3;

        [XmlElement]
        public int designWaterUse = -100;

        [XmlElement]
        public int transactionType = 1;

        [XmlElement]
        public int builtForm = 1;

        [XmlElement]
        public int propertyType = 1;

        [XmlElement]
        public String flatLevel = ""; //Will need to work out what type this should be later and give a default

        [XmlElement]
        public String flatDwellingsBelowCount = "";

        [XmlElement]
        public String flatDwellingsAboveCount = "";

        [XmlElement]
        public int conservatoryType = 1;

        [XmlElement]
        public String inSmokeControlArea = "Unknown";

        [XmlElement]
        public int mainHeatingSystemInteraction = -100;

        [XmlElement]
        public int electrictyTariff = 1;

        [XmlElement]
        public bool wlsLanguageEPC = false;
    }
}
