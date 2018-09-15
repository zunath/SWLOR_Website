using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class Quest
    {
        public Quest()
        {
            PCQuestStatus = new HashSet<PCQuestStatus>();
            QuestKillTargetList = new HashSet<QuestKillTargetList>();
            QuestPrerequisitesQuest = new HashSet<QuestPrerequisite>();
            QuestPrerequisitesRequiredQuest = new HashSet<QuestPrerequisite>();
            QuestRequiredItemList = new HashSet<QuestRequiredItemList>();
            QuestRequiredKeyItemList = new HashSet<QuestRequiredKeyItemList>();
            QuestRewardItems = new HashSet<QuestRewardItem>();
            QuestStates = new HashSet<QuestState>();
        }

        public int QuestID { get; set; }
        public string Name { get; set; }
        public string JournalTag { get; set; }
        public int FameRegionID { get; set; }
        public int RequiredFameAmount { get; set; }
        public bool AllowRewardSelection { get; set; }
        public int RewardGold { get; set; }
        public int? RewardKeyItemID { get; set; }
        public int RewardFame { get; set; }
        public bool IsRepeatable { get; set; }
        public string MapNoteTag { get; set; }
        public int? StartKeyItemID { get; set; }
        public bool RemoveStartKeyItemAfterCompletion { get; set; }

        public FameRegion FameRegion { get; set; }
        public KeyItem RewardKeyItem { get; set; }
        public KeyItem StartKeyItem { get; set; }
        public ICollection<PCQuestStatus> PCQuestStatus { get; set; }
        public ICollection<QuestKillTargetList> QuestKillTargetList { get; set; }
        public ICollection<QuestPrerequisite> QuestPrerequisitesQuest { get; set; }
        public ICollection<QuestPrerequisite> QuestPrerequisitesRequiredQuest { get; set; }
        public ICollection<QuestRequiredItemList> QuestRequiredItemList { get; set; }
        public ICollection<QuestRequiredKeyItemList> QuestRequiredKeyItemList { get; set; }
        public ICollection<QuestRewardItem> QuestRewardItems { get; set; }
        public ICollection<QuestState> QuestStates { get; set; }
    }
}
