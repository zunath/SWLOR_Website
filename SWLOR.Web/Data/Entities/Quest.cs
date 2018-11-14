using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class Quest
    {
        public Quest()
        {
            PCQuestStatus = new HashSet<PCQuestStatus>();
            PerkLevelQuestRequirement = new HashSet<PerkLevelQuestRequirement>();
            QuestKillTarget = new HashSet<QuestKillTarget>();
            QuestPrerequisiteQuest = new HashSet<QuestPrerequisite>();
            QuestPrerequisiteRequiredQuest = new HashSet<QuestPrerequisite>();
            QuestRequiredItem = new HashSet<QuestRequiredItem>();
            QuestRequiredKeyItem = new HashSet<QuestRequiredKeyItem>();
            QuestRewardItem = new HashSet<QuestRewardItem>();
            QuestState = new HashSet<QuestState>();
        }

        public int ID { get; set; }
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
        public string OnAcceptRule { get; set; }
        public string OnAdvanceRule { get; set; }
        public string OnCompleteRule { get; set; }
        public string OnKillTargetRule { get; set; }
        public string OnAcceptArgs { get; set; }
        public string OnAdvanceArgs { get; set; }
        public string OnCompleteArgs { get; set; }
        public string OnKillTargetArgs { get; set; }

        public FameRegion FameRegion { get; set; }
        public KeyItem RewardKeyItem { get; set; }
        public KeyItem StartKeyItem { get; set; }
        public ICollection<PCQuestStatus> PCQuestStatus { get; set; }
        public ICollection<PerkLevelQuestRequirement> PerkLevelQuestRequirement { get; set; }
        public ICollection<QuestKillTarget> QuestKillTarget { get; set; }
        public ICollection<QuestPrerequisite> QuestPrerequisiteQuest { get; set; }
        public ICollection<QuestPrerequisite> QuestPrerequisiteRequiredQuest { get; set; }
        public ICollection<QuestRequiredItem> QuestRequiredItem { get; set; }
        public ICollection<QuestRequiredKeyItem> QuestRequiredKeyItem { get; set; }
        public ICollection<QuestRewardItem> QuestRewardItem { get; set; }
        public ICollection<QuestState> QuestState { get; set; }
    }
}
