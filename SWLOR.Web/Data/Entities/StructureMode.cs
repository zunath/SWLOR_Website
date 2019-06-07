﻿using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class StructureMode
    {
        public StructureMode()
        {
            BaseStructure = new HashSet<BaseStructure>();
            PCBaseStructure = new HashSet<PCBaseStructure>();
        }

        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<BaseStructure> BaseStructure { get; set; }
        public virtual ICollection<PCBaseStructure> PCBaseStructure { get; set; }
    }
}