using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class ResearchBlueprints
    {
        public ResearchBlueprints()
        {
            PcterritoryFlagsStructuresResearchQueues = new HashSet<PCTerritoryFlagsStructuresResearchQueues>();
        }

        public int ResearchBlueprintId { get; set; }
        public long CraftBlueprintId { get; set; }
        public bool IsActive { get; set; }
        public int Price { get; set; }
        public long ResearchPoints { get; set; }
        public int SkillRequired { get; set; }

        public CraftBlueprints CraftBlueprint { get; set; }
        public ICollection<PCTerritoryFlagsStructuresResearchQueues> PcterritoryFlagsStructuresResearchQueues { get; set; }
    }
}
