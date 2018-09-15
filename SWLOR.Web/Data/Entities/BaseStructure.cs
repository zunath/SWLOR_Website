using System;
using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class BaseStructure
    {
        public BaseStructure()
        {
            BuildingStyles = new HashSet<BuildingStyle>();
            CraftBlueprints = new HashSet<CraftBlueprint>();
            PCBaseStructures = new HashSet<PCBaseStructure>();
        }

        public int BaseStructureID { get; set; }
        public int BaseStructureTypeID { get; set; }
        public string Name { get; set; }
        public string PlaceableResref { get; set; }
        public string ItemResref { get; set; }
        public bool IsActive { get; set; }
        public double Power { get; set; }
        public double CPU { get; set; }
        public double Durability { get; set; }
        public int Storage { get; set; }
        public bool HasAtmosphere { get; set; }
        public int ReinforcedStorage { get; set; }
        public bool RequiresBasePower { get; set; }

        public BaseStructureType BaseStructureType { get; set; }
        public ICollection<BuildingStyle> BuildingStyles { get; set; }
        public ICollection<CraftBlueprint> CraftBlueprints { get; set; }
        public ICollection<PCBaseStructure> PCBaseStructures { get; set; }
    }
}
