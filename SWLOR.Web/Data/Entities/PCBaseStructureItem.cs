namespace SWLOR.Web.Data.Entities
{
    public partial class PCBaseStructureItem
    {
        public int PCBaseStructureItemID { get; set; }
        public int PCBaseStructureID { get; set; }
        public string ItemGlobalID { get; set; }
        public string ItemName { get; set; }
        public string ItemTag { get; set; }
        public string ItemResref { get; set; }
        public string ItemObject { get; set; }

        public PCBaseStructure PCBaseStructure { get; set; }
    }
}
