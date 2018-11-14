using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class Association
    {
        public Association()
        {
            Player = new HashSet<Player>();
        }

        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<Player> Player { get; set; }
    }
}
