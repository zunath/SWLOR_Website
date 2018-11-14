using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class QuestState
    {
        public QuestState()
        {
            PCQuestStatus = new HashSet<PCQuestStatus>();
            QuestKillTarget = new HashSet<QuestKillTarget>();
            QuestRequiredItem = new HashSet<QuestRequiredItem>();
            QuestRequiredKeyItem = new HashSet<QuestRequiredKeyItem>();
        }

        public int ID { get; set; }
        public int QuestID { get; set; }
        public int Sequence { get; set; }
        public int QuestTypeID { get; set; }
        public int JournalStateID { get; set; }

        public Quest Quest { get; set; }
        public QuestType QuestType { get; set; }
        public ICollection<PCQuestStatus> PCQuestStatus { get; set; }
        public ICollection<QuestKillTarget> QuestKillTarget { get; set; }
        public ICollection<QuestRequiredItem> QuestRequiredItem { get; set; }
        public ICollection<QuestRequiredKeyItem> QuestRequiredKeyItem { get; set; }
    }
}
