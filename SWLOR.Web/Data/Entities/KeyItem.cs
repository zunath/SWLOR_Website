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

        public virtual KeyItemCategory KeyItemCategory { get; set; }
        public virtual ICollection<PCKeyItem> PCKeyItem { get; set; }
        public virtual ICollection<QuestRequiredKeyItem> QuestRequiredKeyItem { get; set; }
        public virtual ICollection<Quest> QuestRewardKeyItem { get; set; }
        public virtual ICollection<Quest> QuestStartKeyItem { get; set; }
    }
}