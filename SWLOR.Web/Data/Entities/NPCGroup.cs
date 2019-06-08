using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class NPCGroup
    {
        public NPCGroup()
        {
            PCQuestKillTargetProgress = new HashSet<PCQuestKillTargetProgress>();
            QuestKillTarget = new HashSet<QuestKillTarget>();
            SpawnObject = new HashSet<SpawnObject>();
        }

        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<PCQuestKillTargetProgress> PCQuestKillTargetProgress { get; set; }
        public virtual ICollection<QuestKillTarget> QuestKillTarget { get; set; }
        public virtual ICollection<SpawnObject> SpawnObject { get; set; }
    }
}