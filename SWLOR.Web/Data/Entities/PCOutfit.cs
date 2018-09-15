namespace SWLOR.Web.Data.Entities
{
    public class PCOutfit
    {
        public string PlayerID { get; set; }
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

        public PlayerCharacter Player { get; set; }
    }
}
