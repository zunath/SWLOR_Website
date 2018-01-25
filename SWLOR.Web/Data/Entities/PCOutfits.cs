namespace SWLOR.Web.Data.Entities
{
    public partial class PCOutfits
    {
        public string PlayerId { get; set; }
        public byte[] Outfit1 { get; set; }
        public byte[] Outfit2 { get; set; }
        public byte[] Outfit3 { get; set; }
        public byte[] Outfit4 { get; set; }
        public byte[] Outfit5 { get; set; }
        public byte[] Outfit6 { get; set; }
        public byte[] Outfit7 { get; set; }
        public byte[] Outfit8 { get; set; }
        public byte[] Outfit9 { get; set; }
        public byte[] Outfit10 { get; set; }

        public PlayerCharacters Player { get; set; }
    }
}
