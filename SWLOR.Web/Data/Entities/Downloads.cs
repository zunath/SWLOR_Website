namespace SWLOR.Web.Data.Entities
{
    public partial class Downloads
    {
        public int DownloadId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public bool IsActive { get; set; }
    }
}
