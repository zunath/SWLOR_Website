using System;

namespace SWLOR.Web.Data.Entities
{
    public partial class PCLearnedAbilities
    {
        public int PclearnedAbilityId { get; set; }
        public string PlayerId { get; set; }
        public DateTime AcquiredDate { get; set; }
        public int AbilityId { get; set; }

        public Abilities Ability { get; set; }
        public PlayerCharacters Player { get; set; }
    }
}
