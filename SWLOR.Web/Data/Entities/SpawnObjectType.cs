using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class SpawnObjectType
    {
        public SpawnObjectType()
        {
            Spawn = new HashSet<Spawn>();
        }

        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<Spawn> Spawn { get; set; }
    }
}
