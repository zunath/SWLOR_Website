using System;

namespace SWLOR.Web.Data.Entities
{
    public class ChatLog
    {
        public long ChatLogID { get; set; }
        public int ChatChannelID { get; set; }
        public string SenderPlayerID { get; set; }
        public string SenderAccountName { get; set; }
        public string SenderCDKey { get; set; }
        public string ReceiverPlayerID { get; set; }
        public string ReceiverAccountName { get; set; }
        public string ReceiverCDKey { get; set; }
        public string Message { get; set; }
        public DateTime DateSent { get; set; }
        public string SenderDMName { get; set; }
        public string ReceiverDMName { get; set; }

        public ChatChannelsDomain ChatChannel { get; set; }
        public PlayerCharacter ReceiverPlayer { get; set; }
        public PlayerCharacter SenderPlayer { get; set; }
    }
}
