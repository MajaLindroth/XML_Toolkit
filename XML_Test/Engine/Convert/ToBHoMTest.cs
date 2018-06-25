using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BH.oM.XML;
using BHG = BH.oM.Geometry;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BH.Test.XML
{
    [TestClass]
    public partial class ToBHoM
    {
        /***************************************************/
        // Points                                       ****/
        /***************************************************/

        [TestMethod]
        public void ToBHoM_RandomPoint()
        {
            Random random = new Random();
            CartesianPoint[] xmlPt = new CartesianPoint[1]; //Create one point
            xmlPt[0] = new CartesianPoint();
            xmlPt[0].Coordinate = new String[3];

            xmlPt[0].Coordinate[0] = 1.ToString();
            xmlPt[0].Coordinate[1] = 2.ToString();
            xmlPt[0].Coordinate[2] = 3.ToString();

            BHG.Point bhPoint = Engine.XML.Convert.ToBHoM(xmlPt[0]);
            Assert.IsTrue(bhPoint.X == System.Convert.ToDouble(xmlPt[0].Coordinate[0]) && bhPoint.Y == System.Convert.ToDouble(xmlPt[0].Coordinate[1]) && bhPoint.Z == System.Convert.ToDouble(xmlPt[0].Coordinate[2]));
        }

        /***************************************************/
        // PolyLoops                                    ****/
        /***************************************************/
       
    }
}
