namespace SWLOR.Web.Data.Entities
{
    public partial class StorageItems
    {
        public int StorageItemId { get; set; }
        public int StorageContainerId { get; set; }
        public string ItemName { get; set; }
        public string ItemTag { get; set; }
        public string ItemResref { get; set; }
        public byte[] ItemObject { get; set; }

        public StorageContainers StorageContainer { get; set; }
    }
}
