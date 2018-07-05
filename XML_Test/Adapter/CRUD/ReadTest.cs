using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BH.oM.XML;
using BHG = BH.oM.Geometry;
using BH.Engine.Geometry;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//TEST namespace BH.Engine.XML and do Ctrl+b test
namespace BH.Test.XML
{
    [TestClass]
    public partial class Query
    {
        /***************************************************/
        /**** PolyLoops                                 ****/
        /***************************************************/

        //    [TestMethod]
        //    public void MakeCurveGroup_RandomControlPoints()
        //    {
        //        //Arrange polyline with random points
        //        Random random = new Random();
        //        CartesianPoint[] xmlPts = new CartesianPoint[5]; //Test with 5 points
        //        List<BHG.Point> ptList = new List<BHG.Point>();

        //        for (int i = 0; i < xmlPts.Length; i++)
        //        {
        //            xmlPts[i] = new CartesianPoint();
        //            xmlPts[i].Coordinate = new String[3];

        //            xmlPts[i].Coordinate[0] = random.NextDouble().ToString(); //x
        //            xmlPts[i].Coordinate[1] = random.NextDouble().ToString(); //y
        //            xmlPts[i].Coordinate[2] = random.NextDouble().ToString(); //z

        //            BHG.Point bhPoint = Engine.XML.Convert.ToBHoM(xmlPts[i]);
        //            ptList.Add(bhPoint);
        //        }

        //        BHG.Polyline refPolyLine = new BHG.Polyline() { ControlPoints = ptList };
        //        BHG.PolyCurve refPolyCrv = BH.Engine.Geometry.Create.PolyCurve( new List<BHG.Polyline>() { refPolyLine });


        //        //Act
        //        Polyloop xmlPLoop = new Polyloop() { CartesianPoint = xmlPts };
        //        BHG.PolyCurve testCurve = Adapter.gbXML.gbXMLDeserializer.MakeCurveGroup(xmlPLoop);

        //        //Tests.
        //        bool test1 = ((testCurve.ControlPoints().Count - 1) == xmlPLoop.CartesianPoint.Length); //Amount of controlpoints: The xml PolyLoop should not contain the first point at the last index whereas the BHoM Polycurve should.
        //        bool test2 = true;
        //        for (int i = 0; i < refPolyCrv.ControlPoints().Count; i++)
        //        {
        //            test2 &= refPolyCrv.ControlPoints()[i] == testCurve.ControlPoints()[i];
        //            if (!test2) break;
        //        }

        //        //Assert
        //        Assert.IsTrue(test1 && test2);
        //    }
        //    /***************************************************/
        //}

        [TestMethod]
        public void MakeCurveGroup_RandomControlPoints2()
        {
            Assert.IsTrue(BH.Engine.XML.Test.MakeCurveGroup_RandomControlPoints());
        }
        /***************************************************/
    }
}