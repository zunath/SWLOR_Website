namespace SWLOR.Web.Data.Entities
{
    public class KeyItem
    {
        public int KeyItemID { get; set; }
        public int KeyItemCategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public KeyItemCategory KeyItemCategory { get; set; }
    }
}
