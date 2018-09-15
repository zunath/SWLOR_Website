namespace SWLOR.Web.Data.Entities
{
    public partial class SkillXPRequirement
    {
        public int SkillXPRequirementID { get; set; }
        public int SkillID { get; set; }
        public int Rank { get; set; }
        public int XP { get; set; }

        public Skill Skill { get; set; }
    }
}
