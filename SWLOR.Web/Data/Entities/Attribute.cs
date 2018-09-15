using System;
using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class Attribute
    {
        public Attribute()
        {
            SkillsPrimaryNavigation = new HashSet<Skill>();
            SkillsSecondaryNavigation = new HashSet<Skill>();
            SkillsTertiaryNavigation = new HashSet<Skill>();
        }

        public int AttributeID { get; set; }
        public int NWNValue { get; set; }
        public string Name { get; set; }

        public ICollection<Skill> SkillsPrimaryNavigation { get; set; }
        public ICollection<Skill> SkillsSecondaryNavigation { get; set; }
        public ICollection<Skill> SkillsTertiaryNavigation { get; set; }
    }
}
