using System;

namespace SWLOR.Web.Data.Entities
{
    public partial class PCImpoundedItem
    {
        public Guid ID { get; set; }
        public Guid PlayerID { get; set; }
        public string ItemName { get; set; }
        public string ItemTag { get; set; }
        public string ItemResref { get; set; }
        public string ItemObject { get; set; }
        public DateTime DateImpounded { get; set; }
        public DateTime? DateRetrieved { get; set; }

        public Player Player { get; set; }
    }
}
