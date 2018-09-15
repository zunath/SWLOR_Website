namespace SWLOR.Web.Data.Entities
{
    public class PCOverflowItem
    {
        public long PCOverflowItemID { get; set; }
        public string PlayerID { get; set; }
        public string ItemName { get; set; }
        public string ItemTag { get; set; }
        public string ItemResref { get; set; }
        public byte[] ItemObject { get; set; }

        public PlayerCharacter Player { get; set; }
    }
}
