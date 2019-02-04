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
    public class ConstructionRoughness
    {
        [TestMethod]
        public void ToGBXML_ConstructionRoughness()
        {
            BHE.ConstructionRoughness roughness = BHE.ConstructionRoughness.MediumRough;
            BHX.Roughness test = roughness.ToGBXML();
            Assert.IsTrue(test.Value == "MediumRough");

            roughness = BHE.ConstructionRoughness.MediumSmooth;
            test = roughness.ToGBXML();
            Assert.IsTrue(test.Value == "MediumSmooth");

            roughness = BHE.ConstructionRoughness.Rough;
            test = roughness.ToGBXML();
            Assert.IsTrue(test.Value == "Rough");

            roughness = BHE.ConstructionRoughness.Smooth;
            test = roughness.ToGBXML();
            Assert.IsTrue(test.Value == "Smooth");

            roughness = BHE.ConstructionRoughness.VeryRough;
            test = roughness.ToGBXML();
            Assert.IsTrue(test.Value == "VeryRough");

            roughness = BHE.ConstructionRoughness.VerySmooth;
            test = roughness.ToGBXML();
            Assert.IsTrue(test.Value == "VerySmooth");
        }

        [TestMethod]
        public void ToBHoM_ConstructionRoughness()
        {
            BHX.Roughness roughness = new BHX.Roughness();

            roughness.Value = "MediumRough";
            BHE.ConstructionRoughness test = roughness.ToBHoM();
            Assert.IsTrue(test == BHE.ConstructionRoughness.MediumRough);

            roughness.Value = "MediumSmooth";
            test = roughness.ToBHoM();
            Assert.IsTrue(test == BHE.ConstructionRoughness.MediumSmooth);

            roughness.Value = "Rough";
            test = roughness.ToBHoM();
            Assert.IsTrue(test == BHE.ConstructionRoughness.Rough);

            roughness.Value = "Smooth";
            test = roughness.ToBHoM();
            Assert.IsTrue(test == BHE.ConstructionRoughness.Smooth);

            roughness.Value = "VeryRough";
            test = roughness.ToBHoM();
            Assert.IsTrue(test == BHE.ConstructionRoughness.VeryRough);

            roughness.Value = "VerySmooth";
            test = roughness.ToBHoM();
            Assert.IsTrue(test == BHE.ConstructionRoughness.VerySmooth);

            roughness.Value = "Random String asdjklhfasdkljfsjk";
            test = roughness.ToBHoM();
            Assert.IsTrue(test == BHE.ConstructionRoughness.Undefined);
        }
    }
}
