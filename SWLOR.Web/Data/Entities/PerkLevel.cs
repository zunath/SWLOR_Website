using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class PerkLevel
    {
        public PerkLevel()
        {
            PerkLevelSkillRequirements = new HashSet<PerkLevelSkillRequirement>();
        }

        public int PerkLevelID { get; set; }
        public int PerkID { get; set; }
        public int Level { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }

        public Perk Perk { get; set; }
        public ICollection<PerkLevelSkillRequirement> PerkLevelSkillRequirements { get; set; }
    }
}
