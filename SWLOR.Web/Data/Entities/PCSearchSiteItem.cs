using System;

namespace SWLOR.Web.Data.Entities
{
    public partial class PCSearchSiteItem
    {
        public Guid ID { get; set; }
        public Guid PlayerID { get; set; }
        public int SearchSiteID { get; set; }
        public string SearchItem { get; set; }

        public Player Player { get; set; }
    }
}
