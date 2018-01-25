namespace SWLOR.Web.Data.Entities
{
    public partial class SpawnTableCreatures
    {
        public int SpawnTableCreatureId { get; set; }
        public int SpawnTableId { get; set; }
        public string Resref { get; set; }
        public bool IsActive { get; set; }
        public byte Weight { get; set; }
        public int MaxNumberInArea { get; set; }
        public int? LootTableId { get; set; }
        public int DifficultyRating { get; set; }

        public LootTables LootTable { get; set; }
        public SpawnTables SpawnTable { get; set; }
    }
}
