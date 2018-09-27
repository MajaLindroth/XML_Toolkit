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

        [TestMethod]
        public void XML_Adapter_Push()
        {
  //Input for XMLAdapter
            string file = "model";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            XMLAdapter adapter = new XMLAdapter(file, path);

  //Creating BHoM object

            //BHoMObject obj = new BHoMObject();
            
            IObject obj = new IObject();
            System.Collections.Generic.IEnumerable<BH.oM.Base.IObject>;

            //BH.oM.Geometry.Point obj = new oM.Geometry.Point();
            //BH.oM.Geometry.Point obj = BH.Engine.XML.Convert.ToBHoM(pt);
            //BH.oM.Base.IObject obj = BH.Engine.XML.Convert.ToBHoM(pt);

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
}





/*
// Choose object, push (object, show tag, Dictionary=items accessed by a key)
public override List<IObject> Push(IEnumerable<IObject> objects, String tag = "", Dictionary<String, object> config = null)
{
    // Boolean that shows if the push function works
    bool success = true;
    // Show type of object, choose method after that
    MethodInfo methodInfos = typeof(Enumerable).GetMethod("Cast");
    // Get every type of objects
    foreach (var typeGroup in objects.GroupBy(x => x.GetType()))
    {
        //get info of method
        MethodInfo mInfo = methodInfos.MakeGenericMethod(new[] { typeGroup.Key });
        
        var list = mInfo.Invoke(typeGroup, new object[] { typeGroup });
        success &= Create(list as dynamic, false);
    }
    // Set objects to list
    return success ? objects.ToList() : new List<IObject>();
}
*/