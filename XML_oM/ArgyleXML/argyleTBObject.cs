using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BH.oM.XML
{
    [Serializable]
    [XmlRoot(ElementName = "report", IsNullable = false)]
    public class TBObject : argyleXMLObject
    {
        [XmlElement]
        public int tbDataType = 5;

        [XmlElement]
        public int yValue = -100;

        [XmlElement("TMP_specified")]
        public int tmpSpecified = -100;

        [XmlElement("item")]
        public TBItem[] tbItems = new List<TBItem> { new TBItem() }.ToArray();
    }

    [Serializable]
    [XmlRoot(ElementName = "report", IsNullable = false)]
    public class TBItem : argyleXMLObject
    {
        [XmlElement]
        public String tbType = "E2";

        [XmlElement]
        public double lenegth = 20.1;

        [XmlElement]
        public int psiSource = 3;

        [XmlElement]
        public double psiValue = 0.2;
    }
}
