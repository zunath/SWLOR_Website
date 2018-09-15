using System;
using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class EnmityAdjustmentRule
    {
        public EnmityAdjustmentRule()
        {
            Perks = new HashSet<Perk>();
        }

        public int EnmityAdjustmentRuleID { get; set; }
        public string Name { get; set; }

        public ICollection<Perk> Perks { get; set; }
    }
}
