namespace SWLOR.Web.Data.Entities
{
    public partial class PlayerProgressionSkills
    {
        public int PlayerProgressionSkillId { get; set; }
        public string PlayerId { get; set; }
        public long ProgressionSkillId { get; set; }
        public int UpgradeLevel { get; set; }
        public bool IsSoftCapUnlocked { get; set; }

        public PlayerCharacters Player { get; set; }
        public ProgressionSkills ProgressionSkill { get; set; }
    }
}
