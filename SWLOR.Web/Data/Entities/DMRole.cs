using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class DMRole
    {
        public DMRole()
        {
            User = new HashSet<User>();
        }

        public int ID { get; set; }
        public string Description { get; set; }

        public virtual ICollection<User> User { get; set; }
    }
}