using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class NPCGroups
    {
        public NPCGroups()
        {
            PcquestKillTargetProgress = new HashSet<PCQuestKillTargetProgress>();
            QuestKillTargetList = new HashSet<QuestKillTargetList>();
        }

        public int NpcgroupId { get; set; }
        public string Name { get; set; }

        public ICollection<PCQuestKillTargetProgress> PcquestKillTargetProgress { get; set; }
        public ICollection<QuestKillTargetList> QuestKillTargetList { get; set; }
    }
}
