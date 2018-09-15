namespace SWLOR.Web.Data.Entities
{
    public class PCCorpseItem
    {
        public long PCCorpseItemID { get; set; }
        public long PCCorpseID { get; set; }
        public byte[] NWItemObject { get; set; }

        public PCCorpse PCCorpse { get; set; }
    }
}
