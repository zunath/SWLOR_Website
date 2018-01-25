using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class StructureBlueprints
    {
        public StructureBlueprints()
        {
            ConstructionSites = new HashSet<ConstructionSites>();
            PcterritoryFlags = new HashSet<PCTerritoryFlags>();
            PcterritoryFlagsStructures = new HashSet<PCTerritoryFlagsStructures>();
        }

        public int StructureBlueprintId { get; set; }
        public int StructureCategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Resref { get; set; }
        public bool IsActive { get; set; }
        public bool IsTerritoryFlag { get; set; }
        public bool IsUseable { get; set; }
        public int WoodRequired { get; set; }
        public int MetalRequired { get; set; }
        public int NailsRequired { get; set; }
        public int ClothRequired { get; set; }
        public int LeatherRequired { get; set; }
        public int ItemStorageCount { get; set; }
        public int MaxStructuresCount { get; set; }
        public double MaxBuildDistance { get; set; }
        public int IronRequired { get; set; }
        public int ResearchSlots { get; set; }
        public int RpperSecond { get; set; }

        public StructureCategories StructureCategory { get; set; }
        public ICollection<ConstructionSites> ConstructionSites { get; set; }
        public ICollection<PCTerritoryFlags> PcterritoryFlags { get; set; }
        public ICollection<PCTerritoryFlagsStructures> PcterritoryFlagsStructures { get; set; }
    }
}
