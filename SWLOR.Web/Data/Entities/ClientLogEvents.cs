using System;

namespace SWLOR.Web.Data.Entities
{
    public partial class ClientLogEvents
    {
        public int ClientLogEventId { get; set; }
        public int ClientLogEventTypeId { get; set; }
        public string PlayerId { get; set; }
        public string Cdkey { get; set; }
        public string AccountName { get; set; }
        public DateTime DateOfEvent { get; set; }

        public ClientLogEventTypesDomain ClientLogEventType { get; set; }
        public PlayerCharacters Player { get; set; }
    }
}
