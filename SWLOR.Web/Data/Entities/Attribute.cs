using System.Collections.Generic;
using Newtonsoft.Json;

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

        [JsonIgnore]
        public ICollection<Skill> SkillsPrimaryNavigation { get; set; }
        [JsonIgnore]
        public ICollection<Skill> SkillsSecondaryNavigation { get; set; }
        [JsonIgnore]
        public ICollection<Skill> SkillsTertiaryNavigation { get; set; }
    }
}
