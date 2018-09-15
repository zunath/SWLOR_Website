using System.Collections.Generic;

namespace SWLOR.Web.Models.UI.QuestEditor
{
    public class QuestRewardsUI
    {
        public int Gold { get; set; }
        public int XP { get; set; }
        public int KeyItemID { get; set; }
        public int Fame { get; set; }

        public List<QuestRewardItemUI> RewardItems { get; set; }

        public QuestRewardsUI()
        {
            Gold = 0;
            XP = 0;
            KeyItemID = -1;
            Fame = 0;

            RewardItems = new List<QuestRewardItemUI>();
        }
    }
}
