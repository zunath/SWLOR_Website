using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class ChatChannel
    {
        public ChatChannel()
        {
            ChatLog = new HashSet<ChatLog>();
        }

        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<ChatLog> ChatLog { get; set; }
    }
}
