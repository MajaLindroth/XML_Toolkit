using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BH.Adapter.XML;
using BH.Engine.XML;
using BH.oM;
using BH.oM.Environment.Elements;
using System.Collections.Generic;

namespace XML_Test
{
    [TestClass]
    public class AdjacencyErrors
    {
        // MD this is test for AdjuscencyErros. Here we testing each line of origin function

        [TestMethod]
        public void TestAdjacencyErrors_1()
        {
            // this is test to check if null building element return null object
            BuildingElement aBuildingElement = null;
            Assert.IsNull(aBuildingElement.AdjacentError());
        }

        [TestMethod]
        public void TestAdjacencyErrors_1a()
        {
            // this is test to check if many adj spaces
            BuildingElement aBuildingElement = new BuildingElement();
            aBuildingElement.AdjacentSpaces.Add(new Guid());
            aBuildingElement.AdjacentSpaces.Add(new Guid());
            aBuildingElement.AdjacentSpaces.Add(new Guid());
            Assert.IsNotNull(aBuildingElement.AdjacentError());
        }

        [TestMethod]
        public void TestMTestAdjacencyErrors_2()
        {
            // this is to check if we have Null Building Element gbXML IF type Air is return/assigned
            BuildingElement aBuildingElement = null;
            Assert.IsTrue(aBuildingElement.AdjacentError().ToGBXMLType() == "Air");
        }

        [TestMethod]
        public void TestMTestAdjacencyErrors_3()
        {
            // this is to check if Buidling Element with adj zone return errors, shade building elements
            BuildingElement aBuildingElement = new BuildingElement();
            aBuildingElement.AdjacentSpaces.Add(new Guid());
            aBuildingElement.BuildingElementProperties = new BH.oM.Environment.Properties.BuildingElementProperties();
            aBuildingElement.BuildingElementProperties.CustomData.Add("SAM_BuildingElementType", "Shade");
            Assert.IsNotNull(aBuildingElement.AdjacentError());
        }

        [TestMethod]
        public void TestMTestAdjacencyErrors_3a()
        {
            // this is to check if Buidling Element with correct 0 adj zone return errors, shade building elements
            BuildingElement aBuildingElement = new BuildingElement();
            aBuildingElement.AdjacentSpaces = new List<Guid>();
            aBuildingElement.BuildingElementProperties = new BH.oM.Environment.Properties.BuildingElementProperties();
            aBuildingElement.BuildingElementProperties.CustomData.Add("SAM_BuildingElementType", "Shade");
            Assert.IsNull(aBuildingElement.AdjacentError());
        }

        [TestMethod]
        public void TestMTestAdjacencyErrors_4()
        {
            // this method check is adj external surface one adj zone return errors, Exterior 
            BuildingElement aBuildingElement = new BuildingElement();
            aBuildingElement.AdjacentSpaces.Add(new Guid());
            aBuildingElement.AdjacentSpaces.Add(new Guid());
            aBuildingElement.BuildingElementProperties = new BH.oM.Environment.Properties.BuildingElementProperties();
            aBuildingElement.BuildingElementProperties.CustomData.Add("SAM_BuildingElementType", "External Wall");
            Assert.IsNotNull(aBuildingElement.AdjacentError());
        }

        [TestMethod]
        public void TestMTestAdjacencyErrors_4a()
        {
            // this method check is adj external surface one adj zone return errors, Exterior 
            BuildingElement aBuildingElement = new BuildingElement();
            aBuildingElement.AdjacentSpaces.Add(new Guid());
            aBuildingElement.BuildingElementProperties = new BH.oM.Environment.Properties.BuildingElementProperties();
            aBuildingElement.BuildingElementProperties.CustomData.Add("SAM_BuildingElementType", "External Wall");
            Assert.IsNull(aBuildingElement.AdjacentError());
        }

        [TestMethod]
        public void TestMTestAdjacencyErrors_5()
        {
            // this method check is adj external surface one adj zone return errors, Roof 
            BuildingElement aBuildingElement = new BuildingElement();
            aBuildingElement.AdjacentSpaces.Add(new Guid());
            aBuildingElement.AdjacentSpaces.Add(new Guid());
            aBuildingElement.BuildingElementProperties = new BH.oM.Environment.Properties.BuildingElementProperties();
            aBuildingElement.BuildingElementProperties.CustomData.Add("SAM_BuildingElementType", "Roof");
            Assert.IsNotNull(aBuildingElement.AdjacentError());
        }

        [TestMethod]
        public void TestMTestAdjacencyErrors_5a()
        {
            // this method check is adj external surface one adj zone return errors, Roof
            BuildingElement aBuildingElement = new BuildingElement();
            aBuildingElement.AdjacentSpaces.Add(new Guid());
            aBuildingElement.BuildingElementProperties = new BH.oM.Environment.Properties.BuildingElementProperties();
            aBuildingElement.BuildingElementProperties.CustomData.Add("SAM_BuildingElementType", "Roof");
            Assert.IsNull(aBuildingElement.AdjacentError());
        }

