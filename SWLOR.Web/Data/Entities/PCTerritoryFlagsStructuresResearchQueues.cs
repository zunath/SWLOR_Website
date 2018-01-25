using System;

namespace SWLOR.Web.Data.Entities
{
    public partial class PCTerritoryFlagsStructuresResearchQueues
    {
        public int PcstructureResearchId { get; set; }
        public long PcstructureId { get; set; }
        public int ResearchBlueprintId { get; set; }
        public int ResearchSlot { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime CompletedDateTime { get; set; }
        public bool IsCanceled { get; set; }
        public DateTime? DeliverDateTime { get; set; }

        public PCTerritoryFlagsStructures Pcstructure { get; set; }
        public ResearchBlueprints ResearchBlueprint { get; set; }
    }
}
