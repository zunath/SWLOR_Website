using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public class PCTerritoryFlag
    {
        public PCTerritoryFlag()
        {
            ConstructionSites = new HashSet<ConstructionSite>();
            PCTerritoryFlagsPermissions = new HashSet<PCTerritoryFlagsPermission>();
            PCTerritoryFlagsStructures = new HashSet<PCTerritoryFlagsStructure>();
            StructureQuickBuildAudit = new HashSet<StructureQuickBuildAudit>();
        }

        public int PCTerritoryFlagID { get; set; }
        public string PlayerID { get; set; }
        public int StructureBlueprintID { get; set; }
        public string LocationAreaTag { get; set; }
        public double LocationX { get; set; }
        public double LocationY { get; set; }
        public double LocationZ { get; set; }
        public double LocationOrientation { get; set; }
        public int BuildPrivacySettingID { get; set; }

        public BuildPrivacyDomain BuildPrivacySetting { get; set; }
        public PlayerCharacter Player { get; set; }
        public StructureBlueprint StructureBlueprint { get; set; }
        public ICollection<ConstructionSite> ConstructionSites { get; set; }
        public ICollection<PCTerritoryFlagsPermission> PCTerritoryFlagsPermissions { get; set; }
        public ICollection<PCTerritoryFlagsStructure> PCTerritoryFlagsStructures { get; set; }
        public ICollection<StructureQuickBuildAudit> StructureQuickBuildAudit { get; set; }
    }
}
