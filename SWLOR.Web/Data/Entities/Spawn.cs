using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class Spawn
    {
        public Spawn()
        {
            Area = new HashSet<Area>();
            SpawnObject = new HashSet<SpawnObject>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public int SpawnObjectTypeID { get; set; }

        public SpawnObjectType SpawnObjectType { get; set; }
        public ICollection<Area> Area { get; set; }
        public ICollection<SpawnObject> SpawnObject { get; set; }
    }
}
