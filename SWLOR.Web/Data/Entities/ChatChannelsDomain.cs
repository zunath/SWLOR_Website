using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class ChatChannelsDomain
    {
        public ChatChannelsDomain()
        {
            ChatLog = new HashSet<ChatLog>();
        }

        public int ChatChannelId { get; set; }
        public string Name { get; set; }

        public ICollection<ChatLog> ChatLog { get; set; }
    }
}