        [TestMethod]
        public void TestMTestAdjacencyErrors_6()
        {
            // this method check is adj external surface one adj zone return errors, Raised exposed Floor 
            BuildingElement aBuildingElement = new BuildingElement();
            aBuildingElement.AdjacentSpaces.Add(new Guid());
            aBuildingElement.AdjacentSpaces.Add(new Guid());
            aBuildingElement.BuildingElementProperties = new BH.oM.Environment.Properties.BuildingElementProperties();
            aBuildingElement.BuildingElementProperties.CustomData.Add("SAM_BuildingElementType", "Raised Floor");
            Assert.IsNotNull(aBuildingElement.AdjacentError());
        }

        [TestMethod]
        public void TestMTestAdjacencyErrors_6a()
        {
            // this method check is adj external surface one adj zone return errors,  Raised exposed Floor 
            BuildingElement aBuildingElement = new BuildingElement();
            aBuildingElement.AdjacentSpaces.Add(new Guid());
            aBuildingElement.BuildingElementProperties = new BH.oM.Environment.Properties.BuildingElementProperties();
            aBuildingElement.BuildingElementProperties.CustomData.Add("SAM_BuildingElementType", "Raised Floor");
            Assert.IsNull(aBuildingElement.AdjacentError());
        }

        [TestMethod]
        public void TestMTestAdjacencyErrors_7()
        {
            // this method check is adj external surface one adj zone return errors, Slab on Grade 
            BuildingElement aBuildingElement = new BuildingElement();
            aBuildingElement.AdjacentSpaces.Add(new Guid());
            aBuildingElement.AdjacentSpaces.Add(new Guid());
            aBuildingElement.BuildingElementProperties = new BH.oM.Environment.Properties.BuildingElementProperties();
            aBuildingElement.BuildingElementProperties.CustomData.Add("SAM_BuildingElementType", "Underground Slab");
            Assert.IsNotNull(aBuildingElement.AdjacentError());
        }

        [TestMethod]
        public void TestMTestAdjacencyErrors_7a()
        {
            // this method check is adj external surface one adj zone return errors, Slab on Grade 
            BuildingElement aBuildingElement = new BuildingElement();
            aBuildingElement.AdjacentSpaces.Add(new Guid());
            aBuildingElement.BuildingElementProperties = new BH.oM.Environment.Properties.BuildingElementProperties();
            aBuildingElement.BuildingElementProperties.CustomData.Add("SAM_BuildingElementType", "Underground Slab");
            Assert.IsNull(aBuildingElement.AdjacentError());
        }

        [TestMethod]
        public void TestMTestAdjacencyErrors_8()
        {
            // this method check is adj external surface one adj zone return errors, Wall Below Grade 
            BuildingElement aBuildingElement = new BuildingElement();
            aBuildingElement.AdjacentSpaces.Add(new Guid());
            aBuildingElement.AdjacentSpaces.Add(new Guid());
            aBuildingElement.BuildingElementProperties = new BH.oM.Environment.Properties.BuildingElementProperties();
            aBuildingElement.BuildingElementProperties.CustomData.Add("SAM_BuildingElementType", "Underground Wall");
            Assert.IsNotNull(aBuildingElement.AdjacentError());
        }

        [TestMethod]
        public void TestMTestAdjacencyErrors_8a()
        {
            // this method check is adj external surface one adj zone return errors, Wall Below Grade 
            BuildingElement aBuildingElement = new BuildingElement();
            aBuildingElement.AdjacentSpaces.Add(new Guid());
            aBuildingElement.BuildingElementProperties = new BH.oM.Environment.Properties.BuildingElementProperties();
            aBuildingElement.BuildingElementProperties.CustomData.Add("SAM_BuildingElementType", "Underground Wall");
            Assert.IsNull(aBuildingElement.AdjacentError());
        }

        [TestMethod]
        public void TestMTestAdjacencyErrors_9()
        {
            // this method check is adj external surface one adj zone return errors, Wall Below Grade 
            BuildingElement aBuildingElement = new BuildingElement();
            aBuildingElement.AdjacentSpaces.Add(new Guid());
            aBuildingElement.AdjacentSpaces.Add(new Guid());
            aBuildingElement.BuildingElementProperties = new BH.oM.Environment.Properties.BuildingElementProperties();
            aBuildingElement.BuildingElementProperties.CustomData.Add("SAM_BuildingElementType", "Exposed Floor");
            Assert.IsNotNull(aBuildingElement.AdjacentError());
        }

        [TestMethod]
        public void TestMTestAdjacencyErrors_9a()
        {
            // this method check is adj external surface one adj zone return errors, Wall Below Grade 
            BuildingElement aBuildingElement = new BuildingElement();
            aBuildingElement.AdjacentSpaces.Add(new Guid());
            aBuildingElement.BuildingElementProperties = new BH.oM.Environment.Properties.BuildingElementProperties();
            aBuildingElement.BuildingElementProperties.CustomData.Add("SAM_BuildingElementType", "Exposed Floor");
            Assert.IsNull(aBuildingElement.AdjacentError());
        }

