using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class Quests
    {
        public Quests()
        {
            PcquestStatus = new HashSet<PCQuestStatus>();
            QuestKillTargetList = new HashSet<QuestKillTargetList>();
            QuestPrerequisitesQuest = new HashSet<QuestPrerequisites>();
            QuestPrerequisitesRequiredQuest = new HashSet<QuestPrerequisites>();
            QuestRequiredItemList = new HashSet<QuestRequiredItemList>();
            QuestRequiredKeyItemList = new HashSet<QuestRequiredKeyItemList>();
            QuestRewardItems = new HashSet<QuestRewardItems>();
            QuestStates = new HashSet<QuestStates>();
        }

        public int QuestId { get; set; }
        public string Name { get; set; }
        public string JournalTag { get; set; }
        public int FameRegionId { get; set; }
        public int RequiredFameAmount { get; set; }
        public bool AllowRewardSelection { get; set; }
        public int RewardGold { get; set; }
        public int RewardXp { get; set; }
        public int? RewardKeyItemId { get; set; }
        public int RewardFame { get; set; }
        public bool IsRepeatable { get; set; }
        public string MapNoteTag { get; set; }
        public int? StartKeyItemId { get; set; }
        public bool RemoveStartKeyItemAfterCompletion { get; set; }

        public FameRegions FameRegion { get; set; }
        public KeyItems RewardKeyItem { get; set; }
        public KeyItems StartKeyItem { get; set; }
        public ICollection<PCQuestStatus> PcquestStatus { get; set; }
        public ICollection<QuestKillTargetList> QuestKillTargetList { get; set; }
        public ICollection<QuestPrerequisites> QuestPrerequisitesQuest { get; set; }
        public ICollection<QuestPrerequisites> QuestPrerequisitesRequiredQuest { get; set; }
        public ICollection<QuestRequiredItemList> QuestRequiredItemList { get; set; }
        public ICollection<QuestRequiredKeyItemList> QuestRequiredKeyItemList { get; set; }
        public ICollection<QuestRewardItems> QuestRewardItems { get; set; }
        public ICollection<QuestStates> QuestStates { get; set; }
    }
}
