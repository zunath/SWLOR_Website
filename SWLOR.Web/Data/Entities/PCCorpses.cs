using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class PCCorpses
    {
        public PCCorpses()
        {
            PccorpseItems = new HashSet<PCCorpseItems>();
        }

        public long PccorpseId { get; set; }
        public string Name { get; set; }
        public double PositionX { get; set; }
        public double PositionY { get; set; }
        public double PositionZ { get; set; }
        public double Orientation { get; set; }
        public string AreaTag { get; set; }

        public ICollection<PCCorpseItems> PccorpseItems { get; set; }
    }
}
