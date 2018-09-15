using System.Collections.Generic;

namespace SWLOR.Web.Models.UI.Perks
{
    public class PerkLevelUI
    {
        public int PerkLevelID { get; set; }
        public int Level { get; set; }

        public string Description { get; set; }
        public int Price { get; set; }

        public IEnumerable<PerkSkillRequirementUI> SkillRequirements { get; set; }

        public PerkLevelUI()
        {
            SkillRequirements = new List<PerkSkillRequirementUI>();
        }
    }
}
