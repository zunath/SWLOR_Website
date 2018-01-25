using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class BuildPrivacyDomain
    {
        public BuildPrivacyDomain()
        {
            PcterritoryFlags = new HashSet<PCTerritoryFlags>();
        }

        public int BuildPrivacyTypeId { get; set; }
        public string Name { get; set; }

        public ICollection<PCTerritoryFlags> PcterritoryFlags { get; set; }
    }
}
