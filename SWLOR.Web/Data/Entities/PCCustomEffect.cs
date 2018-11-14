using System;

namespace SWLOR.Web.Data.Entities
{
    public partial class PCCustomEffect
    {
        public Guid ID { get; set; }
        public Guid PlayerID { get; set; }
        public int CustomEffectID { get; set; }
        public int Ticks { get; set; }
        public int EffectiveLevel { get; set; }
        public string Data { get; set; }
        public string CasterNWNObjectID { get; set; }
        public int? StancePerkID { get; set; }

        public CustomEffect CustomEffect { get; set; }
        public Player Player { get; set; }
    }
}
