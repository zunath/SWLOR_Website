using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class BaseItemTypes
    {
        public BaseItemTypes()
        {
            PcmigrationItems = new HashSet<PCMigrationItems>();
        }

        public int BaseItemTypeId { get; set; }
        public string Name { get; set; }

        public ICollection<PCMigrationItems> PcmigrationItems { get; set; }
    }
}
