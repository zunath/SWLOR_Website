using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class Plant
    {
        public Plant()
        {
            GrowingPlant = new HashSet<GrowingPlant>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public int BaseTicks { get; set; }
        public string Resref { get; set; }
        public int WaterTicks { get; set; }
        public int Level { get; set; }
        public string SeedResref { get; set; }

        public ICollection<GrowingPlant> GrowingPlant { get; set; }
    }
}
