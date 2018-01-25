using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class DmroleDomain
    {
        public DmroleDomain()
        {
            Users = new HashSet<Users>();
        }

        public int DmroleDomainId { get; set; }
        public string Description { get; set; }

        public ICollection<Users> Users { get; set; }
    }
}
