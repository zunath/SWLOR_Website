﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities.Data.Entities
{
    public partial class PCMapProgression
    {
        public string ID { get; set; }
        public string PlayerID { get; set; }
        public string AreaResref { get; set; }
        public string Progression { get; set; }
        public int ClusterID { get; set; }

        public virtual Player Player { get; set; }
    }
}