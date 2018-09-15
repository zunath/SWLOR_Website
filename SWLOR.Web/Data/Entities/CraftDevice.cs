using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class CraftDevice
    {
        public CraftDevice()
        {
            CraftBlueprints = new HashSet<CraftBlueprint>();
        }

        public int CraftDeviceID { get; set; }
        public string Name { get; set; }

        public ICollection<CraftBlueprint> CraftBlueprints { get; set; }
    }
}
