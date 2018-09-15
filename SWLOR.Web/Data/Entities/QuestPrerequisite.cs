using System;
using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class QuestPrerequisite
    {
        public int QuestPrerequisiteID { get; set; }
        public int QuestID { get; set; }
        public int RequiredQuestID { get; set; }

        public Quest Quest { get; set; }
        public Quest RequiredQuest { get; set; }
    }
}
