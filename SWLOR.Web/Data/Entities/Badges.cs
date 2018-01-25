using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class Badges
    {
        public Badges()
        {
            Pcbadges = new HashSet<PCBadges>();
        }

        public int BadgeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Experience { get; set; }

        public ICollection<PCBadges> Pcbadges { get; set; }
    }
}
