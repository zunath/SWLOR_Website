using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class PCMigrations
    {
        public PCMigrations()
        {
            PcmigrationItems = new HashSet<PCMigrationItems>();
        }

        public int PcmigrationId { get; set; }
        public string Name { get; set; }

        public ICollection<PCMigrationItems> PcmigrationItems { get; set; }
    }
}
