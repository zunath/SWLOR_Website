using System;

namespace SWLOR.Web.Data.Entities
{
    public partial class PCRegionalFame
    {
        public Guid ID { get; set; }
        public Guid PlayerID { get; set; }
        public int FameRegionID { get; set; }
        public int Amount { get; set; }

        public FameRegion FameRegion { get; set; }
        public Player Player { get; set; }
    }
}
