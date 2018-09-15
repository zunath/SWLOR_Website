using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public class QuestState
    {
        public QuestState()
        {
            QuestKillTargetList = new HashSet<QuestKillTargetList>();
            QuestRequiredItemList = new HashSet<QuestRequiredItemList>();
            QuestRequiredKeyItemList = new HashSet<QuestRequiredKeyItemList>();
        }

        public int QuestStateID { get; set; }
        public int QuestID { get; set; }
        public int Sequence { get; set; }
        public int QuestTypeID { get; set; }
        public int JournalStateID { get; set; }
        public bool IsFinalState { get; set; }

        public Quests Quest { get; set; }
        public QuestTypeDomain QuestType { get; set; }
        public ICollection<QuestKillTargetList> QuestKillTargetList { get; set; }
        public ICollection<QuestRequiredItemList> QuestRequiredItemList { get; set; }
        public ICollection<QuestRequiredKeyItemList> QuestRequiredKeyItemList { get; set; }
    }
}
