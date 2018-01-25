using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class CustomEffects
    {
        public CustomEffects()
        {
            PccustomEffects = new HashSet<PCCustomEffects>();
        }

        public long CustomEffectId { get; set; }
        public string Name { get; set; }
        public int IconId { get; set; }
        public string ScriptHandler { get; set; }
        public string StartMessage { get; set; }
        public string ContinueMessage { get; set; }
        public string WornOffMessage { get; set; }

        public ICollection<PCCustomEffects> PccustomEffects { get; set; }
    }
}
