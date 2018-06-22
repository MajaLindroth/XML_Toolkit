using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BH.oM.XML
{
    [Serializable]
    [XmlRoot(ElementName = "ImportExportRecord", IsNullable = false)]
    public class StandardHeightsObject : elmhurstXMLObject
    {
        [XmlElement("StandardHeightRec")]
        public StandardHeightRec[] standardHeightRecs = new List<StandardHeightRec> { new StandardHeightRec() }.ToArray();
    }

    [Serializable]
    [XmlRoot(ElementName = "ImportExportRecord", IsNullable = false)]
    public class StandardHeightRec : elmhurstXMLObject
    {
        [XmlElement("OpeningType")]
        public String openingType = "Door";

        [XmlElement("HeightInMilimeters")]
        public int heightInMm = 1200;

        [XmlElement("SaveNewRecord")]
        public bool saveNewRecord = false;
    }
}