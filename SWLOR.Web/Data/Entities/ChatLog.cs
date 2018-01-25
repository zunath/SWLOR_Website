using System;

namespace SWLOR.Web.Data.Entities
{
    public partial class ChatLog
    {
        public long ChatLogId { get; set; }
        public int ChatChannelId { get; set; }
        public string SenderPlayerId { get; set; }
        public string SenderAccountName { get; set; }
        public string SenderCdkey { get; set; }
        public string ReceiverPlayerId { get; set; }
        public string ReceiverAccountName { get; set; }
        public string ReceiverCdkey { get; set; }
        public string Message { get; set; }
        public DateTime DateSent { get; set; }
        public string SenderDmname { get; set; }
        public string ReceiverDmname { get; set; }

        public ChatChannelsDomain ChatChannel { get; set; }
        public PlayerCharacters ReceiverPlayer { get; set; }
        public PlayerCharacters SenderPlayer { get; set; }
    }
}
