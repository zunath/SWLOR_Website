using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class Abilities
    {
        public Abilities()
        {
            PcequippedAbilitiesSlot10Navigation = new HashSet<PCEquippedAbilities>();
            PcequippedAbilitiesSlot1Navigation = new HashSet<PCEquippedAbilities>();
            PcequippedAbilitiesSlot2Navigation = new HashSet<PCEquippedAbilities>();
            PcequippedAbilitiesSlot3Navigation = new HashSet<PCEquippedAbilities>();
            PcequippedAbilitiesSlot4Navigation = new HashSet<PCEquippedAbilities>();
            PcequippedAbilitiesSlot5Navigation = new HashSet<PCEquippedAbilities>();
            PcequippedAbilitiesSlot6Navigation = new HashSet<PCEquippedAbilities>();
            PcequippedAbilitiesSlot7Navigation = new HashSet<PCEquippedAbilities>();
            PcequippedAbilitiesSlot8Navigation = new HashSet<PCEquippedAbilities>();
            PcequippedAbilitiesSlot9Navigation = new HashSet<PCEquippedAbilities>();
            PclearnedAbilities = new HashSet<PCLearnedAbilities>();
        }

        public int AbilityId { get; set; }
        public string Name { get; set; }
        public int FeatId { get; set; }
        public bool IsActive { get; set; }
        public string JavaScriptName { get; set; }
        public int BaseManaCost { get; set; }
        public double BaseCastingTime { get; set; }
        public string Description { get; set; }
        public int AbilityCategoryId { get; set; }
        public int? AbilityCooldownCategoryId { get; set; }
        public bool IsQueuedWeaponSkill { get; set; }

        public AbilityCategories AbilityCategory { get; set; }
        public AbilityCooldownCategories AbilityCooldownCategory { get; set; }
        public ICollection<PCEquippedAbilities> PcequippedAbilitiesSlot10Navigation { get; set; }
        public ICollection<PCEquippedAbilities> PcequippedAbilitiesSlot1Navigation { get; set; }
        public ICollection<PCEquippedAbilities> PcequippedAbilitiesSlot2Navigation { get; set; }
        public ICollection<PCEquippedAbilities> PcequippedAbilitiesSlot3Navigation { get; set; }
        public ICollection<PCEquippedAbilities> PcequippedAbilitiesSlot4Navigation { get; set; }
        public ICollection<PCEquippedAbilities> PcequippedAbilitiesSlot5Navigation { get; set; }
        public ICollection<PCEquippedAbilities> PcequippedAbilitiesSlot6Navigation { get; set; }
        public ICollection<PCEquippedAbilities> PcequippedAbilitiesSlot7Navigation { get; set; }
        public ICollection<PCEquippedAbilities> PcequippedAbilitiesSlot8Navigation { get; set; }
        public ICollection<PCEquippedAbilities> PcequippedAbilitiesSlot9Navigation { get; set; }
        public ICollection<PCLearnedAbilities> PclearnedAbilities { get; set; }
    }
}
