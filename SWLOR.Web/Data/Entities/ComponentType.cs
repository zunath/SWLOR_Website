using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class ComponentType
    {
        public ComponentType()
        {
            CraftBlueprintsMainComponentType = new HashSet<CraftBlueprint>();
            CraftBlueprintsSecondaryComponentType = new HashSet<CraftBlueprint>();
            CraftBlueprintsTertiaryComponentType = new HashSet<CraftBlueprint>();
        }

        public int ComponentTypeID { get; set; }
        public string Name { get; set; }

        public ICollection<CraftBlueprint> CraftBlueprintsMainComponentType { get; set; }
        public ICollection<CraftBlueprint> CraftBlueprintsSecondaryComponentType { get; set; }
        public ICollection<CraftBlueprint> CraftBlueprintsTertiaryComponentType { get; set; }
    }
}
