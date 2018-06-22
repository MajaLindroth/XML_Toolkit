using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BH.oM.XML
{
    public abstract class argyleXMLObject
    {
    }
    [Serializable]
    [XmlRoot(ElementName = "report", IsNullable = false)]

    public class report : argyleXMLObject
    {
        [XmlElement("GEN")]
        public GeneralDetails gen = new GeneralDetails();

        [XmlElement("BuildingDetails")]
        public BuildingDetails bd = new BuildingDetails();

        [XmlElement]
        public CLA cla = new CLA();

        [XmlElement("DIM")]
        public DimensionObject dim = new DimensionObject();

        [XmlElement("VENT")]
        public VentilationObject vent = new VentilationObject();

        [XmlElement("OPEN")]
        public OpeningObject open = new OpeningObject();

        [XmlElement("FLO")]
        public FloObject flo = new FloObject();

        [XmlElement("WAL")]
        public WalObject wal = new WalObject();

        [XmlElement("ROO")]
        public RooObject roo = new RooObject();

        [XmlElement("TB")]
        public TBObject tb = new TBObject();

        [XmlElement("MAIHS")]
        public MaihsObject maihs = new MaihsObject();

        [XmlElement("WATHS")]
        public WathsObject waths = new WathsObject();

        [XmlElement("SEHS")]
        public SehsObject sehs = new SehsObject();

        [XmlElement("WindTurbine")]
        public WindTurbineObject windTurbine = new WindTurbineObject();

        [XmlElement("SpecialFeature")]
        public SpecialFeature specialFeature = new SpecialFeature();

        [XmlElement("SCTTERDATA")]
        public SctterDataObject sctterData = new SctterDataObject();

        [XmlElement("TABLE")]
        public TableObject table = new TableObject();
    }   
}
