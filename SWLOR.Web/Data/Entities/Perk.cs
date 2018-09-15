using System;
using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class Perk
    {
        public Perk()
        {
            CraftBlueprints = new HashSet<CraftBlueprint>();
            PCPerks = new HashSet<PCPerk>();
            PerkLevels = new HashSet<PerkLevel>();
        }

        public int PerkID { get; set; }
        public string Name { get; set; }
        public int? FeatID { get; set; }
        public bool IsActive { get; set; }
        public string JavaScriptName { get; set; }
        public int BaseFPCost { get; set; }
        public double BaseCastingTime { get; set; }
        public string Description { get; set; }
        public int PerkCategoryID { get; set; }
        public int? CooldownCategoryID { get; set; }
        public int ExecutionTypeID { get; set; }
        public string ItemResref { get; set; }
        public bool IsTargetSelfOnly { get; set; }
        public int Enmity { get; set; }
        public int EnmityAdjustmentRuleID { get; set; }

        public CooldownCategory CooldownCategory { get; set; }
        public EnmityAdjustmentRule EnmityAdjustmentRule { get; set; }
        public PerkExecutionType ExecutionType { get; set; }
        public PerkCategory PerkCategory { get; set; }
        public ICollection<CraftBlueprint> CraftBlueprints { get; set; }
        public ICollection<PCPerk> PCPerks { get; set; }
        public ICollection<PerkLevel> PerkLevels { get; set; }
    }
}
