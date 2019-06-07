using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class CooldownCategory
    {
        public CooldownCategory()
        {
            PCCooldown = new HashSet<PCCooldown>();
            Perk = new HashSet<Perk>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public double BaseCooldownTime { get; set; }

        public virtual ICollection<PCCooldown> PCCooldown { get; set; }
        public virtual ICollection<Perk> Perk { get; set; }
    }
}