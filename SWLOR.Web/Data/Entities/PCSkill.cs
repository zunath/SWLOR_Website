namespace SWLOR.Web.Data.Entities
{
    public class PCSkill
    {
        public int PCSkillID { get; set; }
        public string PlayerID { get; set; }
        public int SkillID { get; set; }
        public int XP { get; set; }
        public int Rank { get; set; }
        public bool IsLocked { get; set; }

        public PlayerCharacter Player { get; set; }
        public Skill Skill { get; set; }
    }
}
