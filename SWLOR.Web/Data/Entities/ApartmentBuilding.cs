using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class ApartmentBuilding
    {
        public ApartmentBuilding()
        {
            PCBase = new HashSet<PCBase>();
        }

        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<PCBase> PCBase { get; set; }
    }
}