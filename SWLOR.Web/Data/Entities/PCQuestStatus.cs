using System;
using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class PCQuestStatus
    {
        public PCQuestStatus()
        {
            PCQuestItemProgress = new HashSet<PCQuestItemProgress>();
            PCQuestKillTargetProgress = new HashSet<PCQuestKillTargetProgress>();
        }

        public Guid ID { get; set; }
        public Guid PlayerID { get; set; }
        public int QuestID { get; set; }
        public int CurrentQuestStateID { get; set; }
        public DateTime? CompletionDate { get; set; }
        public int? SelectedItemRewardID { get; set; }

        public QuestState CurrentQuestState { get; set; }
        public Player Player { get; set; }
        public Quest Quest { get; set; }
        public QuestRewardItem SelectedItemReward { get; set; }
        public ICollection<PCQuestItemProgress> PCQuestItemProgress { get; set; }
        public ICollection<PCQuestKillTargetProgress> PCQuestKillTargetProgress { get; set; }
    }
}
