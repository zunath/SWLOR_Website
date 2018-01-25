using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class ProgressionSkills
    {
        public ProgressionSkills()
        {
            PlayerProgressionSkills = new HashSet<PlayerProgressionSkills>();
        }

        public long SkillId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int MaxUpgrades { get; set; }
        public int SoftCap { get; set; }
        public int InitialPrice { get; set; }
        public bool IsFeat { get; set; }
        public bool IsDisabled { get; set; }

        public ICollection<PlayerProgressionSkills> PlayerProgressionSkills { get; set; }
    }
}
