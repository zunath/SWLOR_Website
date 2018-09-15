using System;
using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class CraftBlueprintCategory
    {
        public CraftBlueprintCategory()
        {
            CraftBlueprints = new HashSet<CraftBlueprint>();
        }

        public long CraftBlueprintCategoryID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public ICollection<CraftBlueprint> CraftBlueprints { get; set; }
    }
}
