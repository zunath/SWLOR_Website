using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class CraftBlueprints
    {
        public CraftBlueprints()
        {
            CraftBlueprintComponents = new HashSet<CraftBlueprintComponents>();
            Pcblueprints = new HashSet<PCBlueprints>();
            ResearchBlueprints = new HashSet<ResearchBlueprints>();
        }

        public long CraftBlueprintId { get; set; }
        public long CraftId { get; set; }
        public long CraftCategoryId { get; set; }
        public int Level { get; set; }
        public string ItemName { get; set; }
        public string ItemResref { get; set; }
        public int Quantity { get; set; }

        public Crafts Craft { get; set; }
        public CraftBlueprintCategories CraftCategory { get; set; }
        public ICollection<CraftBlueprintComponents> CraftBlueprintComponents { get; set; }
        public ICollection<PCBlueprints> Pcblueprints { get; set; }
        public ICollection<ResearchBlueprints> ResearchBlueprints { get; set; }
    }
}
