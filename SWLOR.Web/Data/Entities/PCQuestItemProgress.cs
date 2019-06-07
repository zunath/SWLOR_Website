using System;

namespace SWLOR.Web.Data.Entities
{
    public partial class PCQuestItemProgress
    {
        public Guid ID { get; set; }
        public Guid PlayerID { get; set; }
        public Guid PCQuestStatusID { get; set; }
        public string Resref { get; set; }
        public int Remaining { get; set; }
        public bool MustBeCraftedByPlayer { get; set; }
        public int ClusterID { get; set; }

        public virtual PCQuestStatus PCQuestStatus { get; set; }
        public virtual Player Player { get; set; }
    }
}