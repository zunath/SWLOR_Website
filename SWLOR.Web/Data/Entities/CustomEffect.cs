using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class CustomEffect
    {
        public CustomEffect()
        {
            PCCustomEffects = new HashSet<PCCustomEffect>();
        }

        public long CustomEffectID { get; set; }
        public string Name { get; set; }
        public int IconID { get; set; }
        public string ScriptHandler { get; set; }
        public string StartMessage { get; set; }
        public string ContinueMessage { get; set; }
        public string WornOffMessage { get; set; }

        public ICollection<PCCustomEffect> PCCustomEffects { get; set; }
    }
}
