using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class MarketCategory
    {
        public MarketCategory()
        {
            PCMarketListing = new HashSet<PCMarketListing>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<PCMarketListing> PCMarketListing { get; set; }
    }
}