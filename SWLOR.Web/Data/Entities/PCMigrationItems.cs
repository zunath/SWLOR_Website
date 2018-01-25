namespace SWLOR.Web.Data.Entities
{
    public partial class PCMigrationItems
    {
        public int PcmigrationItemId { get; set; }
        public int PcmigrationId { get; set; }
        public string CurrentResref { get; set; }
        public string NewResref { get; set; }
        public bool StripItemProperties { get; set; }
        public int BaseItemTypeId { get; set; }

        public BaseItemTypes BaseItemType { get; set; }
        public PCMigrations PcMigration { get; set; }
    }
}
