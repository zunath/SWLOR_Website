using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class PerkCategory
    {
        public PerkCategory()
        {
            Perk = new HashSet<Perk>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int Sequence { get; set; }

        public virtual ICollection<Perk> Perk { get; set; }
    }
}