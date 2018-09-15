using System.ComponentModel.DataAnnotations.Schema;

namespace SWLOR.Web.Data.Entities
{
    public class PerkLevelSkillRequirement
    {
        public int PerkLevelSkillRequirementID { get; set; }
        public int PerkLevelID { get; set; }
        public int SkillID { get; set; }
        public int RequiredRank { get; set; }

        [ForeignKey("SkillID")]
        public Skill Skill { get; set; }

    }
}
