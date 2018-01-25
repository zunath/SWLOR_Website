using System;
using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class PCQuestStatus
    {
        public PCQuestStatus()
        {
            PcquestKillTargetProgress = new HashSet<PCQuestKillTargetProgress>();
        }

        public int PcquestStatusId { get; set; }
        public string PlayerId { get; set; }
        public int QuestId { get; set; }
        public int CurrentQuestStateId { get; set; }
        public DateTime? CompletionDate { get; set; }
        public int? SelectedItemRewardId { get; set; }

        public QuestStates CurrentQuestState { get; set; }
        public PlayerCharacters Player { get; set; }
        public Quests Quest { get; set; }
        public QuestRewardItems SelectedItemReward { get; set; }
        public ICollection<PCQuestKillTargetProgress> PcquestKillTargetProgress { get; set; }
    }
}
