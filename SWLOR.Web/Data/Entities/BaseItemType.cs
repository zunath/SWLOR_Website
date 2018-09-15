using System;
using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class BaseItemType
    {
        public BaseItemType()
        {
            PCMigrationItems = new HashSet<PCMigrationItem>();
        }

        public int BaseItemTypeID { get; set; }
        public string Name { get; set; }

        public ICollection<PCMigrationItem> PCMigrationItems { get; set; }
    }
}
