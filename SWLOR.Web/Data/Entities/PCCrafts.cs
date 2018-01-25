namespace SWLOR.Web.Data.Entities
{
    public partial class PCCrafts
    {
        public long PccraftId { get; set; }
        public string PlayerId { get; set; }
        public long CraftId { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }

        public Crafts Craft { get; set; }
        public PlayerCharacters Player { get; set; }
    }
}
