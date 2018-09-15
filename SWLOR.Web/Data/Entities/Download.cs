namespace SWLOR.Web.Data.Entities
{
    public class Download
    {
        public int DownloadID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
        public bool IsActive { get; set; }
    }
}
