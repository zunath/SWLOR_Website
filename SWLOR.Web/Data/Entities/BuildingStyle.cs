using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class BuildingStyle
    {
        public BuildingStyle()
        {
            PCBase = new HashSet<PCBase>();
            PCBaseStructureExteriorStyle = new HashSet<PCBaseStructure>();
            PCBaseStructureInteriorStyle = new HashSet<PCBaseStructure>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Resref { get; set; }
        public int? BaseStructureID { get; set; }
        public bool IsDefault { get; set; }
        public string DoorRule { get; set; }
        public bool IsActive { get; set; }
        public int BuildingTypeID { get; set; }
        public int PurchasePrice { get; set; }
        public int DailyUpkeep { get; set; }
        public int FurnitureLimit { get; set; }

        public BaseStructure BaseStructure { get; set; }
        public BuildingType BuildingType { get; set; }
        public ICollection<PCBase> PCBase { get; set; }
        public ICollection<PCBaseStructure> PCBaseStructureExteriorStyle { get; set; }
        public ICollection<PCBaseStructure> PCBaseStructureInteriorStyle { get; set; }
    }
}
