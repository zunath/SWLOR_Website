using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public class CraftBlueprint
    {
        public CraftBlueprint()
        {
            CraftBlueprintComponents = new HashSet<CraftBlueprintComponent>();
        }

        public long CraftBlueprintID { get; set; }
        public long CraftCategoryID { get; set; }
        public int Level { get; set; }
        public string ItemName { get; set; }
        public string ItemResref { get; set; }
        public int Quantity { get; set; }
        public int SkillID { get; set; }
        public int CraftDeviceID { get; set; }
        public int? PerkID { get; set; }
        public int RequiredPerkLevel { get; set; }
        public bool IsActive { get; set; }
        public int CraftTierLevel { get; set; }

        public CraftBlueprintCategory CraftCategory { get; set; }
        public CraftDevice CraftDevice { get; set; }
        public Perk Perk { get; set; }
        public Skill Skill { get; set; }
        public ICollection<CraftBlueprintComponent> CraftBlueprintComponents { get; set; }
    }
}
