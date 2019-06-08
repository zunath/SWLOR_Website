using System;

namespace SWLOR.Web.Data.Entities
{
    public partial class PCQuestKillTargetProgress
    {
        public Guid ID { get; set; }
        public Guid PlayerID { get; set; }
        public Guid PCQuestStatusID { get; set; }
        public int NPCGroupID { get; set; }
        public int RemainingToKill { get; set; }
        public int ClusterID { get; set; }

        public virtual NPCGroup NPCGroup { get; set; }
        public virtual PCQuestStatus PCQuestStatus { get; set; }
        public virtual Player Player { get; set; }
    }
}