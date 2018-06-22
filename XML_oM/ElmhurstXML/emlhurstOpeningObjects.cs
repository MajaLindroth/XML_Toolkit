using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BH.oM.XML
{
    [Serializable]
    [XmlRoot(ElementName = "ImportExportRecord", IsNullable = false)]
    public class OpeningTypesObject : elmhurstXMLObject
    {
        [XmlElement("OpeningTypeRec")]
        public OpeningTypeRec openingTypeRec = new OpeningTypeRec();
    }

    [Serializable]
    [XmlRoot(ElementName = "ImportExportRecord", IsNullable = false)]
    public class OpeningTypeRec : elmhurstXMLObject
    {
        [XmlElement("Description")]
        public String description = "Opening Type 1";

        [XmlElement("DataSource")]
        public String dataSource = "BFRCdata";

        [XmlElement("Type")]
        public String type = "Window";

        [XmlElement("Glazing")]
        public String glazing = "Double";

        [XmlElement("GlazingGap")]
        public bool glazingGapNil = true;

        [XmlElement("ArgonFilled")]
        public bool argonFilled = false;

        [XmlElement("SolarTrans")]
        public double solarTrans = 0.5;

        [XmlElement("FrameType")]
        public String frameType = "Wood";

        [XmlElement("FrameFactor")]
        public double frameFactor = 0.7;

        [XmlElement("UValue")]
        public double uValue = 1.4;
    }

    [Serializable]
    [XmlRoot(ElementName = "ImportExportRecord", IsNullable = false)]
    public class OpeningObjectElmhurst : elmhurstXMLObject
    {

    }
}