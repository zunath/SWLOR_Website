using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class QuestRewardItems
    {
        public QuestRewardItems()
        {
            PcquestStatus = new HashSet<PCQuestStatus>();
        }

        public int QuestRewardItemId { get; set; }
        public int QuestId { get; set; }
        public string Resref { get; set; }
        public int Quantity { get; set; }

        public Quests Quest { get; set; }
        public ICollection<PCQuestStatus> PcquestStatus { get; set; }
    }
}
