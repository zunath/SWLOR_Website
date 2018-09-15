using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class LootTable
    {
        public LootTable()
        {
            LootTableItems = new HashSet<LootTableItem>();
        }

        public int LootTableID { get; set; }
        public string Name { get; set; }

        public ICollection<LootTableItem> LootTableItems { get; set; }
    }
}
