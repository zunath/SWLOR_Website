using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class KeyItem
    {
        public KeyItem()
        {
            PCKeyItem = new HashSet<PCKeyItem>();
            QuestRequiredKeyItem = new HashSet<QuestRequiredKeyItem>();
            QuestRewardKeyItem = new HashSet<Quest>();
            QuestStartKeyItem = new HashSet<Quest>();
        }

        public int ID { get; set; }
        public int KeyItemCategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public KeyItemCategory KeyItemCategory { get; set; }
        public ICollection<PCKeyItem> PCKeyItem { get; set; }
        public ICollection<QuestRequiredKeyItem> QuestRequiredKeyItem { get; set; }
        public ICollection<Quest> QuestRewardKeyItem { get; set; }
        public ICollection<Quest> QuestStartKeyItem { get; set; }
    }
}
