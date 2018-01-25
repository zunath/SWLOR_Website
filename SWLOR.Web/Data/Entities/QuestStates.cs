using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class QuestStates
    {
        public QuestStates()
        {
            PcquestStatus = new HashSet<PCQuestStatus>();
            QuestKillTargetList = new HashSet<QuestKillTargetList>();
            QuestRequiredItemList = new HashSet<QuestRequiredItemList>();
            QuestRequiredKeyItemList = new HashSet<QuestRequiredKeyItemList>();
        }

        public int QuestStateId { get; set; }
        public int QuestId { get; set; }
        public int Sequence { get; set; }
        public int QuestTypeId { get; set; }
        public int JournalStateId { get; set; }
        public bool IsFinalState { get; set; }

        public Quests Quest { get; set; }
        public QuestTypeDomain QuestType { get; set; }
        public ICollection<PCQuestStatus> PcquestStatus { get; set; }
        public ICollection<QuestKillTargetList> QuestKillTargetList { get; set; }
        public ICollection<QuestRequiredItemList> QuestRequiredItemList { get; set; }
        public ICollection<QuestRequiredKeyItemList> QuestRequiredKeyItemList { get; set; }
    }
}
