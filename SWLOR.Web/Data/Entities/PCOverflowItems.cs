namespace SWLOR.Web.Data.Entities
{
    public partial class PCOverflowItems
    {
        public long PcoverflowItemId { get; set; }
        public string PlayerId { get; set; }
        public string ItemName { get; set; }
        public string ItemTag { get; set; }
        public string ItemResref { get; set; }
        public byte[] ItemObject { get; set; }

        public PlayerCharacters Player { get; set; }
    }
}
