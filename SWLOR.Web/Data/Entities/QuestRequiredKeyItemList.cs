using System;
using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class QuestRequiredKeyItemList
    {
        public int QuestRequiredKeyItemID { get; set; }
        public int QuestID { get; set; }
        public int KeyItemID { get; set; }
        public int QuestStateID { get; set; }

        public KeyItem KeyItem { get; set; }
        public Quest Quest { get; set; }
        public QuestState QuestState { get; set; }
    }
}
