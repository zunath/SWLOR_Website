using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class ComponentType
    {
        public ComponentType()
        {
            CraftBlueprintMainComponentType = new HashSet<CraftBlueprint>();
            CraftBlueprintSecondaryComponentType = new HashSet<CraftBlueprint>();
            CraftBlueprintTertiaryComponentType = new HashSet<CraftBlueprint>();
        }

        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<CraftBlueprint> CraftBlueprintMainComponentType { get; set; }
        public ICollection<CraftBlueprint> CraftBlueprintSecondaryComponentType { get; set; }
        public ICollection<CraftBlueprint> CraftBlueprintTertiaryComponentType { get; set; }
    }
}
