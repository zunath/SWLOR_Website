using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SWLOR.Web.Models.UI.Skills
{
    public class SkillModel
    {
        public int SkillID { get; set; }
        public int SkillCategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int MaxRank { get; set; }
        public string PrimaryName { get; set; }
        public string SecondaryName { get; set; }
        public string TertiaryName { get; set; }
    }
}
