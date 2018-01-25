namespace SWLOR.Web.Data.Entities
{
    public partial class LootTableItems
    {
        public int LootTableItemId { get; set; }
        public int LootTableId { get; set; }
        public string Resref { get; set; }
        public int MaxQuantity { get; set; }
        public byte Weight { get; set; }
        public bool IsActive { get; set; }

        public LootTables LootTable { get; set; }
    }
}
