using System;
using System.Collections.Generic;
using System.Linq;
using BH.oM.XML;
using BH.oM.Base;
using BHE = BH.oM.Environmental.Elements;
using BHP = BH.oM.Environmental.Properties;
using BHG = BH.oM.Geometry;
using BH.Engine.Geometry;
using BH.Engine.Environment;


namespace BH.Engine.XML
{

    public static partial class Modify
    {
        /***************************************************/
        /**** Public Methods                            ****/
        /***************************************************/

        public static BHE.BuildingElement AmendSingleAdjacencies(this BHE.BuildingElement be, BHE.Building building)
        {
            if (be.AdjacentSpaces.Count == 1)
            {
                double tol = 0.01; //0.01
                List<BHE.BuildingElement> foundElements = building.BuildingElements.Where(x => x.BuildingElementGeometry.ICurve().ICollapseToPolyline(1e-06).Centre().Distance(be.BuildingElementGeometry.ICurve().ICollapseToPolyline(1e-06).Centre()) < tol).ToList();

                foreach (BHE.BuildingElement be2 in foundElements)
                {
                    if (be2.BHoM_Guid != be.BHoM_Guid)
                    {
                        foreach (Guid g in be2.AdjacentSpaces)
                            if (!be.AdjacentSpaces.Contains(g))
                                be.AdjacentSpaces.Add(g);
                    }
                }
            }

            return be;
        }

        /***************************************************/

        public static BHE.BuildingElement AmendXMLType(this BHE.BuildingElement be)
        {
            String dictionaryKey = "SAM_BuildingElementType";

            if (be.BuildingElementProperties == null)
                be.BuildingElementProperties = new BH.oM.Environmental.Properties.BuildingElementProperties();

            if (be.BuildingElementProperties.BuildingElementType == BHE.BuildingElementType.Window || be.BuildingElementProperties.BuildingElementType == BHE.BuildingElementType.Door)
                return be;

            if (!be.BuildingElementProperties.CustomData.ContainsKey(dictionaryKey))
                be.BuildingElementProperties.CustomData.Add(dictionaryKey, "");

            if (be.AdjacentSpaces.Count == 0)
                be.BuildingElementProperties.CustomData[dictionaryKey] = "Shade";
            else
            {
                double tilt = BH.Engine.Environment.Query.Tilt(be.BuildingElementGeometry);

                if (be.AdjacentSpaces.Count == 1)
                {
                    //Elements with 1 adjacent space are either exterior walls or floors
                    if (be.BuildingElementProperties.CustomData[dictionaryKey].ToString().Equals("", StringComparison.CurrentCultureIgnoreCase))
                    {
                        //New building element type - calculate wall or floor
                        if (tilt >= 70 && tilt <= 120)
                            be.BuildingElementProperties.CustomData[dictionaryKey] = "External Wall";
                        else
                            be.BuildingElementProperties.CustomData[dictionaryKey] = "Exposed Floor";
                    }
                    else if (be.BuildingElementProperties.CustomData[dictionaryKey].ToString().Equals("Internal Wall", StringComparison.CurrentCultureIgnoreCase) || (be.BuildingElementProperties.CustomData[dictionaryKey].ToString().Equals("Air", StringComparison.CurrentCultureIgnoreCase) && be.BuildingElementProperties.BuildingElementType == BHE.BuildingElementType.Wall)) //Incorrectly categorised as internal wall or air - should be external wall
                        be.BuildingElementProperties.CustomData[dictionaryKey] = "External Wall";
                    else if (be.BuildingElementProperties.CustomData[dictionaryKey].ToString().Equals("Internal Floor", StringComparison.CurrentCultureIgnoreCase) || (be.BuildingElementProperties.CustomData[dictionaryKey].ToString().Equals("Air", StringComparison.CurrentCultureIgnoreCase) && be.BuildingElementProperties.BuildingElementType == BHE.BuildingElementType.Floor))//Incorrectly categorised as internal floor or air - should be external (exposed) floor
                        be.BuildingElementProperties.CustomData[dictionaryKey] = "Exposed Floor";
                }
                else if (be.AdjacentSpaces.Count == 2)
                {
                    //Elements with 2 adjacent spaces are either internal walls or floors
                    if (be.BuildingElementProperties.CustomData[dictionaryKey].ToString().Equals("", StringComparison.CurrentCultureIgnoreCase))
                    {
                        if (tilt >= 70 && tilt <= 120)
                            be.BuildingElementProperties.CustomData[dictionaryKey] = "Internal Wall";
                        else
                            be.BuildingElementProperties.CustomData[dictionaryKey] = "Internal Floor";
                    }
                    else
                    {
                        if (be.BuildingElementProperties.CustomData[dictionaryKey].ToString().Contains("External"))
                        {
                            be.BuildingElementProperties.CustomData[dictionaryKey] = be.BuildingElementProperties.CustomData[dictionaryKey].ToString().Replace("External", "Internal");
                            be.BuildingElementProperties.Name = be.BuildingElementProperties.Name.Replace("EXT", "INT");
                        }
                        else if (be.BuildingElementProperties.CustomData[dictionaryKey].ToString().Equals("Roof", StringComparison.CurrentCultureIgnoreCase))
                            be.BuildingElementProperties.CustomData[dictionaryKey] = "Ceiling";
                        else if (be.BuildingElementProperties.CustomData[dictionaryKey].ToString().Equals("Underground Wall", StringComparison.CurrentCultureIgnoreCase))
                            be.BuildingElementProperties.CustomData[dictionaryKey] = "Internal Wall";
                        else if (be.BuildingElementProperties.CustomData[dictionaryKey].ToString().Equals("Raised Floor", StringComparison.CurrentCultureIgnoreCase) || be.BuildingElementProperties.CustomData[dictionaryKey].ToString().Equals("Exposed Floor", StringComparison.CurrentCultureIgnoreCase))
                            be.BuildingElementProperties.CustomData[dictionaryKey] = "Internal Floor";
                        else if (be.BuildingElementProperties.CustomData[dictionaryKey].ToString().Equals("Curtain Wall", StringComparison.CurrentCultureIgnoreCase))
                            be.BuildingElementProperties.CustomData[dictionaryKey] = "Internal Wall";
                    }
                }
            }

            return be;
        }

