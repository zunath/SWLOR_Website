using System;
using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class SkillCategory
    {
        public SkillCategory()
        {
            Skills = new HashSet<Skill>();
        }

        public int SkillCategoryID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public int Sequence { get; set; }

        public ICollection<Skill> Skills { get; set; }
    }
}
