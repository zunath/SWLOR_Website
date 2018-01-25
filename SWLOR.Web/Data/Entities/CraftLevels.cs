namespace SWLOR.Web.Data.Entities
{
    public partial class CraftLevels
    {
        public int CraftLevelId { get; set; }
        public long CraftId { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }

        public Crafts Craft { get; set; }
    }
}
