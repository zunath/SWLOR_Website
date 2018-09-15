using System;
using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class SpawnObjectType
    {
        public SpawnObjectType()
        {
            Spawns = new HashSet<Spawn>();
        }

        public int SpawnObjectTypeID { get; set; }
        public string Name { get; set; }

        public ICollection<Spawn> Spawns { get; set; }
    }
}
