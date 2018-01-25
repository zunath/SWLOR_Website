using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class KeyItemCategories
    {
        public KeyItemCategories()
        {
            KeyItems = new HashSet<KeyItems>();
        }

        public int KeyItemCategoryId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public ICollection<KeyItems> KeyItems { get; set; }
    }
}
