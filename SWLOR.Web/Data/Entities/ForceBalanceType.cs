﻿using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class ForceBalanceType
    {
        public ForceBalanceType()
        {
            Perk = new HashSet<Perk>();
        }

        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Perk> Perk { get; set; }
    }
}