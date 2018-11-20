﻿using System;
using System.Collections.Generic;
using System.Linq;
using BH.oM.XML;
using BH.oM.Base;
using BHE = BH.oM.Environment.Elements;
using BHG = BH.oM.Geometry;
using BH.Engine.Geometry;

namespace BH.Adapter.XML
{
    public class GBXMLDeserializer
    {
        /***************************************************/
        /**** Public Methods                            ****/
        /***************************************************/

        public static List<BHoMObject> Deserialize(BH.oM.XML.GBXML gbx)
        {
            List<BHoMObject> bhomObjects = new List<BHoMObject>();
            List<BH.oM.XML.Surface> srfs = gbx.Campus.Surface.ToList();
            List<BH.oM.XML.Space> spaces = gbx.Campus.Building[0].Space.ToList();

            // Generate GBXMLSurfaces
            if (srfs != null)
            {
                foreach (Surface srf in srfs)
                {
                    BHE.Panel pan = new BHE.Panel();
                    pan.Name = srf.Name;
                    //pan.Type = srf.surfaceType;
                    pan.CustomData.Add("GBXML-ID", srf.ID);
                    pan.PanelCurve = MakeCurveGroup(srf.PlanarGeometry.PolyLoop);
                    bhomObjects.Add(pan);
                }
            }

            // Generate GBXMLSpaces
            if (spaces != null)
            {
                foreach (BH.oM.XML.Space space in spaces)
                {
                    BHE.Space xspace = new BHE.Space();
                    xspace.Name = space.Name;
                    xspace.CustomData.Add("GBXML-ID", space.ID);
                    if (4 <= space.ShellGeometry.ClosedShell.PolyLoop.Count())
                    {
                        List<BHE.Panel> bHomPanel = new List<BHE.Panel>();
                        List<BHE.BuildingElement> bHoMBuildingElement = new List<BHE.BuildingElement>();
                        List<BHG.Polyline> plines = new List<BHG.Polyline>();
                        foreach (BH.oM.XML.Polyloop ploop in space.ShellGeometry.ClosedShell.PolyLoop)
                        {
                            if (3 <= ploop.CartesianPoint.Count())
                            {
                                plines.Add(BH.Engine.XML.Convert.ToBHoM(ploop));
                            }
                        }

                        bHomPanel.AddRange(plines.Select(x => new BHE.Panel { PanelCurve = Create.PolyCurve(new List<BHG.Polyline> { x }) }));  //
                        //bHoMBuildingElement.AddRange(bHomPanel.Select(x => new BHE.BuildingElement { BuildingElementGeometry = x }));

                        //xspace.BuildingElements = bHoMBuildingElement;
                    }
                    bhomObjects.Add(xspace);
                }
            }
            return bhomObjects;
        }


        /***************************************************/
        /**** Private Methods                           ****/
        /***************************************************/
        private static BHG.PolyCurve MakeCurveGroup(Polyloop ploop)
        {
            List<BHG.Point> pts = new List<BH.oM.Geometry.Point>();
            if (1 <= ploop.CartesianPoint.Count())
            {
                foreach (CartesianPoint Cpt in ploop.CartesianPoint)
                {
                    BHG.Point pt = new BHG.Point();
                    pt.X = System.Convert.ToDouble(Cpt.Coordinate[0]);
                    pt.Y = System.Convert.ToDouble(Cpt.Coordinate[1]);
                    pt.Z = System.Convert.ToDouble(Cpt.Coordinate[2]);
                    pts.Add(pt);
                }
                pts.Add((BHG.Point)pts[0].Clone());
            }

            BHG.Polyline pline = Create.Polyline(pts);
            List<BHG.ICurve> crvs = new List<BHG.ICurve>();
            crvs.Add(pline);
            return Create.PolyCurve(crvs);
        }

        /***************************************************/

    }
}