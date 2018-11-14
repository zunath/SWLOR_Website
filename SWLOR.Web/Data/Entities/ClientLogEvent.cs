using System;

namespace SWLOR.Web.Data.Entities
{
    public partial class ClientLogEvent
    {
        public Guid ID { get; set; }
        public int ClientLogEventTypeID { get; set; }
        public Guid? PlayerID { get; set; }
        public string CDKey { get; set; }
        public string AccountName { get; set; }
        public DateTime DateOfEvent { get; set; }

        public ClientLogEventType ClientLogEventType { get; set; }
        public Player Player { get; set; }
    }
}
