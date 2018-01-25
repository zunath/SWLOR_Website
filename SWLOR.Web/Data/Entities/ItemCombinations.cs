namespace SWLOR.Web.Data.Entities
{
    public partial class ItemCombinations
    {
        public int ItemCombinationId { get; set; }
        public string ItemA { get; set; }
        public string ItemB { get; set; }
        public bool ItemAinfinite { get; set; }
        public bool ItemBinfinite { get; set; }
        public string Output { get; set; }
        public string Quantity { get; set; }
        public string Hqoutput { get; set; }
        public int? Hqquantity { get; set; }
        public int? MixingRequired { get; set; }
        public bool? IgnoreOrder { get; set; }
    }
}
