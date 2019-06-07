using System;

namespace SWLOR.Web.Data.Entities
{
    public partial class PCRegionalFame
    {
        public Guid ID { get; set; }
        public Guid PlayerID { get; set; }
        public int FameRegionID { get; set; }
        public int Amount { get; set; }
        public int ClusterID { get; set; }

        public virtual FameRegion FameRegion { get; set; }
        public virtual Player Player { get; set; }
    }
}