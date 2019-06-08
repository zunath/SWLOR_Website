using System;

namespace SWLOR.Web.Data.Entities
{
    public partial class PCMapPin
    {
        public Guid ID { get; set; }
        public Guid PlayerID { get; set; }
        public string AreaTag { get; set; }
        public double PositionX { get; set; }
        public double PositionY { get; set; }
        public string NoteText { get; set; }
        public int ClusterID { get; set; }

        public virtual Player Player { get; set; }
    }
}