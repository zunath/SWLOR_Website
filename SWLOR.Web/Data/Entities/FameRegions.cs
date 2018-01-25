using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class FameRegions
    {
        public FameRegions()
        {
            PcregionalFame = new HashSet<PCRegionalFame>();
            Quests = new HashSet<Quests>();
        }

        public int FameRegionId { get; set; }
        public string Name { get; set; }

        public ICollection<PCRegionalFame> PcregionalFame { get; set; }
        public ICollection<Quests> Quests { get; set; }
    }
}
