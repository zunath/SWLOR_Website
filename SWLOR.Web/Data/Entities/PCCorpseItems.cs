namespace SWLOR.Web.Data.Entities
{
    public partial class PCCorpseItems
    {
        public long PccorpseItemId { get; set; }
        public long PccorpseId { get; set; }
        public byte[] NwitemObject { get; set; }

        public PCCorpses PcCorpse { get; set; }
    }
}
