﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities.Data.Entities
{
    public partial class PCImpoundedItem
    {
        public string ID { get; set; }
        public string PlayerID { get; set; }
        public string ItemName { get; set; }
        public string ItemTag { get; set; }
        public string ItemResref { get; set; }
        public string ItemObject { get; set; }
        public DateTime DateImpounded { get; set; }
        public DateTime? DateRetrieved { get; set; }
        public int ClusterID { get; set; }

        public virtual Player Player { get; set; }
    }
}