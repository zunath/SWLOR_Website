using System;

namespace SWLOR.Web.Data.Entities
{
    public class StructureQuickBuildAudit
    {
        public int StructureQuickBuildID { get; set; }
        public int? PCTerritoryFlagID { get; set; }
        public long? PCTerritoryFlagStructureID { get; set; }
        public string DMName { get; set; }
        public DateTime DateBuilt { get; set; }

        public PCTerritoryFlag PCTerritoryFlag { get; set; }
        public PCTerritoryFlagsStructure PCTerritoryFlagStructure { get; set; }
    }
}
