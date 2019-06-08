using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class LootTable
    {
        public LootTable()
        {
            AreaNortheastLootTable = new HashSet<Area>();
            AreaNorthwestLootTable = new HashSet<Area>();
            AreaSoutheastLootTable = new HashSet<Area>();
            AreaSouthwestLootTable = new HashSet<Area>();
            LootTableItem = new HashSet<LootTableItem>();
        }

        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Area> AreaNortheastLootTable { get; set; }
        public virtual ICollection<Area> AreaNorthwestLootTable { get; set; }
        public virtual ICollection<Area> AreaSoutheastLootTable { get; set; }
        public virtual ICollection<Area> AreaSouthwestLootTable { get; set; }
        public virtual ICollection<LootTableItem> LootTableItem { get; set; }
    }
}