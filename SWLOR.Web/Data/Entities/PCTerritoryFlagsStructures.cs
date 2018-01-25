using System;
using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class PCTerritoryFlagsStructures
    {
        public PCTerritoryFlagsStructures()
        {
            PcterritoryFlagsStructuresItems = new HashSet<PCTerritoryFlagsStructuresItems>();
            PcterritoryFlagsStructuresResearchQueues = new HashSet<PCTerritoryFlagsStructuresResearchQueues>();
            StructureQuickBuildAudit = new HashSet<StructureQuickBuildAudit>();
        }

        public long PcterritoryFlagStructureId { get; set; }
        public int PcterritoryFlagId { get; set; }
        public int StructureBlueprintId { get; set; }
        public bool IsUseable { get; set; }
        public string LocationAreaTag { get; set; }
        public double LocationX { get; set; }
        public double LocationY { get; set; }
        public double LocationZ { get; set; }
        public double LocationOrientation { get; set; }
        public DateTime CreateDate { get; set; }

        public PCTerritoryFlags PcTerritoryFlag { get; set; }
        public StructureBlueprints StructureBlueprint { get; set; }
        public ICollection<PCTerritoryFlagsStructuresItems> PcterritoryFlagsStructuresItems { get; set; }
        public ICollection<PCTerritoryFlagsStructuresResearchQueues> PcterritoryFlagsStructuresResearchQueues { get; set; }
        public ICollection<StructureQuickBuildAudit> StructureQuickBuildAudit { get; set; }
    }
}
