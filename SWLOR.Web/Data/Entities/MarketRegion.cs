using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class MarketRegion
    {
        public MarketRegion()
        {
            PCMarketListing = new HashSet<PCMarketListing>();
        }

        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<PCMarketListing> PCMarketListing { get; set; }
    }
}