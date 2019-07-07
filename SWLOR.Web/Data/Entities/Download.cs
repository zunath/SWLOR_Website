namespace SWLOR.Web.Data.Entities
{
    public partial class Download
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public string LocalPath { get; set; }
        public string FileName { get; set; }
        public string ContentType { get; set; }
        public string Instructions { get; set; }
    }
}