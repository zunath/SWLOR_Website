using System.ComponentModel.DataAnnotations.Schema;

namespace SWLOR.Web.Data.Entities
{
    public class Skill
    { 
        public int SkillID { get; set; }
        public int SkillCategoryID { get; set; }
        public string Name { get; set; }
        public int MaxRank { get; set; }
        public bool IsActive { get; set; }
        public string Description { get; set; }
        public int PrimaryID { get; set; }
        public int SecondaryID { get; set; }
        public int TertiaryID { get; set; }


        [ForeignKey("PrimaryID")]
        public Attribute Primary { get; set; }

        [ForeignKey("SecondaryID")]
        public Attribute Secondary { get; set; }
        public SkillCategory SkillCategory { get; set; }

        [ForeignKey("TertiaryID")]
        public Attribute Tertiary { get; set; }
    }
}
