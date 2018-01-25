using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class ProfessionsDomain
    {
        public ProfessionsDomain()
        {
            PlayerCharacters = new HashSet<PlayerCharacters>();
        }

        public int ProfessionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Bonuses { get; set; }
        public bool IsActive { get; set; }

        public ICollection<PlayerCharacters> PlayerCharacters { get; set; }
    }
}
