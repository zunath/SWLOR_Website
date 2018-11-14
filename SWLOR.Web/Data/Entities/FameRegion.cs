using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class FameRegion
    {
        public FameRegion()
        {
            PCRegionalFame = new HashSet<PCRegionalFame>();
            Quest = new HashSet<Quest>();
        }

        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<PCRegionalFame> PCRegionalFame { get; set; }
        public ICollection<Quest> Quest { get; set; }
    }
}
