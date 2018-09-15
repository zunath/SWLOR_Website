using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class PerkCategory
    {
        public PerkCategory()
        {
            Perks = new HashSet<Perk>();
        }

        public int PerkCategoryID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int Sequence { get; set; }

        public ICollection<Perk> Perks { get; set; }
    }
}
