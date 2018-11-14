using System;

namespace SWLOR.Web.Data.Entities
{
    public partial class PCPerk
    {
        public Guid ID { get; set; }
        public Guid PlayerID { get; set; }
        public DateTime AcquiredDate { get; set; }
        public int PerkID { get; set; }
        public int PerkLevel { get; set; }

        public Perk Perk { get; set; }
        public Player Player { get; set; }
    }
}
