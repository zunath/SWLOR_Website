using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class QuestType
    {
        public QuestType()
        {
            QuestState = new HashSet<QuestState>();
        }

        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<QuestState> QuestState { get; set; }
    }
}