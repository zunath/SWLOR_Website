using System;
using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class PCBase
    {
        public PCBase()
        {
            PCBasePermissions = new HashSet<PCBasePermission>();
            PCBaseStructures = new HashSet<PCBaseStructure>();
        }

        public int PCBaseID { get; set; }
        public string PlayerID { get; set; }
        public string AreaResref { get; set; }
        public string Sector { get; set; }
        public DateTime DateInitialPurchase { get; set; }
        public DateTime DateRentDue { get; set; }
        public int ShieldHP { get; set; }
        public bool IsInReinforcedMode { get; set; }
        public int Fuel { get; set; }
        public int ReinforcedFuel { get; set; }
        public DateTime DateFuelEnds { get; set; }

        public Area AreaResrefNavigation { get; set; }
        public PlayerCharacter Player { get; set; }
        public ICollection<PCBasePermission> PCBasePermissions { get; set; }
        public ICollection<PCBaseStructure> PCBaseStructures { get; set; }
    }
}
