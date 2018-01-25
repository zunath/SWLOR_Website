using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class ClientLogEventTypesDomain
    {
        public ClientLogEventTypesDomain()
        {
            ClientLogEvents = new HashSet<ClientLogEvents>();
        }

        public int ClientLogEventTypeId { get; set; }
        public string Name { get; set; }

        public ICollection<ClientLogEvents> ClientLogEvents { get; set; }
    }
}
