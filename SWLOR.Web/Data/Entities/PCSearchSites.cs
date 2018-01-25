using System;

namespace SWLOR.Web.Data.Entities
{
    public partial class PCSearchSites
    {
        public int PcsearchSiteId { get; set; }
        public string PlayerId { get; set; }
        public int SearchSiteId { get; set; }
        public DateTime UnlockDateTime { get; set; }

        public PlayerCharacters Player { get; set; }
    }
}
