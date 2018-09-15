using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class CooldownCategory
    {
        public CooldownCategory()
        {
            PCCooldowns = new HashSet<PCCooldown>();
            Perks = new HashSet<Perk>();
        }

        public int CooldownCategoryID { get; set; }
        public string Name { get; set; }
        public double BaseCooldownTime { get; set; }

        public ICollection<PCCooldown> PCCooldowns { get; set; }
        public ICollection<Perk> Perks { get; set; }
    }
}
