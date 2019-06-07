using System;

namespace SWLOR.Web.Data.Entities
{
    public partial class PCCooldown
    {
        public Guid ID { get; set; }
        public Guid PlayerID { get; set; }
        public int CooldownCategoryID { get; set; }
        public DateTime DateUnlocked { get; set; }
        public int ClusterID { get; set; }

        public virtual CooldownCategory CooldownCategory { get; set; }
        public virtual Player Player { get; set; }
    }
}