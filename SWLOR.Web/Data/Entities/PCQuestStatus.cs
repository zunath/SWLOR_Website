using System;
using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class PCQuestStatus
    {
        public PCQuestStatus()
        {
            PCQuestKillTargetProgress = new HashSet<PCQuestKillTargetProgress>();
        }

        public int PCQuestStatusID { get; set; }
        public string PlayerID { get; set; }
        public int QuestID { get; set; }
        public int CurrentQuestStateID { get; set; }
        public DateTime? CompletionDate { get; set; }
        public int? SelectedItemRewardID { get; set; }

        public QuestState CurrentQuestState { get; set; }
        public PlayerCharacter Player { get; set; }
        public Quest Quest { get; set; }
        public QuestRewardItem SelectedItemReward { get; set; }
        public ICollection<PCQuestKillTargetProgress> PCQuestKillTargetProgress { get; set; }
    }
}
