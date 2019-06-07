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
        public int ClusterID { get; set; }

        public virtual QuestState CurrentQuestState { get; set; }
        public virtual Player Player { get; set; }
        public virtual Quest Quest { get; set; }
        public virtual QuestRewardItem SelectedItemReward { get; set; }
        public virtual ICollection<PCQuestItemProgress> PCQuestItemProgress { get; set; }
        public virtual ICollection<PCQuestKillTargetProgress> PCQuestKillTargetProgress { get; set; }
    }
}