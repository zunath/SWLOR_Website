using System;

namespace SWLOR.Web.Data.Entities
{
    public partial class Error
    {
        public Guid ID { get; set; }
        public DateTime DateCreated { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }
        public string Caller { get; set; }
    }
}
