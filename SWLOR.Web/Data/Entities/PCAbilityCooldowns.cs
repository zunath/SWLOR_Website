using System;

namespace SWLOR.Web.Data.Entities
{
    public partial class PCAbilityCooldowns
    {
        public int PcabilityCooldownId { get; set; }
        public string PlayerId { get; set; }
        public int AbilityCooldownCategoryId { get; set; }
        public DateTime DateUnlocked { get; set; }

        public AbilityCooldownCategories AbilityCooldownCategory { get; set; }
        public PlayerCharacters Player { get; set; }
    }
}
