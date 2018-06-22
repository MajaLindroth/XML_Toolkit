using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BH.oM.XML
{
    [Serializable]
    [XmlRoot(ElementName = "ImportExportRecord", IsNullable = false)]
    public class PropertiesObject : elmhurstXMLObject
    {
        [XmlElement("PropertyRec")]
        public PropertyRec pRec = new PropertyRec();
    }

    [Serializable]
    [XmlRoot(ElementName = "ImportExportRecord", IsNullable = false)]
    public class PropertyRec : elmhurstXMLObject
    {
        [XmlElement("Property")]
        public PropertyObject property = new PropertyObject();

        [XmlElement("Surveys")]
        public SurveysObject surveysObject = new SurveysObject();
    }
}