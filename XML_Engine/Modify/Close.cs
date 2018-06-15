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

        public static BHE.Space Close(BHE.Space space, double tolerance = BHG.Tolerance.MicroDistance)
        {
            if (space == null || Query.IsClosed(space, tolerance))
                return space;

            space = space.BreakReferenceClone();
            BHE.Space closedSpace = space.GetShallowClone() as BHE.Space;
            List<BHE.BuildingElement> newBes = new List<oM.Environmental.Elements.BuildingElement>();
            foreach (BHE.BuildingElement be in closedSpace.BuildingElements)
            {
                List<BHG.Point> newPoints = new List<BHG.Point>();

                foreach (BHG.Point pt in be.BuildingElementGeometry.ICurve().ICollapseToPolyline(1e-06).IDiscontinuityPoints())
                {
                    List<BHE.BuildingElement> beCompare = space.BuildingElements.FindAll(x => x.BHoM_Guid != be.BHoM_Guid);
                    List<BHG.Point> ptsCompare = beCompare.SelectMany(x => x.BuildingElementGeometry.ICurve().ICollapseToPolyline(1e-06).DiscontinuityPoints()).ToList().CullDuplicates();
                    List<BHG.Point> p = new List<BHG.Point> { pt };

                    //Find matching building element
                    BHE.BuildingElement matchingBe = beCompare.Find(x => x.BuildingElementGeometry.ICurve().ICollapseToPolyline(1e-06).DiscontinuityPoints().ClosestDistance(p) < tolerance && (x.BHoM_Guid != be.BHoM_Guid));

                    //Find closes point in the same plane!
                    BHG.Point snapPt = new BHG.Point();
                    if (matchingBe == null)
                    {
                        snapPt = ptsCompare.ClosestPoint(pt);
                        //if (snapPt.IsInPlane(be.BuildingElementGeometry.ICurve().IFitPlane()))
                        newPoints.Add(snapPt);
                        //newPoints.Add(pt);
                    }
                    else
                        newPoints.Add(pt);
                }

                newPoints.Add(newPoints.First()); //Close the polyloop
                be.BuildingElementGeometry = BH.Engine.Environment.Create.BuildingElementPanel(new BHG.Polyline() { ControlPoints = newPoints }); //update be

                //If we change a surface with a window we need to project the window boundaries on the new surface
                BHE.BuildingElementPanel bePanel = be.BuildingElementGeometry as BHE.BuildingElementPanel;
                if (bePanel.Openings.Count > 0)
                {
                    List<BHE.BuildingElementOpening> projectedPopenings = new List<oM.Environmental.Elements.BuildingElementOpening>();
                    foreach (BHE.BuildingElementOpening opening in bePanel.Openings)
                    {
                        opening.PolyCurve = (BH.Engine.Geometry.Modify.Project(opening.PolyCurve, bePanel.PolyCurve.FitPlane()));
                        projectedPopenings.Add(opening);
                    }
                    bePanel.Openings.Clear();
                    bePanel.Openings = projectedPopenings;
                    be.BuildingElementGeometry = bePanel;
                }
                newBes.Add(be);
            }

            closedSpace.BuildingElements = newBes;

            return closedSpace;
        }
        /***************************************************/

        public static BHE.Building Close(BHE.Building building, double tolerance = BHG.Tolerance.MicroDistance)
        {
            building = building.BreakReferenceClone();
            BHE.Building building2 = building.GetShallowClone() as BHE.Building;

            List<BHE.Space> closedSpaces = new List<BHE.Space>();

            foreach (BHE.Space space in building2.Spaces)
            {
                closedSpaces.Add(Close(space));
            }

            building2.Spaces = closedSpaces;
            return building2;
        }

        /***************************************************/

        public static BHE.Space BreakReferenceClone(this BHE.Space space)
        {
            //Serialise to BSON and back to break the pass by reference issue
            MongoDB.Bson.BsonDocument bd = BH.Engine.Serialiser.Convert.ToBson(space);

            return (BHE.Space)BH.Engine.Serialiser.Convert.FromBson(bd);
        }

        /***************************************************/

        public static BHE.Building BreakReferenceClone(this BHE.Building building)
        {
            //Serialise to BSON and back to break the pass by reference issue
            MongoDB.Bson.BsonDocument bd = BH.Engine.Serialiser.Convert.ToBson(building);

            return (BHE.Building)BH.Engine.Serialiser.Convert.FromBson(bd);
        }
    }
}




