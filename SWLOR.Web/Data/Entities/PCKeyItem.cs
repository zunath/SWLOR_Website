using System;

namespace SWLOR.Web.Data.Entities
{
    public partial class PCKeyItem
    {
        public Guid ID { get; set; }
        public Guid PlayerID { get; set; }
        public int KeyItemID { get; set; }
        public DateTime AcquiredDate { get; set; }

        public KeyItem KeyItem { get; set; }
        public Player Player { get; set; }
    }
}
