using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class FameRegion
    {
        public FameRegion()
        {
            PCRegionalFame = new HashSet<PCRegionalFame>();
            Quests = new HashSet<Quest>();
        }

        public int FameRegionID { get; set; }
        public string Name { get; set; }

        public ICollection<PCRegionalFame> PCRegionalFame { get; set; }
        public ICollection<Quest> Quests { get; set; }
    }
}
