using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BH.oM.XML;
using BHG = BH.oM.Geometry;
using BH.Engine.Geometry;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BH.Test.XML
{
    [TestClass]
    public partial class Read
    {
        /***************************************************/
        /**** PolyLoops                                 ****/
        /***************************************************/

        [TestMethod]
        public void MakeCurveGroup_RandomControlPoints()
        {
            //Arrange
            Random random = new Random();
            CartesianPoint[] xmlPts = new CartesianPoint[5]; //Test with 5 points

            for (int i = 0; i < xmlPts.Length; i++)
            {
                xmlPts[i] = new CartesianPoint();
                xmlPts[i].Coordinate = new String[3];

                xmlPts[i].Coordinate[0] = 1.ToString();
                xmlPts[i].Coordinate[1] = 2.ToString();
                xmlPts[i].Coordinate[2] = 3.ToString();

                BHG.Point bhPoint = Engine.XML.Convert.ToBHoM(xmlPts[i]);

            }
            
            //Act
            Polyloop xmlPLoop = new Polyloop() { CartesianPoint = xmlPts };
            BHG.PolyCurve bhPCurve = Adapter.gbXML.gbXMLDeserializer.MakeCurveGroup(xmlPLoop);

            //Assert - controll amount of Points. Control all of the points
            BHG.Polyline pline = bhPCurve.CollapseToPolyline(1e-06);
            Assert.IsTrue(pline.ControlPoints.Count-1 == xmlPLoop.CartesianPoint.Length);

            //TODO: Add more checks to see if the polyline matches the polyloop. And compare the pCurve (and not the pline)
          
        }

        /***************************************************/
    }
}