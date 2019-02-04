/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2018, the respective contributors. All rights reserved.
 *
 * Each contributor holds copyright over their respective contributions.
 * The project versioning (Git) records all such contribution source information.
 *                                           
 *                                                                              
 * The BHoM is free software: you can redistribute it and/or modify         
 * it under the terms of the GNU Lesser General Public License as published by  
 * the Free Software Foundation, either version 3.0 of the License, or          
 * (at your option) any later version.                                          
 *                                                                              
 * The BHoM is distributed in the hope that it will be useful,              
 * but WITHOUT ANY WARRANTY; without even the implied warranty of               
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the                 
 * GNU Lesser General Public License for more details.                          
 *                                                                            
 * You should have received a copy of the GNU Lesser General Public License     
 * along with this code. If not, see <https://www.gnu.org/licenses/lgpl-3.0.html>.      
 */

using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using BHG = BH.oM.Geometry;
using BHX = BH.oM.XML;
using BHE = BH.oM.Environment.Elements;

using BH.Engine.XML;
using BHEG = BH.Engine.Geometry;

using System.Linq;

namespace BH.Test.XML
{
    [TestClass]
    public class Polyline
    {
        [TestMethod]
        public void ToGBXML_Polyline()
        {
            Random rand = new Random();
            BHG.Polyline pLine = new BHG.Polyline();

            for (int x = 0; x < 4; x++)
                pLine.ControlPoints.Add(BHEG.Create.Point(rand.NextDouble(), rand.NextDouble(), rand.NextDouble()));
            pLine.ControlPoints.Add(pLine.ControlPoints[0]); //Close the polyline

            BHX.Polyloop test = pLine.ToGBXML();

            Assert.IsTrue(test.CartesianPoint.Length == 4);
            for (int x = 0; x < 4; x++)
            {
                Assert.IsTrue(test.CartesianPoint[x].Coordinate[0] == Math.Round(pLine.ControlPoints[x].X, 10).ToString());
                Assert.IsTrue(test.CartesianPoint[x].Coordinate[1] == Math.Round(pLine.ControlPoints[x].Y, 10).ToString());
                Assert.IsTrue(test.CartesianPoint[x].Coordinate[2] == Math.Round(pLine.ControlPoints[x].Z, 10).ToString());
            }
        }

        [TestMethod]
        public void ToBHoM_Polyloop()
        {
            //Determines whether a looped polyline created by toBHoM with 5 points actually has it's controlpoints in the set points.   
            Random rand = new Random();
            int number = 5;
            List<BHX.CartesianPoint> pts = new List<BHX.CartesianPoint>();

            for (int x = 0; x < number; x++)
                pts.Add(BH.Engine.XML.Create.CartesianPoint(rand.NextDouble(), rand.NextDouble(), rand.NextDouble()));
            BHX.Polyloop pLoop = new BHX.Polyloop();
            pLoop.CartesianPoint = pts.ToArray();
            BHG.Polyline pLine = pLoop.ToBHoM();
            for (int x = 0; x < pLine.ControlPoints.Count - 1; x++) //Count -1 because first point is added twice as end point to pLine which gives list length greater than input length
            {
                BHG.Point p = pLine.ControlPoints[x];
                Assert.IsTrue(p.X.ToString().Equals(pts[x].Coordinate[0]));
                Assert.IsTrue(p.Y.ToString().Equals(pts[x].Coordinate[1]));
                Assert.IsTrue(p.Z.ToString().Equals(pts[x].Coordinate[2]));
            }
        }

        [TestMethod]
        public void ToBHoM_Polyloop_1pts()
        {
            // 1 point Polyloop works in the method even though it might not geometrically
            Random rand = new Random();
            int number = 1;
            List<BHX.CartesianPoint> pts = new List<BHX.CartesianPoint>();

            for (int x = 0; x < number; x++)
                pts.Add(BH.Engine.XML.Create.CartesianPoint(rand.NextDouble(), rand.NextDouble(), rand.NextDouble()));
            BHX.Polyloop pLoop = new BHX.Polyloop();
            pLoop.CartesianPoint = pts.ToArray();
            BHG.Polyline pLine = pLoop.ToBHoM();
            for (int x = 0; x < pLine.ControlPoints.Count - 1; x++)
            {
                BHG.Point p = pLine.ControlPoints[x];
                Assert.IsTrue(p.X.ToString().Equals(pts[x].Coordinate[0]));
                Assert.IsTrue(p.Y.ToString().Equals(pts[x].Coordinate[1]));
                Assert.IsTrue(p.Z.ToString().Equals(pts[x].Coordinate[2]));
            }
        }

