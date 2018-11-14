using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class PerkExecutionType
    {
        public PerkExecutionType()
        {
            Perk = new HashSet<Perk>();
        }

        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<Perk> Perk { get; set; }
    }
}
