using System;

namespace SWLOR.Web.Data.Entities
{
    public partial class PCBlueprints
    {
        public long PcblueprintId { get; set; }
        public string PlayerId { get; set; }
        public long CraftBlueprintId { get; set; }
        public DateTime AcquiredDate { get; set; }

        public CraftBlueprints CraftBlueprint { get; set; }
        public PlayerCharacters Player { get; set; }
    }
}
