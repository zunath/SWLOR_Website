using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class KeyItems
    {
        public KeyItems()
        {
            PckeyItems = new HashSet<PCKeyItems>();
            QuestRequiredKeyItemList = new HashSet<QuestRequiredKeyItemList>();
            QuestsRewardKeyItem = new HashSet<Quests>();
            QuestsStartKeyItem = new HashSet<Quests>();
        }

        public int KeyItemId { get; set; }
        public int KeyItemCategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public KeyItemCategories KeyItemCategory { get; set; }
        public ICollection<PCKeyItems> PckeyItems { get; set; }
        public ICollection<QuestRequiredKeyItemList> QuestRequiredKeyItemList { get; set; }
        public ICollection<Quests> QuestsRewardKeyItem { get; set; }
        public ICollection<Quests> QuestsStartKeyItem { get; set; }
    }
}