        [TestMethod]
        public void ToBHoM_Polyloop_2pts()
        {
            //2 point Polyloop works in the method even though it might not geometrically
            Random rand = new Random();
            int number = 2;
            List<BHX.CartesianPoint> pts = new List<BHX.CartesianPoint>();

            for (int x = 0; x < number; x++)
                pts.Add(BH.Engine.XML.Create.CartesianPoint(rand.NextDouble(), rand.NextDouble(), rand.NextDouble()));
            BHX.Polyloop pLoop = new BHX.Polyloop();
            pLoop.CartesianPoint = pts.ToArray();
            BHG.Polyline pLine = pLoop.ToBHoM();
            for (int x = 0; x < pLine.ControlPoints.Count - 1; x++)
            {
                BHG.Point p = pLine.ControlPoints[x];
                Assert.IsTrue(p.X.ToString().Equals(pts[x].Coordinate[0]));
                Assert.IsTrue(p.Y.ToString().Equals(pts[x].Coordinate[1]));
                Assert.IsTrue(p.Z.ToString().Equals(pts[x].Coordinate[2]));
            }
        }

        [TestMethod]
        public void ToBHoM_Polyloop_FirstLast()
        {
            // Determines if the first and last point of the polyloop are the same point (as they should be).
            Random rand = new Random();
            int number = 10;
            List<BHX.CartesianPoint> pts = new List<BHX.CartesianPoint>();

            for (int x = 0; x < number; x++)
                pts.Add(BH.Engine.XML.Create.CartesianPoint(rand.NextDouble(), rand.NextDouble(), rand.NextDouble()));
            BHX.Polyloop pLoop = new BHX.Polyloop();
            pLoop.CartesianPoint = pts.ToArray();
            BHG.Polyline pLine = pLoop.ToBHoM();
            for (int x = 0; x < pLine.ControlPoints.Count - 1; x++)
            {
                BHG.Point p = pLine.ControlPoints[x];
                Assert.IsTrue(pLine.ControlPoints.Last().X.ToString().Equals(pLine.ControlPoints.First().X.ToString()));
                Assert.IsTrue(pLine.ControlPoints.Last().Y.ToString().Equals(pLine.ControlPoints.First().Y.ToString()));
                Assert.IsTrue(pLine.ControlPoints.Last().Z.ToString().Equals(pLine.ControlPoints.First().Z.ToString()));
            }
        }

        [TestMethod]
        public void ToBHoM_Polyloop_Stress_1000pts()
        {
            // Testing one loop with 1000 points 
            Random rand = new Random();
            int number = 1000;
            List<BHX.CartesianPoint> pts = new List<BHX.CartesianPoint>();

            for (int x = 0; x < number; x++)
                pts.Add(BH.Engine.XML.Create.CartesianPoint(rand.NextDouble() * 100, rand.NextDouble() * 100, rand.NextDouble() * 100));
            BHX.Polyloop pLoop = new BHX.Polyloop();
            pLoop.CartesianPoint = pts.ToArray();
            BHG.Polyline pLine = pLoop.ToBHoM();
            for (int x = 0; x < pLine.ControlPoints.Count - 1; x++)
            {
                BHG.Point p = pLine.ControlPoints[x];
                Assert.IsTrue(p.X.ToString().Equals(pts[x].Coordinate[0]));
                Assert.IsTrue(p.Y.ToString().Equals(pts[x].Coordinate[1]));
                Assert.IsTrue(p.Z.ToString().Equals(pts[x].Coordinate[2]));
            }
        }

        [TestMethod]
        public void ToBHoM_Polyloop_Stress_1000loops()
        {
            // Testing 1000 loops with 5 points each
            Random rand = new Random();
            int number = 5;
            for (int i = 0; i < 1000; i++)
            {
                List<BHX.CartesianPoint> pts = new List<BHX.CartesianPoint>();
                for (int j = 0; j < number; j++)
                    pts.Add(BH.Engine.XML.Create.CartesianPoint(rand.NextDouble() * 100, rand.NextDouble() * 100, rand.NextDouble() * 100));
                BHX.Polyloop pLoop = new BHX.Polyloop();
                pLoop.CartesianPoint = pts.ToArray();
                BHG.Polyline pLine = pLoop.ToBHoM();
                for (int k = 0; k < pLine.ControlPoints.Count - 1; k++)
                {
                    BHG.Point p = pLine.ControlPoints[k];
                    Assert.IsTrue(p.X.ToString().Equals(pts[k].Coordinate[0]));
                    Assert.IsTrue(p.Y.ToString().Equals(pts[k].Coordinate[1]));
                    Assert.IsTrue(p.Z.ToString().Equals(pts[k].Coordinate[2]));
                }
            }
        }
    }
}
