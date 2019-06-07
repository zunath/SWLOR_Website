using System;

namespace SWLOR.Web.Data.Entities
{
    public partial class PCSkillPool
    {
        public Guid ID { get; set; }
        public Guid PlayerID { get; set; }
        public int SkillCategoryID { get; set; }
        public int Levels { get; set; }
        public int ClusterID { get; set; }

        public virtual Player Player { get; set; }
        public virtual SkillCategory SkillCategory { get; set; }
    }
}