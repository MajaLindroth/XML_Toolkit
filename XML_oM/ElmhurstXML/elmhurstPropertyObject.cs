using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BH.oM.XML
{
    [Serializable]
    [XmlRoot(ElementName = "ImportExportRecord", IsNullable = false)]
    public class PropertyObject : elmhurstXMLObject
    {
        [XmlElement("UserReference")]
        public String userReference = "INDEX_0009";

        [XmlElement("TypeReference")]
        public String typeReference = "DA_P_3B";

        [XmlElement("HouseName")]
        public String houseName = "DA_P_3B";

        [XmlElement("HouseNumber")]
        public int houseNumber = 1;

        [XmlElement("Street")]
        public String street = "";

        [XmlElement("Locality")]
        public String locality = "";

        [XmlElement("Town")]
        public String town = "";

        [XmlElement("County")]
        public String county = "";

        [XmlElement("Postcode")]
        public String postcode = "";

        [XmlElement("Multiplier")]
        public int multiplier = 1;

        [XmlElement("Created")]
        public DateTime created = DateTime.Now;

        [XmlElement("PropertyID")]
        public int propertyID = 7509;

        [XmlElement("BlockID")]
        public bool blockIDNil = true;

        [XmlElement("Region")]
        public int region = 0;

        [XmlElement("RegsRegion")]
        public int regsRegion = 3;

        [XmlElement("ClientID")]
        public bool clientIDNil = true;

        [XmlElement("LastModif")]
        public DateTime lastModified = DateTime.Now;

        [XmlElement("Guid")]
        public Guid guid = Guid.NewGuid();

        [XmlElement("EpcLanguage")]
        public int epcLanguage = 0;

        [XmlElement("CfSHVersion")]
        public bool cfshVersionNil = true;

        [XmlElement("ProjectID")]
        public int projectID = 21;

        [XmlElement("Uprn")]
        public String uprn = "";

        [XmlElement("AddressLine1")]
        public String addressLine1 = "";

        [XmlElement("AddressLine2")]
        public String addressLine2 = "";

        [XmlElement("AddressLine3")]
        public String addressLine3 = "";

        [XmlElement("ContainsLodgedSurvey")]
        public bool containsLodgedSurvey = false;

        [XmlElement("SiteID")]
        public bool siteIDNil = true;

        [XmlElement("SurveyCount")]
        public int surveyCount = 1;
    }
}