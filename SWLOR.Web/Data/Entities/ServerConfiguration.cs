namespace SWLOR.Web.Data.Entities
{
    public partial class ServerConfiguration
    {
        public int ServerConfigurationId { get; set; }
        public int MaxLevel { get; set; }
        public int MaxExpAcquirable { get; set; }
        public double MaxExpGainDistance { get; set; }
        public string ServerName { get; set; }
        public string MessageOfTheDay { get; set; }
    }
}
