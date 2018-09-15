using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class PerkExecutionType
    {
        public PerkExecutionType()
        {
            Perks = new HashSet<Perk>();
        }

        public int PerkExecutionTypeID { get; set; }
        public string Name { get; set; }

        public ICollection<Perk> Perks { get; set; }
    }
}
