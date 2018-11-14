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
        public string ScriptHandler { get; set; }
        public string StartMessage { get; set; }
        public string ContinueMessage { get; set; }
        public string WornOffMessage { get; set; }
        public int CustomEffectCategoryID { get; set; }

        public CustomEffectCategory CustomEffectCategory { get; set; }
        public ICollection<PCCustomEffect> PCCustomEffect { get; set; }
    }
}
