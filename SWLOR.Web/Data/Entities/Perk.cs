using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class Perk
    {
        public Perk()
        {
            CraftBlueprint = new HashSet<CraftBlueprint>();
            PCPerk = new HashSet<PCPerk>();
            PCPerkRefund = new HashSet<PCPerkRefund>();
            PerkFeat = new HashSet<PerkFeat>();
            PerkLevel = new HashSet<PerkLevel>();
            Player = new HashSet<Player>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public double BaseCastingTime { get; set; }
        public string Description { get; set; }
        public int PerkCategoryID { get; set; }
        public int? CooldownCategoryID { get; set; }
        public int ExecutionTypeID { get; set; }
        public bool IsTargetSelfOnly { get; set; }
        public int Enmity { get; set; }
        public int EnmityAdjustmentRuleID { get; set; }
        public int? CastAnimationID { get; set; }
        public int SpecializationID { get; set; }
        public int ForceBalanceTypeID { get; set; }

        public virtual CooldownCategory CooldownCategory { get; set; }
        public virtual EnmityAdjustmentRule EnmityAdjustmentRule { get; set; }
        public virtual PerkExecutionType ExecutionType { get; set; }
        public virtual ForceBalanceType ForceBalanceType { get; set; }
        public virtual PerkCategory PerkCategory { get; set; }
        public virtual Specialization Specialization { get; set; }
        public virtual ICollection<CraftBlueprint> CraftBlueprint { get; set; }
        public virtual ICollection<PCPerk> PCPerk { get; set; }
        public virtual ICollection<PCPerkRefund> PCPerkRefund { get; set; }
        public virtual ICollection<PerkFeat> PerkFeat { get; set; }
        public virtual ICollection<PerkLevel> PerkLevel { get; set; }
        public virtual ICollection<Player> Player { get; set; }
    }
}