using System;
using System.Xml.Serialization;

namespace BH.oM.XML
{
    [Serializable]
    [XmlRoot(ElementName = "report", IsNullable = false)]
    public class MaihsObject : argyleXMLObject
    {
        [XmlElement]
        public int heatingFuel = 1;

        [XmlElement]
        public int boilerIndexNo = 16634;

        [XmlElement]
        public string boilerDataBaseName = "";

        [XmlElement("boiler_data")]
        public string boilerData = "";

        [XmlElement]
        public int heatingControl = 2106;

        [XmlElement]
        public int heatingSource = 1;

        [XmlElement]
        public int heatingFraction = 1;

        [XmlElement]
        public int heatingCategory = 2;

        [XmlElement]
        public bool centralHeatingPumpInHeatedSpace = true;

        [XmlElement]
        public int underfloorEmitterType = -100;

        [XmlElement]
        public int emitterTemperature = 0;

        [XmlElement]
        public int emitterType = 1;

        [XmlElement]
        public bool delayedStart = false;

        [XmlElement]
        public bool fixedAirConditioning = false;

        [XmlElement]
        public int pumpAge = 2;

        [XmlElement("HETASApproved")]
        public bool hetasApproved = false;

        [XmlElement]
        public int loadOrWeatherCompensation = 0;

        [XmlElement]
        public bool boilerInterlock = true;

        [XmlElement]
        public int efficiencyType = -100;

        [XmlElement]
        public int gasOilBoilerType = -100;

        [XmlElement("SolidFuelBoilerType")]
        public String solidFuelBoilerType = ""; //Find proper object type

        [XmlElement]
        public int flueType = 2;

        [XmlElement]
        public bool flueFanPresent = true;

        [XmlElement]
        public int burnerControl = -100;

        [XmlElement]
        public bool declaredCondensing = false;

        [XmlElement("CPSUOperatingTemperature")]
        public int cpsuOPeratingTemperature = -100;

        [XmlElement]
        public int combiBoilerType = -100;

        [XmlElement]
        public int caseHeatEmission = -100;

        [XmlElement]
        public bool mcsInstalledHeatpump = false;

        [XmlElement]
        public int heatTransferToWater = -100;

        [XmlElement]
        public bool oilPumpInHeatedSpace = false;
    }
}
