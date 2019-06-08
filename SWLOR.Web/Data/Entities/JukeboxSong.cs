namespace SWLOR.Web.Data.Entities
{
    public partial class JukeboxSong
    {
        public int ID { get; set; }
        public int AmbientMusicID { get; set; }
        public string FileName { get; set; }
        public string DisplayName { get; set; }
        public bool IsActive { get; set; }
    }
}