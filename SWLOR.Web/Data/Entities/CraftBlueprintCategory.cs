using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class CraftBlueprintCategory
    {
        public CraftBlueprintCategory()
        {
            CraftBlueprint = new HashSet<CraftBlueprint>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public ICollection<CraftBlueprint> CraftBlueprint { get; set; }
    }
}