        /***************************************************/

        //public static BHE.BuildingElement AmendCadObjectID(this BHE.BuildingElement be, BHE.Building building)
        //{
        //    //if (be.CADObjectError() == null) return null; //This element does not have a CAD object error
        //    //else return be.PropertiesFromAdjSrf(be.AdjacentSurface(building), building);
        //    return be.PropertiesFromAdjSrf(be.AdjacentSurface(building), building);

        //}
        /***************************************************/

        public static List<BHE.BuildingElement> IdentifyOverlaps(this BHE.BuildingElement be, List<BHE.BuildingElement> bes)
        {
            List<BHE.BuildingElement> rtn = new List<BHE.BuildingElement>();

            BHG.Polyline be1P = be.BuildingElementGeometry.ICurve().ICollapseToPolyline(1e-06);

            foreach (BHE.BuildingElement be2 in bes)
            {
                if (be2.BHoM_Guid != be.BHoM_Guid)
                {
                    BHG.Polyline be2P = be2.BuildingElementGeometry.ICurve().ICollapseToPolyline(1e-06);
                    if (be1P.IsCoplanar(be2P))
                    {
                        List<BHG.Polyline> intersections = be1P.BooleanIntersection(be2P);
                        if (intersections.Count > 0)
                            rtn.Add(be2);
                    }
                }
            }

            return rtn;
        }

