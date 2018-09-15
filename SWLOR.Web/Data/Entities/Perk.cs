using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public class Perk
    {
        public Perk()
        {
            PerkLevels = new HashSet<PerkLevel>();
        }

        public int PerkID { get; set; }
        public string Name { get; set; }
        public int? FeatID { get; set; }
        public bool IsActive { get; set; }
        public string JavaScriptName { get; set; }
        public int BaseManaCost { get; set; }
        public double BaseCastingTime { get; set; }
        public string Description { get; set; }
        public int PerkCategoryID { get; set; }
        public int? CooldownCategoryID { get; set; }
        public int ExecutionTypeID { get; set; }
        public string ItemResref { get; set; }
        public bool IsTargetSelfOnly { get; set; }

        public CooldownCategory CooldownCategory { get; set; }
        public PerkExecutionType ExecutionType { get; set; }
        public PerkCategory PerkCategory { get; set; }
        public ICollection<PerkLevel> PerkLevels { get; set; }
    }
}
