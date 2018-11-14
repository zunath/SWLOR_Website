using System;

namespace SWLOR.Web.Data.Entities
{
    public partial class PCOverflowItem
    {
        public Guid ID { get; set; }
        public Guid PlayerID { get; set; }
        public string ItemName { get; set; }
        public string ItemTag { get; set; }
        public string ItemResref { get; set; }
        public string ItemObject { get; set; }

        public Player Player { get; set; }
    }
}
