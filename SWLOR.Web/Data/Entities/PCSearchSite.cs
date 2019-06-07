using System;

namespace SWLOR.Web.Data.Entities
{
    public partial class PCSearchSite
    {
        public Guid ID { get; set; }
        public Guid PlayerID { get; set; }
        public int SearchSiteID { get; set; }
        public DateTime UnlockDateTime { get; set; }
        public int ClusterID { get; set; }

        public virtual Player Player { get; set; }
    }
}