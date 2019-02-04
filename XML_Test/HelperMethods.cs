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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BHE = BH.oM.Environment.Elements;
using BHG = BH.oM.Geometry;
using BHEG = BH.Engine.Geometry;

namespace BH.Test.XML
{
    public static class TestAssistant
    {
        public static List<BHE.BuildingElement> BuildSpace()
        {
            List<BHE.BuildingElement> elements = new List<BHE.BuildingElement>();

            BHE.BuildingElement floor = new BHE.BuildingElement();
            floor.BuildingElementProperties.BuildingElementType = BHE.BuildingElementType.Floor;
            BHG.Polyline fLine = new BHG.Polyline();
            fLine.ControlPoints.Add(BHEG.Create.Point(0, 0, 0));
            fLine.ControlPoints.Add(BHEG.Create.Point(10, 0, 0));
            fLine.ControlPoints.Add(BHEG.Create.Point(10, 10, 0));
            fLine.ControlPoints.Add(BHEG.Create.Point(0, 10, 0));
            fLine.ControlPoints.Add(fLine.ControlPoints.First());
            floor.PanelCurve = fLine;
            elements.Add(floor);

            BHE.BuildingElement roof = new BHE.BuildingElement();
            roof.BuildingElementProperties.BuildingElementType = BHE.BuildingElementType.Roof;
            BHG.Polyline rLine = new BHG.Polyline();
            rLine.ControlPoints.Add(BHEG.Create.Point(0, 0, 10));
            rLine.ControlPoints.Add(BHEG.Create.Point(10, 0, 10));
            rLine.ControlPoints.Add(BHEG.Create.Point(10, 10, 10));
            rLine.ControlPoints.Add(BHEG.Create.Point(0, 10, 10));
            rLine.ControlPoints.Add(rLine.ControlPoints.First());
            roof.PanelCurve = rLine;
            elements.Add(roof);

            for (int x = 0; x < 4; x++)
            {
                BHE.BuildingElement wall = new BHE.BuildingElement();
                wall.BuildingElementProperties.BuildingElementType = BHE.BuildingElementType.Wall;
                elements.Add(wall);
            }

            BHG.Polyline w1 = new BHG.Polyline();
            w1.ControlPoints.Add(BHEG.Create.Point(0, 0, 0));
            w1.ControlPoints.Add(BHEG.Create.Point(0, 10, 0));
            w1.ControlPoints.Add(BHEG.Create.Point(0, 10, 10));
            w1.ControlPoints.Add(BHEG.Create.Point(0, 0, 10));
            w1.ControlPoints.Add(w1.ControlPoints.First());
            elements[2].PanelCurve = w1;

            BHG.Polyline w2 = new BHG.Polyline();
            w2.ControlPoints.Add(BHEG.Create.Point(10, 0, 0));
            w2.ControlPoints.Add(BHEG.Create.Point(10, 10, 0));
            w2.ControlPoints.Add(BHEG.Create.Point(10, 10, 10));
            w2.ControlPoints.Add(BHEG.Create.Point(10, 0, 10));
            w2.ControlPoints.Add(w1.ControlPoints.First());
            elements[3].PanelCurve = w2;

            BHG.Polyline w3 = new BHG.Polyline();
            w3.ControlPoints.Add(BHEG.Create.Point(0, 0, 0));
            w3.ControlPoints.Add(BHEG.Create.Point(10, 0, 0));
            w3.ControlPoints.Add(BHEG.Create.Point(10, 0, 10));
            w3.ControlPoints.Add(BHEG.Create.Point(0, 0, 10));
            w3.ControlPoints.Add(w1.ControlPoints.First());
            elements[4].PanelCurve = w3;

            BHG.Polyline w4 = new BHG.Polyline();
            w4.ControlPoints.Add(BHEG.Create.Point(0, 10, 0));
            w4.ControlPoints.Add(BHEG.Create.Point(10, 10, 0));
            w4.ControlPoints.Add(BHEG.Create.Point(10, 10, 10));
            w4.ControlPoints.Add(BHEG.Create.Point(0, 10, 10));
            w4.ControlPoints.Add(w1.ControlPoints.First());
            elements[5].PanelCurve = w4;

            return elements;
        }

