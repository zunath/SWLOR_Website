using System;

namespace SWLOR.Web.Data.Entities
{
    public partial class StructureQuickBuildAudit
    {
        public int StructureQuickBuildId { get; set; }
        public int? PcterritoryFlagId { get; set; }
        public long? PcterritoryFlagStructureId { get; set; }
        public string Dmname { get; set; }
        public DateTime DateBuilt { get; set; }

        public PCTerritoryFlags PcTerritoryFlag { get; set; }
        public PCTerritoryFlagsStructures PcTerritoryFlagStructure { get; set; }
    }
}
