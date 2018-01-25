using System;

namespace SWLOR.Web.Data.Entities
{
    public partial class PCBadges
    {
        public long PcbadgeId { get; set; }
        public string PlayerId { get; set; }
        public int BadgeId { get; set; }
        public DateTime AcquiredDate { get; set; }
        public string AcquiredAreaName { get; set; }
        public string AcquiredAreaTag { get; set; }
        public string AcquiredAreaResref { get; set; }

        public Badges Badge { get; set; }
        public PlayerCharacters Player { get; set; }
    }
}
