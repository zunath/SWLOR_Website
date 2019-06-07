using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class CraftDevice
    {
        public CraftDevice()
        {
            CraftBlueprint = new HashSet<CraftBlueprint>();
        }

        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CraftBlueprint> CraftBlueprint { get; set; }
    }
}