using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class DMActionType
    {
        public DMActionType()
        {
            DMAction = new HashSet<DMAction>();
        }

        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<DMAction> DMAction { get; set; }
    }
}