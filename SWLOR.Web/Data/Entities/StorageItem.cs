namespace SWLOR.Web.Data.Entities
{
    public class StorageItem
    {
        public int StorageItemID { get; set; }
        public int StorageContainerID { get; set; }
        public string ItemName { get; set; }
        public string ItemTag { get; set; }
        public string ItemResref { get; set; }
        public byte[] ItemObject { get; set; }

        public StorageContainer StorageContainer { get; set; }
    }
}
