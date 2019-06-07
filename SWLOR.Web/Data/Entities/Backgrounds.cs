using System;

namespace SWLOR.Web.Data.Entities
{
    public partial class Backgrounds
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Bonuses { get; set; }
        public bool IsActive { get; set; }
        public int ClusterID { get; set; }
    }
}