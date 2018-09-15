using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public class StructureBlueprint
    {
        public StructureBlueprint()
        {
            StructureComponents = new HashSet<StructureComponent>();
        }

        public int StructureBlueprintID { get; set; }
        public int StructureCategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Resref { get; set; }
        public bool IsActive { get; set; }
        public bool IsTerritoryFlag { get; set; }
        public bool IsUseable { get; set; }
        public int ItemStorageCount { get; set; }
        public int VanityCount { get; set; }
        public double MaxBuildDistance { get; set; }
        public int Level { get; set; }
        public int? PerkID { get; set; }
        public int RequiredPerkLevel { get; set; }
        public bool GivesSkillXP { get; set; }
        public int SpecialCount { get; set; }
        public bool IsVanity { get; set; }
        public bool IsSpecial { get; set; }
        public int CraftTierLevel { get; set; }

        public Perk Perk { get; set; }
        public StructureCategory StructureCategory { get; set; }
        public ICollection<StructureComponent> StructureComponents { get; set; }
    }
}
