using System;
using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class PCSearchSiteItem
    {
        public long PCSearchSiteItemID { get; set; }
        public string PlayerID { get; set; }
        public int SearchSiteID { get; set; }
        public string SearchItem { get; set; }

        public PlayerCharacter Player { get; set; }
    }
}
