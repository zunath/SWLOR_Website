using System;

namespace SWLOR.Web.Data.Entities
{
    public partial class BugReport
    {
        public Guid ID { get; set; }
        public Guid? SenderPlayerID { get; set; }
        public string CDKey { get; set; }
        public string Text { get; set; }
        public string TargetName { get; set; }
        public string AreaResref { get; set; }
        public double SenderLocationX { get; set; }
        public double SenderLocationY { get; set; }
        public double SenderLocationZ { get; set; }
        public double SenderLocationOrientation { get; set; }
        public DateTime DateSubmitted { get; set; }
        public int ClusterID { get; set; }

        public virtual Player SenderPlayer { get; set; }
    }
}