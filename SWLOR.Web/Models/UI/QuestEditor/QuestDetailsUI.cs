using System.Collections.Generic;

namespace SWLOR.Web.Models.UI.QuestEditor
{
    public class QuestDetailsUI
    {
        public int QuestID { get; set; }
        public string Name { get; set; }
        public string JournalTag { get; set; }
        public int FameRegionID { get; set; }
        public int RequiredFameAmount { get; set; }
        public bool AllowRewardSelection { get; set; }
        public bool IsRepeatable { get; set; }
        public string MapNoteTag { get; set; }
        public int StartKeyItemID { get; set; }
        public bool RemoveStartKeyItemAfterCompletion { get; set; }
        public string OnAcceptRule { get; set; }
        public string OnAdvanceRule { get; set; }
        public string OnCompleteRule { get; set; }
        public string OnKillTargetRule { get; set; }
        public string OnAcceptArgs { get; set; }
        public string OnAdvanceArgs { get; set; }
        public string OnCompleteArgs { get; set; }
        public string OnKillTargetArgs { get; set; }

        public List<int> PrerequisiteQuestIDs { get; set; }
        public QuestRewardsUI Rewards { get; set; }
        public List<QuestStateUI> QuestStates { get; set; }

        public QuestDetailsUI()
        {
            QuestID = 0;
            Name = string.Empty;
            JournalTag = string.Empty;
            FameRegionID = 1;
            RequiredFameAmount = 0;
            AllowRewardSelection = false;
            IsRepeatable = false;
            MapNoteTag = string.Empty;
            StartKeyItemID = -1;
            RemoveStartKeyItemAfterCompletion = false;

            PrerequisiteQuestIDs = new List<int>();
            QuestStates = new List<QuestStateUI>();
            Rewards = new QuestRewardsUI();
        }
    }

}
