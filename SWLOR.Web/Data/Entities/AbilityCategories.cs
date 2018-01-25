using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class AbilityCategories
    {
        public AbilityCategories()
        {
            Abilities = new HashSet<Abilities>();
        }

        public int AbilityCategoryId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Abilities> Abilities { get; set; }
    }
}
