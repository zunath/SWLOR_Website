using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class QuestTypeDomain
    {
        public QuestTypeDomain()
        {
            QuestStates = new HashSet<QuestStates>();
        }

        public int QuestTypeId { get; set; }
        public string Name { get; set; }

        public ICollection<QuestStates> QuestStates { get; set; }
    }
}
