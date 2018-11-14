using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class BuildingType
    {
        public BuildingType()
        {
            BuildingStyle = new HashSet<BuildingStyle>();
        }

        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<BuildingStyle> BuildingStyle { get; set; }
    }
}
