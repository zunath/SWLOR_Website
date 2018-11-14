using System;
using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class PCBase
    {
        public PCBase()
        {
            PCBasePermission = new HashSet<PCBasePermission>();
            PCBaseStructure = new HashSet<PCBaseStructure>();
            PlayerNavigation = new HashSet<Player>();
        }

        public Guid ID { get; set; }
        public Guid PlayerID { get; set; }
        public string AreaResref { get; set; }
        public string Sector { get; set; }
        public DateTime DateInitialPurchase { get; set; }
        public DateTime DateRentDue { get; set; }
        public int ShieldHP { get; set; }
        public bool IsInReinforcedMode { get; set; }
        public int Fuel { get; set; }
        public int ReinforcedFuel { get; set; }
        public DateTime DateFuelEnds { get; set; }
        public int PCBaseTypeID { get; set; }
        public int? ApartmentBuildingID { get; set; }
        public string CustomName { get; set; }
        public int? BuildingStyleID { get; set; }

        public ApartmentBuilding ApartmentBuilding { get; set; }
        public Area AreaResrefNavigation { get; set; }
        public BuildingStyle BuildingStyle { get; set; }
        public PCBaseType PCBaseType { get; set; }
        public Player Player { get; set; }
        public ICollection<PCBasePermission> PCBasePermission { get; set; }
        public ICollection<PCBaseStructure> PCBaseStructure { get; set; }
        public ICollection<Player> PlayerNavigation { get; set; }
    }
}
