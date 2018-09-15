using System;
using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public class PCTerritoryFlagsStructure
    {
        public PCTerritoryFlagsStructure()
        {
            PCTerritoryFlagsStructuresItems = new HashSet<PCTerritoryFlagsStructuresItem>();
        }

        public long PCTerritoryFlagStructureID { get; set; }
        public int PCTerritoryFlagID { get; set; }
        public int StructureBlueprintID { get; set; }
        public bool IsUseable { get; set; }
        public string LocationAreaTag { get; set; }
        public double LocationX { get; set; }
        public double LocationY { get; set; }
        public double LocationZ { get; set; }
        public double LocationOrientation { get; set; }
        public DateTime CreateDate { get; set; }
        public string CustomName { get; set; }

        public PCTerritoryFlag PCTerritoryFlag { get; set; }
        public StructureBlueprint StructureBlueprint { get; set; }
        public ICollection<PCTerritoryFlagsStructuresItem> PCTerritoryFlagsStructuresItems { get; set; }
    }
}
