﻿using System;
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

    public static partial class Query
    {
        /***************************************************/
        /**** Public Methods                            ****/
        /***************************************************/

        public static BHG.Polyline StoreyGeometry(this BH.oM.Architecture.Elements.Level bHoMLevel, List<BHE.Space> bHoMSpaces)
        {
            List<BHE.Space> spacesAtLevel = bHoMSpaces.FindAll(x => x.Level.Elevation == bHoMLevel.Elevation).ToList();
            List<BHE.BuildingElement> bHoMBuildingElement = spacesAtLevel.SelectMany(x => x.BuildingElements).ToList();
            List<BHG.Point> ctrlPoints = new List<BHG.Point>();

            foreach (BHE.BuildingElement element in bHoMBuildingElement)
            {
                foreach (BHG.Point pt in element.BuildingElementGeometry.ICurve().IControlPoints())
                {
                    if (pt.Z > bHoMLevel.Elevation - BH.oM.Geometry.Tolerance.Distance && pt.Z < bHoMLevel.Elevation + BH.oM.Geometry.Tolerance.Distance)
                        ctrlPoints.Add(pt);

                }
            }

            BHG.Polyline boundary = convexHull(ctrlPoints.CullDuplicates());

            return boundary;
        }

        /***************************************************/

        //TODO: move convex hull to Geomtry Engine 

        public static BHG.Point nextHullPoint(List<BHG.Point> points, BHG.Point currPt)
        {

            int right = -1;
            int none = 0;

            BHG.Point nextPt = currPt;
            int t;
            foreach (BHG.Point pt in points)
            {
                t = ((nextPt.X - currPt.X) * (pt.Y - currPt.Y) - (pt.X - currPt.X) * (nextPt.Y - currPt.Y)).CompareTo(0);
                if (t == right || t == none && Geometry.Query.Distance(currPt, pt) > Geometry.Query.Distance(currPt, nextPt))
                    nextPt = pt;
            }
            return nextPt;
        }

        /***************************************************/

        public static BHG.Polyline convexHull(List<BHG.Point> points)
        {
            List<BHG.Point> hull = new List<BHG.Point>();
            foreach (BHG.Point p in points)
            {
                if (hull.Count == 0)
                    hull.Add(p);
                else
                {
                    if (hull[0].X > p.X)
                        hull[0] = p;
                    else if (hull[0].X == p.X)
                        if (hull[0].Y > p.Y)
                            hull[0] = p;
                }
            }


            BHG.Point nextPt;
            int counter = 0;
            while (counter < hull.Count)
            {
                nextPt = nextHullPoint(points, hull[counter]);
                if (nextPt != hull[0])
                    hull.Add(nextPt);
                counter++;
            }

            hull.Add(hull[0]);

            BH.oM.Geometry.Polyline hullBoundary = new BHG.Polyline() { ControlPoints = hull };
            return hullBoundary;
        }

        /***************************************************/


    }
}




