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
using BH.oM.Base;
using BHoME = BH.oM.Environment.Elements;

namespace BH.oM.XML.Environment
{
    public class DocumentBuilder : BHoMObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public List<BHoME.Building> Buildings { get; set; } = new List<BHoME.Building>();
        public List<List<BHoME.Panel>> ElementsAsSpaces { get; set; } = new List<List<BHoME.Panel>>();
        public List<BHoME.Panel> ShadingElements { get; set; } = new List<BHoME.Panel>();
        public List<BH.oM.Architecture.Elements.Level> Levels { get; set; } = new List<Architecture.Elements.Level>();
        public List<BHoME.Panel> UnassignedPanels { get; set; } = new List<BHoME.Panel>();

        /***************************************************/
    }
}
