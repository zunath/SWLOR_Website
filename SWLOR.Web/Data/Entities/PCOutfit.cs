namespace SWLOR.Web.Data.Entities
{
    public partial class PCOutfit
    {
        public string PlayerID { get; set; }
        public string Outfit1 { get; set; }
        public string Outfit2 { get; set; }
        public string Outfit3 { get; set; }
        public string Outfit4 { get; set; }
        public string Outfit5 { get; set; }
        public string Outfit6 { get; set; }
        public string Outfit7 { get; set; }
        public string Outfit8 { get; set; }
        public string Outfit9 { get; set; }
        public string Outfit10 { get; set; }

        public PlayerCharacter Player { get; set; }
    }
}
