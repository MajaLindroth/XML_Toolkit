using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BH.oM.XML
{
    [Serializable]
    [XmlRoot(ElementName = "ImportExportRecord", IsNullable = false)]
    public class StandardWidthsObject : elmhurstXMLObject
    {
        [XmlElement("StandardWidthRec")]
        public StandardWidthRec[] standardWidthRecs = new List<StandardWidthRec> { new StandardWidthRec() }.ToArray();
    }

    [Serializable]
    [XmlRoot(ElementName = "ImportExportRecord", IsNullable = false)]
    public class StandardWidthRec : elmhurstXMLObject
    {
        [XmlElement("OpeningType")]
        public String openingType = "Door";

        [XmlElement("WidthInMilimeters")]
        public int widthInMm = 0;

        [XmlElement("SaveNewRecord")]
        public bool saveNewRecord = false;
    }
}