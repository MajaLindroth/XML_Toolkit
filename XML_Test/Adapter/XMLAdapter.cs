using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BH.Adapter.XML;
using BH.Engine.XML;
//using BH.oM.Environment.Elements;
using System.Collections.Generic;
using BH.oM.XML;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
using BH.oM.Base;
using System.Reflection;
using BH.oM.Geometry;
using BH.oM.Environment;
using BH.oM.Environment.Elements;
/*
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

        [TestMethod]
        public void XML_Adapter_Push()
        {
            //Input for XMLAdapter
            string file = "model";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            XMLAdapter adapter = new XMLAdapter(file, path);

            //Creating BHoM object
            double x = 21, y = 45, z = 386;
            Point obj = BH.Engine.Geometry.Create.Point(x, y, z);
            
            //Creating input for the Push function
            string key = "newKey";
            string tag = "newTag";
            Dictionary<string, object> diction = new Dictionary<string, object>();
            diction.Add(key, obj);

            //Pushes data and Asserts properties
            adapter.Push(obj, tag, diction);
            Assert.IsTrue(adapter.GetType() == typeof(adapter.Push)); 
        }
    }
}*/
