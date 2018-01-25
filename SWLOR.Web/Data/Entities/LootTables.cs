using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class LootTables
    {
        public LootTables()
        {
            LootTableItems = new HashSet<LootTableItems>();
            SpawnTableCreatures = new HashSet<SpawnTableCreatures>();
        }

        public int LootTableId { get; set; }
        public string Name { get; set; }

        public ICollection<LootTableItems> LootTableItems { get; set; }
        public ICollection<SpawnTableCreatures> SpawnTableCreatures { get; set; }
    }
}
