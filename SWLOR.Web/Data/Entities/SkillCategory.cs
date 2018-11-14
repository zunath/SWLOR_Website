using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class SkillCategory
    {
        public SkillCategory()
        {
            Skill = new HashSet<Skill>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int Sequence { get; set; }

        public ICollection<Skill> Skill { get; set; }
    }
}
