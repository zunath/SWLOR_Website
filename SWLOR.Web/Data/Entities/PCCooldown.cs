using System;

namespace SWLOR.Web.Data.Entities
{
    public class PCCooldown
    {
        public int PCCooldownID { get; set; }
        public string PlayerID { get; set; }
        public int CooldownCategoryID { get; set; }
        public DateTime DateUnlocked { get; set; }

        public CooldownCategory CooldownCategory { get; set; }
        public PlayerCharacter Player { get; set; }
    }
}
