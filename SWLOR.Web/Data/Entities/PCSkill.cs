using System;

namespace SWLOR.Web.Data.Entities
{
    public partial class PCSkill
    {
        public Guid ID { get; set; }
        public Guid PlayerID { get; set; }
        public int SkillID { get; set; }
        public int XP { get; set; }
        public int Rank { get; set; }
        public bool IsLocked { get; set; }

        public Player Player { get; set; }
        public Skill Skill { get; set; }
    }
}
