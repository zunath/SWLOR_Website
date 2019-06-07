using System;

namespace SWLOR.Web.Data.Entities
{
    public partial class DMAction
    {
        public Guid ID { get; set; }
        public int DMActionTypeID { get; set; }
        public string Name { get; set; }
        public string CDKey { get; set; }
        public DateTime DateOfAction { get; set; }
        public string Details { get; set; }
        public int ClusterID { get; set; }

        public virtual DMActionType DMActionType { get; set; }
    }
}