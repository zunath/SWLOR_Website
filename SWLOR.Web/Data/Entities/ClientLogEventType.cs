using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class ClientLogEventType
    {
        public ClientLogEventType()
        {
            ClientLogEvent = new HashSet<ClientLogEvent>();
        }

        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<ClientLogEvent> ClientLogEvent { get; set; }
    }
}
