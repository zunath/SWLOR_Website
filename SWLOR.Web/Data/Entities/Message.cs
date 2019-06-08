using System;

namespace SWLOR.Web.Data.Entities
{
    public partial class Message
    {
        public Guid ID { get; set; }
        public Guid BoardID { get; set; }
        public Guid PlayerID { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public DateTime DatePosted { get; set; }
        public DateTime DateExpires { get; set; }
        public DateTime? DateRemoved { get; set; }
        public int ClusterID { get; set; }

        public virtual Player Player { get; set; }
    }
}