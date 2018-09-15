using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public class PCCorpse
    {
        public PCCorpse()
        {
            PCCorpseItems = new HashSet<PCCorpseItem>();
        }

        public long PCCorpseID { get; set; }
        public string Name { get; set; }
        public double PositionX { get; set; }
        public double PositionY { get; set; }
        public double PositionZ { get; set; }
        public double Orientation { get; set; }
        public string AreaTag { get; set; }

        public ICollection<PCCorpseItem> PCCorpseItems { get; set; }
    }
}
