using System;
using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class PerkLevelSkillRequirement
    {
        public int PerkLevelSkillRequirementID { get; set; }
        public int PerkLevelID { get; set; }
        public int SkillID { get; set; }
        public int RequiredRank { get; set; }

        public PerkLevel PerkLevel { get; set; }
        public Skill Skill { get; set; }
    }
}
