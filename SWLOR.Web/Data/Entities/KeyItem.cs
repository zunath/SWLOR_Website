using System;
using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class KeyItem
    {
        public KeyItem()
        {
            PCKeyItems = new HashSet<PCKeyItem>();
            QuestRequiredKeyItemList = new HashSet<QuestRequiredKeyItemList>();
            QuestsRewardKeyItem = new HashSet<Quest>();
            QuestsStartKeyItem = new HashSet<Quest>();
        }

        public int KeyItemID { get; set; }
        public int KeyItemCategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public KeyItemCategory KeyItemCategory { get; set; }
        public ICollection<PCKeyItem> PCKeyItems { get; set; }
        public ICollection<QuestRequiredKeyItemList> QuestRequiredKeyItemList { get; set; }
        public ICollection<Quest> QuestsRewardKeyItem { get; set; }
        public ICollection<Quest> QuestsStartKeyItem { get; set; }
    }
}
