namespace SWLOR.Web.Data.Entities
{
    public partial class PCMigrationItem
    {
        public int PCMigrationItemID { get; set; }
        public int PCMigrationID { get; set; }
        public string CurrentResref { get; set; }
        public string NewResref { get; set; }
        public bool StripItemProperties { get; set; }
        public int BaseItemTypeID { get; set; }

        public BaseItemType BaseItemType { get; set; }
        public PCMigration PCMigration { get; set; }
    }
}
