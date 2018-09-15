using System;
using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class QuestTypeDomain
    {
        public QuestTypeDomain()
        {
            QuestStates = new HashSet<QuestState>();
        }

        public int QuestTypeID { get; set; }
        public string Name { get; set; }

        public ICollection<QuestState> QuestStates { get; set; }
    }
}
