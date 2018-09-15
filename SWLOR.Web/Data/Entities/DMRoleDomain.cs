using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class DMRoleDomain
    {
        public DMRoleDomain()
        {
            Users = new HashSet<User>();
        }

        public int DMRoleDomainID { get; set; }
        public string Description { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
