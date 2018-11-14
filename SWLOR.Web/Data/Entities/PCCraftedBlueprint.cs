using System;

namespace SWLOR.Web.Data.Entities
{
    public partial class PCCraftedBlueprint
    {
        public Guid ID { get; set; }
        public Guid PlayerID { get; set; }
        public int CraftBlueprintID { get; set; }
        public DateTime DateFirstCrafted { get; set; }

        public CraftBlueprint CraftBlueprint { get; set; }
        public Player Player { get; set; }
    }
}
