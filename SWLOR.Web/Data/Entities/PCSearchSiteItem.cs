namespace SWLOR.Web.Data.Entities
{
    public class PCSearchSiteItem
    {
        public long PCSearchSiteItemID { get; set; }
        public string PlayerID { get; set; }
        public int SearchSiteID { get; set; }
        public byte[] SearchItem { get; set; }

        public PlayerCharacter Player { get; set; }
    }
}
