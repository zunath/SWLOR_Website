﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities.Data.Entities
{
    public partial class PerkExecutionType
    {
        public PerkExecutionType()
        {
            Perk = new HashSet<Perk>();
        }

        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Perk> Perk { get; set; }
    }
}