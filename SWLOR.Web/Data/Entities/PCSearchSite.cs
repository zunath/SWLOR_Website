using System;
using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class PCSearchSite
    {
        public int PCSearchSiteID { get; set; }
        public string PlayerID { get; set; }
        public int SearchSiteID { get; set; }
        public DateTime UnlockDateTime { get; set; }

        public PlayerCharacter Player { get; set; }
    }
}
