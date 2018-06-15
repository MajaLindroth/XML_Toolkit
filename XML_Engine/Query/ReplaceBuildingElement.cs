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

    public static partial class Query
    {
        /***************************************************/
        /**** Public Methods                            ****/
        /***************************************************/

        public static List<BHE.BuildingElement> ReplaceBuildingElement(this List<BHE.BuildingElement> oldBuildingElements, List<BHE.BuildingElement> newBuildingElements)
        {
            List<BHE.BuildingElement> bElement = new List<oM.Environmental.Elements.BuildingElement>();

            foreach (Guid guid in newBuildingElements.Select(x => x.BHoM_Guid))
            {
                if (oldBuildingElements.Select(x => x.BHoM_Guid).Contains(guid))
                {
                    bElement.Add(newBuildingElements.Find(x => x.BHoM_Guid == guid));
                    bElement.AddRange(oldBuildingElements.FindAll(x => x.BHoM_Guid != guid));
                }
                else
                    bElement.AddRange(oldBuildingElements.FindAll(x => x.BHoM_Guid != guid));
            }

            return bElement;
        }
        /***************************************************/

        public static BHE.Building UpdateBuildingElement(this List<BHE.BuildingElement> bes, BHE.Building building)
        {
            BHE.Building newBuilding = building.GetShallowClone() as BHE.Building;
            List<BHE.Space> updatedSpaces = new List<oM.Environmental.Elements.Space>();

            //Update the spaces
            foreach (BHE.BuildingElement be in bes)
            {
                BHE.Space space = newBuilding.Spaces.Find(x => x.BHoM_Guid == be.AdjacentSpaces.FirstOrDefault());
                int index = newBuilding.Spaces.IndexOf(space);

                if (space == null)
                    continue;

                BHE.BuildingElement toRemove = space.BuildingElements.Find(x => x.BHoM_Guid == be.BHoM_Guid);

                newBuilding.Spaces[index].BuildingElements.Remove(toRemove);
                newBuilding.Spaces[index].BuildingElements.Add(be);

                newBuilding.BuildingElements.Remove(toRemove);
                newBuilding.BuildingElements.Add(be);
            }

            return newBuilding;
        }

        /***************************************************/

        public static BHE.Building RemoveBuildingElement(this List<BHE.BuildingElement> bes, BHE.Building building)
        {
            BHE.Building newBuilding = building.GetShallowClone() as BHE.Building;
            List<BHE.Space> updatedSpaces = new List<oM.Environmental.Elements.Space>();

            //Update the spaces
            foreach (BHE.BuildingElement be in bes)
            {
                BHE.Space space = newBuilding.Spaces.Find(x => x.BHoM_Guid == be.AdjacentSpaces.FirstOrDefault());
                int index = newBuilding.Spaces.IndexOf(space);

                if (space == null)
                {
                    newBuilding.BuildingElements.Remove(be); //Remove shade element
                    continue;
                }
                else
                {
                    BHE.BuildingElement toRemove = space.BuildingElements.Find(x => x.BHoM_Guid == be.BHoM_Guid);
                    newBuilding.Spaces[index].BuildingElements.Remove(toRemove);
                    newBuilding.BuildingElements.Remove(toRemove);
                }
            }

            return newBuilding;
        }
    }
}




