using System;

namespace SWLOR.Web.Data.Entities
{
    public partial class PCObjectVisibility
    {
        public Guid ID { get; set; }
        public Guid PlayerID { get; set; }
        public string VisibilityObjectID { get; set; }
        public bool IsVisible { get; set; }
        public int ClusterID { get; set; }

        public virtual Player Player { get; set; }
    }
}