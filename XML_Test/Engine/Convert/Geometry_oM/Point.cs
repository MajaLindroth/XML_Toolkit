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

namespace BH.Test.XML
{
    [TestClass]
    public class Point
    {
        [TestMethod]
        public void ToGBXML_Point()
        {
            BHG.Point p = new BHG.Point();
            p.X = 0;
            p.Y = 10;
            p.Z = 20;

            BHX.CartesianPoint test = p.ToGBXML();

            Assert.IsTrue(test.Coordinate.Length == 3);
            Assert.IsTrue(test.Coordinate[0] == p.X.ToString());
            Assert.IsTrue(test.Coordinate[1] == p.Y.ToString());
            Assert.IsTrue(test.Coordinate[2] == p.Z.ToString());
        }

        [TestMethod]
        public void ToBHoM_CartesianPoint_3coords()
        {
            //Test for setting 3 coordinates to a cartesian point, to see if it returns a BHoM cartesian point with the right coordinates.

            //Create cartesian point coordinates
            BHX.CartesianPoint pt = new BHX.CartesianPoint();
            string[] coords = new string[3];
            coords[0] = "1";
            coords[1] = "2";
            coords[2] = "3";
            pt.Coordinate = coords;

            //Converts to BHoM point
            BHG.Point bhomPt = pt.ToBHoM();

            //See if the coordinates are set up correctly to the point
            Assert.IsTrue(bhomPt.X == 1);
            Assert.IsTrue(bhomPt.Y == 2);
            Assert.IsTrue(bhomPt.Z == 3);
        }

        [TestMethod]
        public void ToBHoM_CartesianPoint_0coords()
        {
            //Test for 0 coordinates set on cartesian point
            BHX.CartesianPoint pt = new BHX.CartesianPoint();
            string[] coords = new string[3];

            pt.Coordinate = coords;

            BHG.Point bhomPt = pt.ToBHoM();

            Assert.IsTrue(bhomPt.X == 0);
            Assert.IsTrue(bhomPt.Y == 0);
            Assert.IsTrue(bhomPt.Z == 0);
        }

        [TestMethod]
        public void ToBHoM_CartesianPoint_1coord()
        {
            //Test for 1 coordinates set on cartesian point
            BHX.CartesianPoint pt = new BHX.CartesianPoint();
            string[] coords = new string[3];
            coords[0] = "1";

            pt.Coordinate = coords;

            BHG.Point bhomPt = pt.ToBHoM();

            Assert.IsTrue(bhomPt.X == 1);
            Assert.IsTrue(bhomPt.Y == 0);
            Assert.IsTrue(bhomPt.Z == 0);
        }

        [TestMethod]
        public void ToBHoM_CartesianPoint_2coords()
        {
            //Test for 2 coordinates set on cartesian point
            BHX.CartesianPoint pt = new BHX.CartesianPoint();
            string[] coords = new string[3];
            coords[0] = "1";
            coords[1] = "2";

            pt.Coordinate = coords;

            BHG.Point bhomPt = pt.ToBHoM();

            Assert.IsTrue(bhomPt.X == 1);
            Assert.IsTrue(bhomPt.Y == 2);
            Assert.IsTrue(bhomPt.Z == 0);
        }

        [TestMethod]
        public void ToBHoM_CartesianPoint_2coords_2Array_numbers()
        {
            //Test for 3 coordinates set on cartesian point, but the array has only two numbers
            BHX.CartesianPoint pt = new BHX.CartesianPoint();
            string[] coords = new string[2];
            coords[0] = "1";
            coords[1] = "2";

            pt.Coordinate = coords;

            BHG.Point bhomPt = pt.ToBHoM();

            Assert.IsTrue(bhomPt.X == 1);
            Assert.IsTrue(bhomPt.Y == 2);
            Assert.IsTrue(bhomPt.Z == 0);
        }

        [TestMethod]
        public void ToBHoM_CartesianPoint_double()
        {
            BHX.CartesianPoint pt = new BHX.CartesianPoint();
            string[] coords = new string[3];
            coords[0] = "1.12345";
            coords[1] = "2.38909";
            coords[2] = "3.84909";
            pt.Coordinate = coords;

            BHG.Point bhomPt = pt.ToBHoM();

            Assert.IsTrue(bhomPt.X == 1.12345);
            Assert.IsTrue(bhomPt.Y == 2.38909);
            Assert.IsTrue(bhomPt.Z == 3.84909);
        }

        [TestMethod]
        public void ToBHoM_CartesianPoint_stress()
        {
            Random rand = new Random();
            for (int i = 0; i < 1000; i++)
            {
                BHX.CartesianPoint pt = new BHX.CartesianPoint();
                string[] coords = new string[3];
                coords[0] = (rand.NextDouble() * 100).ToString();
                coords[1] = (rand.NextDouble() * 100).ToString();
                coords[2] = (rand.NextDouble() * 100).ToString();
                pt.Coordinate = coords;

                BHG.Point bhomPt = pt.ToBHoM();
                Assert.IsTrue(bhomPt.X == (System.Convert.ToDouble(coords[0])));
                Assert.IsTrue(bhomPt.Y == (System.Convert.ToDouble(coords[1])));
                Assert.IsTrue(bhomPt.Z == (System.Convert.ToDouble(coords[2])));
            }
        }
    }
}
