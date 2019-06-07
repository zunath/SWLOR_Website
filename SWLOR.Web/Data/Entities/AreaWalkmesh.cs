using System;

namespace SWLOR.Web.Data.Entities
{
    public partial class AreaWalkmesh
    {
        public Guid ID { get; set; }
        public Guid AreaID { get; set; }
        public double? LocationX { get; set; }
        public double? LocationY { get; set; }
        public double LocationZ { get; set; }
        public int ClusterID { get; set; }

        public virtual Area Area { get; set; }
    }
}