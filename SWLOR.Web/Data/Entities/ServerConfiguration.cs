namespace SWLOR.Web.Data.Entities
{
    public partial class ServerConfiguration
    {
        public int ID { get; set; }
        public string ServerName { get; set; }
        public string MessageOfTheDay { get; set; }
        public int AreaBakeStep { get; set; }
    }
}
