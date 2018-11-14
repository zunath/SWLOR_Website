using System;

namespace SWLOR.Web.Data.Entities
{
    public partial class ChatLog
    {
        public Guid ID { get; set; }
        public int ChatChannelID { get; set; }
        public Guid? SenderPlayerID { get; set; }
        public string SenderAccountName { get; set; }
        public string SenderCDKey { get; set; }
        public Guid? ReceiverPlayerID { get; set; }
        public string ReceiverAccountName { get; set; }
        public string ReceiverCDKey { get; set; }
        public string Message { get; set; }
        public DateTime DateSent { get; set; }
        public string SenderDMName { get; set; }
        public string ReceiverDMName { get; set; }

        public ChatChannel ChatChannel { get; set; }
        public Player ReceiverPlayer { get; set; }
        public Player SenderPlayer { get; set; }
    }
}
