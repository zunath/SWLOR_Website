using System;
using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class Plant
    {
        public Plant()
        {
            GrowingPlants = new HashSet<GrowingPlant>();
        }

        public int PlantID { get; set; }
        public string Name { get; set; }
        public int BaseTicks { get; set; }
        public string Resref { get; set; }
        public int WaterTicks { get; set; }
        public int Level { get; set; }
        public string SeedResref { get; set; }

        public ICollection<GrowingPlant> GrowingPlants { get; set; }
    }
}
