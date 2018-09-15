using System;
using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class PCCustomEffect
    {
        public long PCCustomEffectID { get; set; }
        public string PlayerID { get; set; }
        public long CustomEffectID { get; set; }
        public int Ticks { get; set; }
        public int EffectiveLevel { get; set; }
        public string Data { get; set; }
        public string CasterNWNObjectID { get; set; }

        public CustomEffect CustomEffect { get; set; }
        public PlayerCharacter Player { get; set; }
    }
}
