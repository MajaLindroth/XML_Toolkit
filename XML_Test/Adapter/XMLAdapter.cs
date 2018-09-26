using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BH.Adapter.XML;
using BH.Engine.XML;
using BH.oM.Environment.Elements;
using System.Collections.Generic;
using BH.oM.XML;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BH.oM.Base;
using System.Reflection;

namespace BH.Test.XML.Adapter
{
    [TestClass]
    public class XMLAdapterTest
    {
        [TestMethod]
        public void XML_Adapter_Constructor()
        {
            //Input for XMLAdapter
            string file = "model";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            
            //Create XMLAdapter properties
            XMLAdapter adapter = new XMLAdapter(file, path);

            //Tests if the properties are used in the right way
            Assert.IsTrue(adapter.GetType() == typeof(XMLAdapter));
            Assert.IsTrue(adapter.AdapterId.Equals("XML_Adapter"));
            Assert.IsTrue(adapter.FileName.Equals(file));
            Assert.IsTrue(adapter.FilePath.Equals(path));
        }
    }
}

//XMLAdapter adapter = new XMLAdapter();
//Assert.IsTrue(XMLAdapter(name, path).Equals);
//Assert.IsNotNull(XMLAdapter(name, path));
//Assert.IsTrue(XMLAdapter.Equals("x", "y"));
//Assert.IsTrue(FileName.Equals(xmlFileName));
//Assert.IsTrue(x.XML_Adapter_FileName().Equals("Filename"));
/*
[TestClass]
public class ToGBXMLTypeSurfaceType
{
    [TestMethod]
    public void SurfaceType_Rooflight()
    {
        string x = "Rooflight";
        Assert.IsTrue(x.ToGBXMLSurfaceType().Equals("OperableSkylight"));
    }
*/

// Wrong namespace?
