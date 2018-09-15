using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class ClientLogEventTypesDomain
    {
        public ClientLogEventTypesDomain()
        {
            ClientLogEvents = new HashSet<ClientLogEvent>();
        }

        public int ClientLogEventTypeID { get; set; }
        public string Name { get; set; }

        public ICollection<ClientLogEvent> ClientLogEvents { get; set; }
    }
}
