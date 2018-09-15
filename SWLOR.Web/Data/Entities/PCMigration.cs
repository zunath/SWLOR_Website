using System;
using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class PCMigration
    {
        public PCMigration()
        {
            PCMigrationItems = new HashSet<PCMigrationItem>();
        }

        public int PCMigrationID { get; set; }
        public string Name { get; set; }

        public ICollection<PCMigrationItem> PCMigrationItems { get; set; }
    }
}
