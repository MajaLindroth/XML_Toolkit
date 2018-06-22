using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BH.oM.XML
{
    [Serializable]
    [XmlRoot(ElementName = "ImportExportRecord", IsNullable = false)]
    public class SurveyorsObject : elmhurstXMLObject
    {
        [XmlElement("Surveyor")]
        public Surveyor[] surveyors = new List<Surveyor> { new Surveyor() }.ToArray();
    }

    [Serializable]
    [XmlRoot(ElementName = "ImportExportRecord", IsNullable = false)]
    public class Surveyor : elmhurstXMLObject
    {
        [XmlElement("SurveyorID")]
        public int surveyorID = 1;

        [XmlElement("Name")]
        public String name = "Admin";

        [XmlElement("Password")]
        public String password = "admin";

        [XmlElement("Title")]
        public String title = "";

        [XmlElement("FirstName")]
        public String firstName = "Admin";

        [XmlElement("Surname")]
        public String surname = "Admin";

        [XmlElement("SurnameUnaccredited")]
        public String surnameUnaccredited = "Admin (Unaccredited)";

        [XmlElement("Company")]
        public String company = "BuroHappold";

        [XmlElement("House")]
        public String house = "";

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

        [XmlElement("Telephone")]
        public String telephone = "01225 320600";

        [XmlElement("Mobile")]
        public String mobile = "";

        [XmlElement("Fax")]
        public String fax = "";

        [XmlElement("Email")]
        public String email = "a@a.com";

        [XmlElement("LastModif")]
        public DateTime lastModify = DateTime.Now;

        [XmlElement("Guid")]
        public Guid guid = Guid.NewGuid();

        [XmlElement("RegsRegion")]
        public String regsRegion = "England";
    }
}