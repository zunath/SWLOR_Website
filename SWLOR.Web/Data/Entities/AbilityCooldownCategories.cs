using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class AbilityCooldownCategories
    {
        public AbilityCooldownCategories()
        {
            Abilities = new HashSet<Abilities>();
            PcabilityCooldowns = new HashSet<PCAbilityCooldowns>();
        }

        public int AbilityCooldownCategoryId { get; set; }
        public string Name { get; set; }
        public double BaseCooldownTime { get; set; }

        public ICollection<Abilities> Abilities { get; set; }
        public ICollection<PCAbilityCooldowns> PcabilityCooldowns { get; set; }
    }
}
