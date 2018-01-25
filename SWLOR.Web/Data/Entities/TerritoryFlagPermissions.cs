using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class TerritoryFlagPermissions
    {
        public TerritoryFlagPermissions()
        {
            PcterritoryFlagsPermissions = new HashSet<PCTerritoryFlagsPermissions>();
        }

        public int TerritoryFlagPermissionId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public bool IsSelectable { get; set; }

        public ICollection<PCTerritoryFlagsPermissions> PcterritoryFlagsPermissions { get; set; }
    }
}
