using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class Spawn
    {
        public Spawn()
        {
            Areas = new HashSet<Area>();
            SpawnObjects = new HashSet<SpawnObject>();
        }

        public int SpawnID { get; set; }
        public string Name { get; set; }
        public int SpawnObjectTypeID { get; set; }

        public SpawnObjectType SpawnObjectType { get; set; }
        public ICollection<Area> Areas { get; set; }
        public ICollection<SpawnObject> SpawnObjects { get; set; }
    }
}
