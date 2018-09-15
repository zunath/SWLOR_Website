namespace SWLOR.Web.Data.Entities
{
    public class PCTerritoryFlagsStructuresItem
    {
        public long PCStructureItemID { get; set; }
        public long PCStructureID { get; set; }
        public string ItemName { get; set; }
        public string ItemTag { get; set; }
        public string ItemResref { get; set; }
        public byte[] ItemObject { get; set; }

        public PCTerritoryFlagsStructure PCStructure { get; set; }
    }
}
