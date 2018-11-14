using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class PCBaseType
    {
        public PCBaseType()
        {
            PCBase = new HashSet<PCBase>();
        }

        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<PCBase> PCBase { get; set; }
    }
}
