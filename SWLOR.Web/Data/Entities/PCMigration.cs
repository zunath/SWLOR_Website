using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public class PCMigration
    {
        public PCMigration()
        {
            PcmigrationItems = new HashSet<PCMigrationItem>();
        }

        public int PCMigrationID { get; set; }
        public string Name { get; set; }

        public ICollection<PCMigrationItem> PcmigrationItems { get; set; }
    }
}
