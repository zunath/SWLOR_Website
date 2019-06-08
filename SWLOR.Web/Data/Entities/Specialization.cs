using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class Specialization
    {
        public Specialization()
        {
            Perk = new HashSet<Perk>();
            PerkLevel = new HashSet<PerkLevel>();
            Player = new HashSet<Player>();
        }

        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Perk> Perk { get; set; }
        public virtual ICollection<PerkLevel> PerkLevel { get; set; }
        public virtual ICollection<Player> Player { get; set; }
    }
}