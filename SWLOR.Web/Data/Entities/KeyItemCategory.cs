using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class KeyItemCategory
    {
        public KeyItemCategory()
        {
            KeyItem = new HashSet<KeyItem>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<KeyItem> KeyItem { get; set; }
    }
}