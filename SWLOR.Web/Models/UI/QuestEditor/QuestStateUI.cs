using System.Collections.Generic;

namespace SWLOR.Web.Models.UI.QuestEditor
{
    public class QuestStateUI
    {
        public int QuestTypeID { get; set; }
        public int JournalStateID { get; set; }

        public List<QuestKillTargetUI> KillTargets { get; set; }
        public List<QuestRequiredItemUI> RequiredItems { get; set; }
        public List<QuestRequiredKeyItemUI> RequiredKeyItems { get; set; }

        public QuestStateUI()
        {
            KillTargets = new List<QuestKillTargetUI>();
            RequiredItems = new List<QuestRequiredItemUI>();
            RequiredKeyItems = new List<QuestRequiredKeyItemUI>();
        }
    }
}
