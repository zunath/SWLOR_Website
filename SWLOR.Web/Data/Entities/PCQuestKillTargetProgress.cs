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

        public NPCGroup NPCGroup { get; set; }
        public PCQuestStatus PCQuestStatus { get; set; }
        public Player Player { get; set; }
    }
}
