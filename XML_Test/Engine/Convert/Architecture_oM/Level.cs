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

using BHA = BH.oM.Architecture.Elements;
using BHX = BH.oM.XML;
using BHE = BH.oM.Environment.Elements;

using BH.Engine.XML;

namespace BH.Test.XML
{
    [TestClass]
    public class Level
    {
        [TestMethod]
        public void ToGBXML_Level()
        {
            BHA.Level l = new BHA.Level();
            l.Name = "Test Level";
            l.Elevation = 0;

            List<List<BHE.BuildingElement>> spaces = TestAssistant.BuildSpaces();

            BHX.BuildingStorey test = l.ToGBXML(spaces);

            Assert.IsTrue(test.PlanarGeometry.ID.Contains("level-planar-geometry"));
            Assert.IsTrue(test.Name == l.Name);
            Assert.IsTrue(test.ID == "Level-" + l.Name.Replace(" ", "").ToLower());
            Assert.IsTrue(test.Level == l.Elevation);

            Assert.IsTrue(test.PlanarGeometry.PolyLoop.CartesianPoint.Length > 0);
        }

        [TestMethod]
        public void ToBHoM_Level()
        {
            BHX.BuildingStorey l = new BHX.BuildingStorey();
            l.Name = "Test Level";
            l.Level = 0;

            BHA.Level test = l.ToBHoM();

            Assert.IsTrue(test.Name == l.Name);
            Assert.IsTrue(test.Elevation == l.Level);
        }
    }
}
