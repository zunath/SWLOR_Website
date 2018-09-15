namespace SWLOR.Web.Data.Entities
{
    public partial class Mod
    {
        public int ModID { get; set; }
        public string Name { get; set; }
        public string Script { get; set; }
        public bool IsActive { get; set; }
    }
}
