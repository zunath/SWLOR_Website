using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public class ConstructionSite
    {
        public ConstructionSite()
        {
            ConstructionSiteComponents = new HashSet<ConstructionSiteComponent>();
        }

        public int ConstructionSiteID { get; set; }
        public int? PCTerritoryFlagID { get; set; }
        public string PlayerID { get; set; }
        public int StructureBlueprintID { get; set; }
        public string LocationAreaTag { get; set; }
        public double LocationX { get; set; }
        public double LocationY { get; set; }
        public double LocationZ { get; set; }
        public double LocationOrientation { get; set; }

        public PCTerritoryFlag PCTerritoryFlag { get; set; }
        public PlayerCharacter Player { get; set; }
        public StructureBlueprint StructureBlueprint { get; set; }
        public ICollection<ConstructionSiteComponent> ConstructionSiteComponents { get; set; }
    }
}
