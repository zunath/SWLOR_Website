using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class CustomEffect
    {
        public CustomEffect()
        {
            PCCustomEffect = new HashSet<PCCustomEffect>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public int IconID { get; set; }
        public int CustomEffectCategoryID { get; set; }

        public virtual CustomEffectCategory CustomEffectCategory { get; set; }
        public virtual ICollection<PCCustomEffect> PCCustomEffect { get; set; }
    }
}