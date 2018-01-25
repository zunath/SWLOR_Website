using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class StorageContainers
    {
        public StorageContainers()
        {
            StorageItems = new HashSet<StorageItems>();
        }

        public int StorageContainerId { get; set; }
        public string AreaName { get; set; }
        public string AreaTag { get; set; }
        public string AreaResref { get; set; }

        public ICollection<StorageItems> StorageItems { get; set; }
    }
}
