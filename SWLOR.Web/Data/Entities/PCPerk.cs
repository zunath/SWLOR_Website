using System;

namespace SWLOR.Web.Data.Entities
{
    public class PCPerk
    {
        public int PCPerkID { get; set; }
        public string PlayerID { get; set; }
        public DateTime AcquiredDate { get; set; }
        public int PerkID { get; set; }
        public int PerkLevel { get; set; }

        public Perk Perk { get; set; }
        public PlayerCharacter Player { get; set; }
    }
}
