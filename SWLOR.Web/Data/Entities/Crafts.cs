using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class Crafts
    {
        public Crafts()
        {
            CraftBlueprints = new HashSet<CraftBlueprints>();
            CraftLevels = new HashSet<CraftLevels>();
            Pccrafts = new HashSet<PCCrafts>();
        }

        public long CraftId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public string Description { get; set; }

        public ICollection<CraftBlueprints> CraftBlueprints { get; set; }
        public ICollection<CraftLevels> CraftLevels { get; set; }
        public ICollection<PCCrafts> Pccrafts { get; set; }
    }
}
