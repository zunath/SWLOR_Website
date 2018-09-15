using System.Collections.Generic;

namespace SWLOR.Web.Models.UI.Perks
{
    public class PerkUI
    {
        public int PerkID { get; set; }
        public int PerkCategoryID { get; set; }
        public string Name { get; set; }
        public string ExecutionTypeName { get; set; }
        public string Description { get; set; }
        public int BaseFPCost { get; set; }
        public float BaseActivationTime { get; set; }
        public float BaseCooldownTime { get; set; }

        public IEnumerable<PerkLevelUI> PerkLevels { get; set; }

        public PerkUI()
        {
            PerkLevels = new List<PerkLevelUI>();
        }
    }
}
