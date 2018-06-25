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
    public partial class ToGbXML
    {
        /***************************************************/
        // Public test methods - Points                 ****/
        /***************************************************/

        [TestMethod]
        public void ToGbXML_DefaultPoint()
        {
            BHG.Point bhPoint = new BHG.Point();
            Assert.IsTrue(CheckPointMatches(bhPoint));
        }

        [TestMethod]
        public void ToGbXML_RandomPoint()
        {
            Random random = new Random();
            BHG.Point bhPoint = new BHG.Point() { X = Math.Round(random.NextDouble(),10), Y = Math.Round(random.NextDouble(),10), Z = Math.Round(random.NextDouble(),10) };
            Assert.IsTrue(CheckPointMatches(bhPoint));
        }

        [TestMethod]
        public void ToGgXML_WrongAmountOfDecimals()
        {
            Random random = new Random();
            BHG.Point bhPoint = new BHG.Point() { X = random.NextDouble(), Y = random.NextDouble(), Z = random.NextDouble() };
            Assert.IsFalse(CheckPointMatches(bhPoint));
        }

        private bool CheckPointMatches(BHG.Point bhPoint)
        {
            CartesianPoint xmlPoint = Engine.XML.Convert.ToGbXML(bhPoint);
             return (bhPoint.X == System.Convert.ToDouble(xmlPoint.Coordinate[0]) && bhPoint.Y == System.Convert.ToDouble(xmlPoint.Coordinate[1]) && bhPoint.Z == System.Convert.ToDouble(xmlPoint.Coordinate[2]));
        }


        /***************************************************/
        // PolyLoops                                    ****/
        /***************************************************/

        [TestMethod]
        public void ToGbXML_ClosedPolyCurve()
        {
            //Arrange
            Random random = new Random();
            List<BHG.Point> controlPts = new List<BHG.Point>();
            for (int i = 0; i < 105; i++)
            {
                BHG.Point bhPoint = new BHG.Point() { X = Math.Round(random.NextDouble(), 10), Y = Math.Round(random.NextDouble(), 10), Z = Math.Round(random.NextDouble(), 10) };
                controlPts.Add(bhPoint);
            }
            
            BHG.Polyline bhPLine = new BHG.Polyline() { ControlPoints = controlPts };

            //Act
            Polyloop xmlPLoop = Engine.XML.Convert.ToGbXML(bhPLine, BHG.Tolerance.MicroDistance);

            //Assert - controll amount of Points. Control all of the points
            bool test = bhPLine.ControlPoints.Count == xmlPLoop.CartesianPoint.Length;
            bool test2 = true;

            foreach (BHG.Point pt in controlPts)
            {
                CartesianPoint xmlPoint = Engine.XML.Convert.ToGbXML(pt);
                test2 &= (pt.X == System.Convert.ToDouble(xmlPoint.Coordinate[0]) && pt.Y == System.Convert.ToDouble(xmlPoint.Coordinate[1]) && pt.Z == System.Convert.ToDouble(xmlPoint.Coordinate[2]));
            }

            Assert.IsTrue(test && test2);
        }
        
        /***************************************************/
    }
}