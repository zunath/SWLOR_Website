using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class CraftBlueprintCategories
    {
        public CraftBlueprintCategories()
        {
            CraftBlueprints = new HashSet<CraftBlueprints>();
        }

        public long CraftBlueprintCategoryId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public ICollection<CraftBlueprints> CraftBlueprints { get; set; }
    }
}
