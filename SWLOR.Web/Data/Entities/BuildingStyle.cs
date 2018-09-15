using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class BuildingStyle
    {
        public BuildingStyle()
        {
            PCBaseStructuresExteriorStyle = new HashSet<PCBaseStructure>();
            PCBaseStructuresInteriorStyle = new HashSet<PCBaseStructure>();
        }

        public int BuildingStyleID { get; set; }
        public string Name { get; set; }
        public string Resref { get; set; }
        public bool IsInterior { get; set; }
        public int BaseStructureID { get; set; }
        public bool IsDefault { get; set; }
        public int DoorSpawnProcedure { get; set; }

        public BaseStructure BaseStructure { get; set; }
        public ICollection<PCBaseStructure> PCBaseStructuresExteriorStyle { get; set; }
        public ICollection<PCBaseStructure> PCBaseStructuresInteriorStyle { get; set; }
    }
}
