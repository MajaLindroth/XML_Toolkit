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
    public class AbsorptanceType
    {
        [TestMethod]
        public void ToGBXML_AbsorptanceType()
        {
            BHE.AbsorptanceType type = BHE.AbsorptanceType.ExtIR;
            string test = type.ToGBXML();
            Assert.IsTrue(test == "ExtIR");

            type = BHE.AbsorptanceType.ExtSolar;
            test = type.ToGBXML();
            Assert.IsTrue(test == "ExtSolar");

            type = BHE.AbsorptanceType.ExtTotal;
            test = type.ToGBXML();
            Assert.IsTrue(test == "ExtTotal");

            type = BHE.AbsorptanceType.ExtVisible;
            test = type.ToGBXML();
            Assert.IsTrue(test == "ExtVisible");

            type = BHE.AbsorptanceType.IntIR;
            test = type.ToGBXML();
            Assert.IsTrue(test == "IntIR");

            type = BHE.AbsorptanceType.IntSolar;
            test = type.ToGBXML();
            Assert.IsTrue(test == "IntSolar");

            type = BHE.AbsorptanceType.IntTotal;
            test = type.ToGBXML();
            Assert.IsTrue(test == "IntTotal");

            type = BHE.AbsorptanceType.IntVisible;
            test = type.ToGBXML();
            Assert.IsTrue(test == "IntVisible");

            type = BHE.AbsorptanceType.Undefined;
            test = type.ToGBXML();
            Assert.IsTrue(test == "ExtIR");
        }

        [TestMethod]
        public void ToBHoM_AbsorptanceType()
        {
            string type = "ExtIR";
            BHE.AbsorptanceType test = type.ToBHoMAbsorptanceType();
            Assert.IsTrue(test == BHE.AbsorptanceType.ExtIR);

            type = "ExtSolar";
            test = type.ToBHoMAbsorptanceType();
            Assert.IsTrue(test == BHE.AbsorptanceType.ExtSolar);

            type = "ExtTotal";
            test = type.ToBHoMAbsorptanceType();
            Assert.IsTrue(test == BHE.AbsorptanceType.ExtTotal);

            type = "ExtVisible";
            test = type.ToBHoMAbsorptanceType();
            Assert.IsTrue(test == BHE.AbsorptanceType.ExtVisible);

            type = "IntIR";
            test = type.ToBHoMAbsorptanceType();
            Assert.IsTrue(test == BHE.AbsorptanceType.IntIR);

            type = "IntSolar";
            test = type.ToBHoMAbsorptanceType();
            Assert.IsTrue(test == BHE.AbsorptanceType.IntSolar);

            type = "IntTotal";
            test = type.ToBHoMAbsorptanceType();
            Assert.IsTrue(test == BHE.AbsorptanceType.IntTotal);

            type = "IntVisible";
            test = type.ToBHoMAbsorptanceType();
            Assert.IsTrue(test == BHE.AbsorptanceType.IntVisible);

            type = "RandomStringasdkljhasdkljfhasdjkl";
            test = type.ToBHoMAbsorptanceType();
            Assert.IsTrue(test == BHE.AbsorptanceType.Undefined);
        }
    }
}
