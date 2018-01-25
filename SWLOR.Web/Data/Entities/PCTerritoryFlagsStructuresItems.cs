namespace SWLOR.Web.Data.Entities
{
    public partial class PCTerritoryFlagsStructuresItems
    {
        public long PcstructureItemId { get; set; }
        public long PcstructureId { get; set; }
        public string ItemName { get; set; }
        public string ItemTag { get; set; }
        public string ItemResref { get; set; }
        public byte[] ItemObject { get; set; }

        public PCTerritoryFlagsStructures Pcstructure { get; set; }
    }
}
