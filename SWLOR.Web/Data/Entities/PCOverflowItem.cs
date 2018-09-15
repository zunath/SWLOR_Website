using System;
using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class PCOverflowItem
    {
        public long PCOverflowItemID { get; set; }
        public string PlayerID { get; set; }
        public string ItemName { get; set; }
        public string ItemTag { get; set; }
        public string ItemResref { get; set; }
        public string ItemObject { get; set; }

        public PlayerCharacter Player { get; set; }
    }
}
