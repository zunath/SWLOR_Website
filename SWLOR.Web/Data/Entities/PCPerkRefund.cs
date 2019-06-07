using System;

namespace SWLOR.Web.Data.Entities
{
    public partial class PCPerkRefund
    {
        public Guid ID { get; set; }
        public Guid PlayerID { get; set; }
        public int PerkID { get; set; }
        public int Level { get; set; }
        public DateTime DateAcquired { get; set; }
        public DateTime DateRefunded { get; set; }
        public int ClusterID { get; set; }

        public virtual Perk Perk { get; set; }
        public virtual Player Player { get; set; }
    }
}