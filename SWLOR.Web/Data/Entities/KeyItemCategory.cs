using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class KeyItemCategory
    {
        public KeyItemCategory()
        {
            KeyItems = new HashSet<KeyItem>();
        }

        public int KeyItemCategoryID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public ICollection<KeyItem> KeyItems { get; set; }
    }
}
