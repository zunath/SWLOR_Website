using System;
using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class PCBaseStructure
    {
        public PCBaseStructure()
        {
            InverseParentPCBaseStructure = new HashSet<PCBaseStructure>();
            PCBaseStructureItem = new HashSet<PCBaseStructureItem>();
            PCBaseStructurePermission = new HashSet<PCBaseStructurePermission>();
            Player = new HashSet<Player>();
        }

        public Guid ID { get; set; }
        public Guid PCBaseID { get; set; }
        public int BaseStructureID { get; set; }
        public double LocationX { get; set; }
        public double LocationY { get; set; }
        public double LocationZ { get; set; }
        public double LocationOrientation { get; set; }
        public double Durability { get; set; }
        public int? InteriorStyleID { get; set; }
        public int? ExteriorStyleID { get; set; }
        public Guid? ParentPCBaseStructureID { get; set; }
        public string CustomName { get; set; }
        public int StructureBonus { get; set; }
        public DateTime? DateNextActivity { get; set; }

        public BaseStructure BaseStructure { get; set; }
        public BuildingStyle ExteriorStyle { get; set; }
        public BuildingStyle InteriorStyle { get; set; }
        public PCBase PCBase { get; set; }
        public PCBaseStructure ParentPCBaseStructure { get; set; }
        public ICollection<PCBaseStructure> InverseParentPCBaseStructure { get; set; }
        public ICollection<PCBaseStructureItem> PCBaseStructureItem { get; set; }
        public ICollection<PCBaseStructurePermission> PCBaseStructurePermission { get; set; }
        public ICollection<Player> Player { get; set; }
    }
}