        public static BHE.BuildingElement CopyCADObj(this BHE.BuildingElement bHoMBuildingElement, List<BHE.BuildingElement> refElement, BHE.Building building)
        {
            BHE.BuildingElement newBe = new BHE.BuildingElement();
            newBe = bHoMBuildingElement.GetShallowClone() as BHE.BuildingElement;

            if (refElement == null || refElement.Count == 0)
                return newBe;

            BHE.BuildingElement be2 = refElement.Where(x => x.AdjacentSpaces.Count == bHoMBuildingElement.AdjacentSpaces.Count && x.AdjacentSpaces.AdjacencyMatch(bHoMBuildingElement.AdjacentSpaces)).FirstOrDefault();


            //1. Test with be2. If this fails - use be3. 
            if (be2 == null)
                be2 = refElement.Where(x => x.AdjacentSpaces.Count == bHoMBuildingElement.AdjacentSpaces.Count && x.AdjacentSpaces.AdjacencyIsIn(bHoMBuildingElement.AdjacentSpaces)).FirstOrDefault();

            if (be2 != null)
            {
                //1. Properties for CADObjectID
                if (be2.BuildingElementProperties != null && newBe.BuildingElementProperties != null)
                    newBe.BuildingElementProperties.Name = be2.BuildingElementProperties.Name;
                if (newBe.BuildingElementProperties == null)
                {
                    newBe.BuildingElementProperties = new BHP.BuildingElementProperties();
                    newBe.BuildingElementProperties.Name = be2.BuildingElementProperties.Name;
                }


                if (be2.CustomData.ContainsKey("Revit_elementId"))
                {
                    if (newBe.CustomData.ContainsKey("Revit_elementId"))
                        newBe.CustomData["Revit_elementId"] = be2.CustomData["Revit_elementId"];
                    else
                        newBe.CustomData.Add("Revit_elementId", be2.CustomData["Revit_elementId"]);
                }

                if (be2.BuildingElementProperties.CustomData.ContainsKey("Family Name"))
                {
                    if (newBe.CustomData.ContainsKey("Family Name"))
                        newBe.BuildingElementProperties.CustomData["Family Name"] = be2.CustomData["Family Name"];
                    else
                        newBe.BuildingElementProperties.CustomData.Add("Family Name", be2.CustomData["Family Name"]);
                }
            }
            else
            {
                //Find the space for the building element that we want to update.
                BHE.Space space = building.Spaces.Find(x => x.BHoM_Guid.ToString() == bHoMBuildingElement.AdjacentSpaces.First().ToString());

                BHE.BuildingElement be3 = space.BuildingElements.Find((x => x.AdjacentSpaces.Count == 1 && x.BHoM_Guid != bHoMBuildingElement.BHoM_Guid && x.BuildingElementGeometry.Tilt() == newBe.BuildingElementGeometry.Tilt()));

                if (be3 != null)
                {

                    //1. Properties for CADObjectID
                    if (be3.BuildingElementProperties != null && newBe.BuildingElementProperties != null)
                        newBe.BuildingElementProperties.Name = be3.BuildingElementProperties.Name;
                    if (newBe.BuildingElementProperties == null)
                    {
                        newBe.BuildingElementProperties = new BHP.BuildingElementProperties();
                        try
                        {
                            newBe.BuildingElementProperties.Name = be3.BuildingElementProperties.Name;
                        }
                        catch (Exception)
                        {
                        }
                    }

                    if (be3.CustomData.ContainsKey("Revit_elementId"))
                    {
                        if (newBe.CustomData.ContainsKey("Revit_elementId"))
                            newBe.CustomData["Revit_elementId"] = be3.CustomData["Revit_elementId"];
                        else
                            newBe.CustomData.Add("Revit_elementId", be3.CustomData["Revit_elementId"]);
                    }

                    if (be3.BuildingElementProperties.CustomData.ContainsKey("Family Name"))
                    {
                        if (newBe.CustomData.ContainsKey("Family Name"))
                            newBe.BuildingElementProperties.CustomData["Family Name"] = be3.CustomData["Family Name"];
                        else
                            newBe.BuildingElementProperties.CustomData.Add("Family Name", be3.CustomData["Family Name"]);
                    }
                }

            }
            return newBe;
        }

       
        /***************************************************/
    }
}