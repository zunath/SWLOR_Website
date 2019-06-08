using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class QuestRewardItem
    {
        public QuestRewardItem()
        {
            PCQuestStatus = new HashSet<PCQuestStatus>();
        }

        public int ID { get; set; }
        public int QuestID { get; set; }
        public string Resref { get; set; }
        public int Quantity { get; set; }

        public virtual Quest Quest { get; set; }
        public virtual ICollection<PCQuestStatus> PCQuestStatus { get; set; }
    }
}