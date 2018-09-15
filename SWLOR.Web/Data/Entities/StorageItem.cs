using System;
using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class StorageItem
    {
        public int StorageItemID { get; set; }
        public int StorageContainerID { get; set; }
        public string ItemName { get; set; }
        public string ItemTag { get; set; }
        public string ItemResref { get; set; }
        public string ItemObject { get; set; }
        public string GlobalID { get; set; }

        public StorageContainer StorageContainer { get; set; }
    }
}
