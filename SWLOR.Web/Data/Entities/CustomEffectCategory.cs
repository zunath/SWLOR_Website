using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class CustomEffectCategory
    {
        public CustomEffectCategory()
        {
            CustomEffect = new HashSet<CustomEffect>();
        }

        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<CustomEffect> CustomEffect { get; set; }
    }
}