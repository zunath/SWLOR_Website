using System;

namespace SWLOR.Web.Data.Entities
{
    public partial class PCCraftedBlueprint
    {
        public Guid ID { get; set; }
        public Guid PlayerID { get; set; }
        public int CraftBlueprintID { get; set; }
        public DateTime DateFirstCrafted { get; set; }
        public int ClusterID { get; set; }

        public virtual CraftBlueprint CraftBlueprint { get; set; }
        public virtual Player Player { get; set; }
    }
}