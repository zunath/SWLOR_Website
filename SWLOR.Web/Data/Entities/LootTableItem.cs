namespace SWLOR.Web.Data.Entities
{
    public partial class LootTableItem
    {
        public int LootTableItemID { get; set; }
        public int LootTableID { get; set; }
        public string Resref { get; set; }
        public int MaxQuantity { get; set; }
        public byte Weight { get; set; }
        public bool IsActive { get; set; }

        public LootTable LootTable { get; set; }
    }
}
