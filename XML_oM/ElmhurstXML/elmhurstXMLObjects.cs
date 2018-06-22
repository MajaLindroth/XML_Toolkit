using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BH.oM.XML
{
    public abstract class elmhurstXMLObject
    {
    }
    [Serializable]
    [XmlRoot(ElementName = "ImportExportRecord", IsNullable = false)]

    public class ImportExportRecord : elmhurstXMLObject
    {
        [XmlElement("Version")]
        public String version = "4.05r02";

        [XmlElement("Product")]
        public String product = "Sap 2012 Desktop";

        [XmlElement("Surveyors")]
        public SurveyorsObject surveyors = new SurveyorsObject();

        [XmlElement("Properties")]
        public PropertiesObject properties = new PropertiesObject();

        [XmlElement("UvCalculations")]
        public UvCalculations uvCalculations = new UvCalculations();
    }

    [Serializable]
    [XmlRoot(ElementName = "ImportExportRecord", IsNullable = false)]
    public class UvCalculations : elmhurstXMLObject
    {
        [XmlElement("UvImages")]
        public String uvImages = "";

        [XmlElement("UvCalculations")]
        public String uvCalculations = "";
    }

}