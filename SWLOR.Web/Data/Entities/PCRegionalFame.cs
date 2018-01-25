namespace SWLOR.Web.Data.Entities
{
    public partial class PCRegionalFame
    {
        public int PcregionalFameId { get; set; }
        public string PlayerId { get; set; }
        public int FameRegionId { get; set; }
        public int Amount { get; set; }

        public FameRegions FameRegion { get; set; }
        public PlayerCharacters Player { get; set; }
    }
}
