using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class SpawnTables
    {
        public SpawnTables()
        {
            SpawnTableCreatures = new HashSet<SpawnTableCreatures>();
        }

        public int SpawnTableId { get; set; }
        public string Name { get; set; }

        public ICollection<SpawnTableCreatures> SpawnTableCreatures { get; set; }
    }
}
