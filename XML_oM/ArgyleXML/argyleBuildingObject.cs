using System;
using System.Xml.Serialization;

namespace BH.oM.XML
{
    [Serializable]
    [XmlRoot(ElementName = "report", IsNullable = false)]
    public class BuildingDetails : argyleXMLObject
    {
        [XmlElement]
        public String uprn = "0000000000";

        [XmlElement]
        public Guid rrn = Guid.NewGuid();

        [XmlElement]
        public String posttown = "";

        [XmlElement]
        public String assessmentDate = DateTime.Now.ToShortDateString().Replace('/', '-');

        [XmlElement]
        public String inspectionDate = DateTime.Now.ToShortDateString().Replace('/', '-');

        [XmlElement]
        public String completionDate = DateTime.Now.ToShortDateString().Replace('/', '-');

        [XmlElement]
        public String registrationDate = DateTime.Now.ToShortDateString().Replace('/', '-');

        [XmlElement]
        public string tenure = "ND";

        [XmlElement]
        public int languageCode = 1;

        [XmlElement]
        public int constructionYear = DateTime.Now.Year;

        [XmlElement]
        public char sellerCommision = 'Y';

        [XmlElement]
        public String constructionAgeBand = ""; //Find suitable default

        [XmlElement]
        public int relatedPartyDisclosure = 1;

        [XmlElement("insurance")]
        public Insurance insuranceElement = new Insurance();
    }

    [Serializable]
    [XmlRoot(ElementName = "report", IsNullable = false)]
    public class Insurance : argyleXMLObject
    {
        [XmlElement]
        public String insurer = "ABC";

        [XmlElement]
        public String policyNumber = "123";

        [XmlElement]
        public String effectiveDate = DateTime.Now.ToShortDateString().Replace('/', '-');

        [XmlElement]
        public String expiryDate = DateTime.Now.ToShortDateString().Replace('/', '-');

        [XmlElement]
        public int piLimit = 0;
    }
}