        public static List<List<BHE.BuildingElement>> BuildSpaces()
        {
            List<List<BHE.BuildingElement>> spaces = new List<List<BHE.BuildingElement>>();
            spaces.Add(BuildSpace());

            List<BHE.BuildingElement> elements = new List<BHE.BuildingElement>();

            BHE.BuildingElement floor = new BHE.BuildingElement();
            floor.BuildingElementProperties.BuildingElementType = BHE.BuildingElementType.Floor;
            BHG.Polyline fLine = new BHG.Polyline();
            fLine.ControlPoints.Add(BHEG.Create.Point(0, 10, 0));
            fLine.ControlPoints.Add(BHEG.Create.Point(0, 20, 0));
            fLine.ControlPoints.Add(BHEG.Create.Point(10, 20, 0));
            fLine.ControlPoints.Add(BHEG.Create.Point(10, 10, 0));
            fLine.ControlPoints.Add(fLine.ControlPoints.First());
            floor.PanelCurve = fLine;
            elements.Add(floor);

            BHE.BuildingElement roof = new BHE.BuildingElement();
            roof.BuildingElementProperties.BuildingElementType = BHE.BuildingElementType.Roof;
            BHG.Polyline rLine = new BHG.Polyline();
            rLine.ControlPoints.Add(BHEG.Create.Point(0, 10, 10));
            rLine.ControlPoints.Add(BHEG.Create.Point(0, 20, 10));
            rLine.ControlPoints.Add(BHEG.Create.Point(10, 20, 10));
            rLine.ControlPoints.Add(BHEG.Create.Point(10, 10, 10));
            rLine.ControlPoints.Add(rLine.ControlPoints.First());
            roof.PanelCurve = rLine;
            elements.Add(roof);

            for (int x = 0; x < 4; x++)
            {
                BHE.BuildingElement wall = new BHE.BuildingElement();
                wall.BuildingElementProperties.BuildingElementType = BHE.BuildingElementType.Wall;
                elements.Add(wall);
            }

            //Joining wall
            BHG.Polyline w1 = new BHG.Polyline();
            w1.ControlPoints.Add(BHEG.Create.Point(0, 10, 0));
            w1.ControlPoints.Add(BHEG.Create.Point(10, 10, 0));
            w1.ControlPoints.Add(BHEG.Create.Point(10, 10, 10));
            w1.ControlPoints.Add(BHEG.Create.Point(0, 10, 10));
            w1.ControlPoints.Add(w1.ControlPoints.First());
            elements[2].PanelCurve = w1;

            BHG.Polyline w2 = new BHG.Polyline();
            w2.ControlPoints.Add(BHEG.Create.Point(0, 10, 0));
            w2.ControlPoints.Add(BHEG.Create.Point(0, 20, 0));
            w2.ControlPoints.Add(BHEG.Create.Point(0, 20, 10));
            w2.ControlPoints.Add(BHEG.Create.Point(0, 10, 10));
            w2.ControlPoints.Add(w1.ControlPoints.First());
            elements[3].PanelCurve = w2;

            BHG.Polyline w3 = new BHG.Polyline();
            w3.ControlPoints.Add(BHEG.Create.Point(0, 20, 0));
            w3.ControlPoints.Add(BHEG.Create.Point(10, 20, 0));
            w3.ControlPoints.Add(BHEG.Create.Point(10, 20, 10));
            w3.ControlPoints.Add(BHEG.Create.Point(0, 20, 10));
            w3.ControlPoints.Add(w1.ControlPoints.First());
            elements[4].PanelCurve = w3;

            BHG.Polyline w4 = new BHG.Polyline();
            w4.ControlPoints.Add(BHEG.Create.Point(10, 20, 0));
            w4.ControlPoints.Add(BHEG.Create.Point(10, 10, 0));
            w4.ControlPoints.Add(BHEG.Create.Point(10, 10, 10));
            w4.ControlPoints.Add(BHEG.Create.Point(10, 20, 10));
            w4.ControlPoints.Add(w1.ControlPoints.First());
            elements[5].PanelCurve = w4;

            return spaces;
        }
    }
}
