using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class NPCGroup
    {
        public NPCGroup()
        {
            PCQuestKillTargetProgress = new HashSet<PCQuestKillTargetProgress>();
            QuestKillTargetList = new HashSet<QuestKillTargetList>();
            SpawnObjects = new HashSet<SpawnObject>();
        }

        public int NPCGroupID { get; set; }
        public string Name { get; set; }

        public ICollection<PCQuestKillTargetProgress> PCQuestKillTargetProgress { get; set; }
        public ICollection<QuestKillTargetList> QuestKillTargetList { get; set; }
        public ICollection<SpawnObject> SpawnObjects { get; set; }
    }
}
