using System;

namespace SWLOR.Web.Data.Entities
{
    public partial class PCCooldown
    {
        public Guid ID { get; set; }
        public Guid PlayerID { get; set; }
        public int CooldownCategoryID { get; set; }
        public DateTime DateUnlocked { get; set; }

        public CooldownCategory CooldownCategory { get; set; }
        public Player Player { get; set; }
    }
}
