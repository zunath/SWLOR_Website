using System;

namespace SWLOR.Web.Data.Entities
{
    public partial class BankItem
    {
        public Guid ID { get; set; }
        public int BankID { get; set; }
        public Guid PlayerID { get; set; }
        public string ItemID { get; set; }
        public string ItemName { get; set; }
        public string ItemTag { get; set; }
        public string ItemResref { get; set; }
        public string ItemObject { get; set; }
        public DateTime DateStored { get; set; }

        public Bank Bank { get; set; }
        public Player Player { get; set; }
    }
}
