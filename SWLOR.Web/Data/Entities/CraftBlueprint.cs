using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class CraftBlueprint
    {
        public CraftBlueprint()
        {
            PCCraftedBlueprint = new HashSet<PCCraftedBlueprint>();
        }

        public int ID { get; set; }
        public int CraftCategoryID { get; set; }
        public int BaseLevel { get; set; }
        public string ItemName { get; set; }
        public string ItemResref { get; set; }
        public int Quantity { get; set; }
        public int SkillID { get; set; }
        public int CraftDeviceID { get; set; }
        public int? PerkID { get; set; }
        public int RequiredPerkLevel { get; set; }
        public bool IsActive { get; set; }
        public int MainComponentTypeID { get; set; }
        public int MainMinimum { get; set; }
        public int SecondaryComponentTypeID { get; set; }
        public int SecondaryMinimum { get; set; }
        public int TertiaryComponentTypeID { get; set; }
        public int TertiaryMinimum { get; set; }
        public int EnhancementSlots { get; set; }
        public int MainMaximum { get; set; }
        public int SecondaryMaximum { get; set; }
        public int TertiaryMaximum { get; set; }
        public int? BaseStructureID { get; set; }

        public BaseStructure BaseStructure { get; set; }
        public CraftBlueprintCategory CraftCategory { get; set; }
        public CraftDevice CraftDevice { get; set; }
        public ComponentType MainComponentType { get; set; }
        public Perk Perk { get; set; }
        public ComponentType SecondaryComponentType { get; set; }
        public Skill Skill { get; set; }
        public ComponentType TertiaryComponentType { get; set; }
        public ICollection<PCCraftedBlueprint> PCCraftedBlueprint { get; set; }
    }
}
