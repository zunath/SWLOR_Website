using System;

namespace SWLOR.Web.Data.Entities
{
    public partial class DiscordChatQueue
    {
        public Guid ID { get; set; }
        public string SenderName { get; set; }
        public string Message { get; set; }
        public DateTime DateSent { get; set; }
        public DateTime? DatePosted { get; set; }
        public DateTime? DateForRetry { get; set; }
        public string ResponseContent { get; set; }
        public int RetryAttempts { get; set; }
        public string SenderAccountName { get; set; }
        public string SenderCDKey { get; set; }
    }
}
