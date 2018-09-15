using System;
using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class Skill
    {
        public Skill()
        {
            CraftBlueprints = new HashSet<CraftBlueprint>();
            PCSkills = new HashSet<PCSkill>();
            PerkLevelSkillRequirements = new HashSet<PerkLevelSkillRequirement>();
            SkillXPRequirement = new HashSet<SkillXPRequirement>();
        }

        public int SkillID { get; set; }
        public int SkillCategoryID { get; set; }
        public string Name { get; set; }
        public int MaxRank { get; set; }
        public bool IsActive { get; set; }
        public string Description { get; set; }
        public int Primary { get; set; }
        public int Secondary { get; set; }
        public int Tertiary { get; set; }

        public Attribute PrimaryNavigation { get; set; }
        public Attribute SecondaryNavigation { get; set; }
        public SkillCategory SkillCategory { get; set; }
        public Attribute TertiaryNavigation { get; set; }
        public ICollection<CraftBlueprint> CraftBlueprints { get; set; }
        public ICollection<PCSkill> PCSkills { get; set; }
        public ICollection<PerkLevelSkillRequirement> PerkLevelSkillRequirements { get; set; }
        public ICollection<SkillXPRequirement> SkillXPRequirement { get; set; }
    }
}
