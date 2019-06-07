using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class PerkLevel
    {
        public PerkLevel()
        {
            PerkLevelQuestRequirement = new HashSet<PerkLevelQuestRequirement>();
            PerkLevelSkillRequirement = new HashSet<PerkLevelSkillRequirement>();
        }

        public int ID { get; set; }
        public int PerkID { get; set; }
        public int Level { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public int SpecializationID { get; set; }

        public virtual Perk Perk { get; set; }
        public virtual Specialization Specialization { get; set; }
        public virtual ICollection<PerkLevelQuestRequirement> PerkLevelQuestRequirement { get; set; }
        public virtual ICollection<PerkLevelSkillRequirement> PerkLevelSkillRequirement { get; set; }
    }
}