        [TestMethod]
        public void TestMTestAdjacencyErrors_10()
        {
            // this method check is adj external surface one adj zone return errors, Slab on Grade 
            BuildingElement aBuildingElement = new BuildingElement();
            aBuildingElement.AdjacentSpaces.Add(new Guid());
            aBuildingElement.AdjacentSpaces.Add(new Guid());
            aBuildingElement.BuildingElementProperties = new BH.oM.Environment.Properties.BuildingElementProperties();
            aBuildingElement.BuildingElementProperties.CustomData.Add("SAM_BuildingElementType", "Slab on Grade");
            Assert.IsNotNull(aBuildingElement.AdjacentError());
        }

        [TestMethod]
        public void TestMTestAdjacencyErrors_10a()
        {
            // this method check is adj external surface one adj zone return errors, Slab on Grade 
            BuildingElement aBuildingElement = new BuildingElement();
            aBuildingElement.AdjacentSpaces.Add(new Guid());
            aBuildingElement.BuildingElementProperties = new BH.oM.Environment.Properties.BuildingElementProperties();
            aBuildingElement.BuildingElementProperties.CustomData.Add("SAM_BuildingElementType", "Slab on Grade");
            Assert.IsNull(aBuildingElement.AdjacentError());
        }

        [TestMethod]
        public void TestMTestAdjacencyErrors_11()
        {
            // this method check is adj internal surface one adj zone return errors, Internal Wall 
            BuildingElement aBuildingElement = new BuildingElement();
            aBuildingElement.AdjacentSpaces.Add(new Guid());
            aBuildingElement.BuildingElementProperties = new BH.oM.Environment.Properties.BuildingElementProperties();
            aBuildingElement.BuildingElementProperties.CustomData.Add("SAM_BuildingElementType", "Internal Wall");
            Assert.IsNotNull(aBuildingElement.AdjacentError());
        }

        [TestMethod]
        public void TestMTestAdjacencyErrors_11a()
        {
            // this method check is adj internal surface two adj zone return no errors, Internal Wall 
            BuildingElement aBuildingElement = new BuildingElement();
            aBuildingElement.AdjacentSpaces.Add(new Guid());
            aBuildingElement.AdjacentSpaces.Add(new Guid());
            aBuildingElement.BuildingElementProperties = new BH.oM.Environment.Properties.BuildingElementProperties();
            aBuildingElement.BuildingElementProperties.CustomData.Add("SAM_BuildingElementType", "Internal Wall");
            Assert.IsNull(aBuildingElement.AdjacentError());
        }

        [TestMethod]
        public void TestMTestAdjacencyErrors_12()
        {
            // this method check is adj internal surface one adj zone return errors, Internal Ceiling 
            BuildingElement aBuildingElement = new BuildingElement();
            aBuildingElement.AdjacentSpaces.Add(new Guid());
            aBuildingElement.BuildingElementProperties = new BH.oM.Environment.Properties.BuildingElementProperties();
            aBuildingElement.BuildingElementProperties.CustomData.Add("SAM_BuildingElementType", "Internal Ceiling");
            Assert.IsNotNull(aBuildingElement.AdjacentError());
        }

        [TestMethod]
        public void TestMTestAdjacencyErrors_12a()
        {
            // this method check is adj internal surface two adj zone return no errors, Internal Ceiling 
            BuildingElement aBuildingElement = new BuildingElement();
            aBuildingElement.AdjacentSpaces.Add(new Guid());
            aBuildingElement.AdjacentSpaces.Add(new Guid());
            aBuildingElement.BuildingElementProperties = new BH.oM.Environment.Properties.BuildingElementProperties();
            aBuildingElement.BuildingElementProperties.CustomData.Add("SAM_BuildingElementType", "Internal Ceiling");
            Assert.IsNull(aBuildingElement.AdjacentError());
        }

        [TestMethod]
        public void TestMTestAdjacencyErrors_13()
        {
            // this method check is adj internal surface one adj zone return errors, Air 
            BuildingElement aBuildingElement = new BuildingElement();
            aBuildingElement.AdjacentSpaces.Add(new Guid());
            aBuildingElement.BuildingElementProperties = new BH.oM.Environment.Properties.BuildingElementProperties();
            aBuildingElement.BuildingElementProperties.CustomData.Add("SAM_BuildingElementType", "No Type");
            Assert.IsNotNull(aBuildingElement.AdjacentError());
        }

        [TestMethod]
        public void TestMTestAdjacencyErrors_13a()
        {
            // this method check is adj internal surface two adj zone return no errors, Air
            BuildingElement aBuildingElement = new BuildingElement();
            aBuildingElement.AdjacentSpaces.Add(new Guid());
            aBuildingElement.AdjacentSpaces.Add(new Guid());
            aBuildingElement.BuildingElementProperties = new BH.oM.Environment.Properties.BuildingElementProperties();
            aBuildingElement.BuildingElementProperties.CustomData.Add("SAM_BuildingElementType", "No Type");
            Assert.IsNull(aBuildingElement.AdjacentError());
        }
    }
}
