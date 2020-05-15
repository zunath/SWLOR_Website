﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities.Data.Entities
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

        public string ID { get; set; }
        public string PCBaseID { get; set; }
        public int BaseStructureID { get; set; }
        public double LocationX { get; set; }
        public double LocationY { get; set; }
        public double LocationZ { get; set; }
        public double LocationOrientation { get; set; }
        public double Durability { get; set; }
        public int? InteriorStyleID { get; set; }
        public int? ExteriorStyleID { get; set; }
        public string ParentPCBaseStructureID { get; set; }
        public string CustomName { get; set; }
        public int StructureBonus { get; set; }
        public DateTime? DateNextActivity { get; set; }
        public int StructureModeID { get; set; }
        public int ClusterID { get; set; }

        public virtual BaseStructure BaseStructure { get; set; }
        public virtual BuildingStyle ExteriorStyle { get; set; }
        public virtual BuildingStyle InteriorStyle { get; set; }
        public virtual PCBase PCBase { get; set; }
        public virtual PCBaseStructure ParentPCBaseStructure { get; set; }
        public virtual StructureMode StructureMode { get; set; }
        public virtual ICollection<PCBaseStructure> InverseParentPCBaseStructure { get; set; }
        public virtual ICollection<PCBaseStructureItem> PCBaseStructureItem { get; set; }
        public virtual ICollection<PCBaseStructurePermission> PCBaseStructurePermission { get; set; }
        public virtual ICollection<Player> Player { get; set; }
    }
}