using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class StructureCategories
    {
        public StructureCategories()
        {
            StructureBlueprints = new HashSet<StructureBlueprints>();
        }

        public int StructureCategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsTerritoryFlagCategory { get; set; }

        public ICollection<StructureBlueprints> StructureBlueprints { get; set; }
    }
}
