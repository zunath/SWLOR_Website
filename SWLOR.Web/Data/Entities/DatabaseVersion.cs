﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities.Data.Entities
{
    public partial class DatabaseVersion
    {
        public string ID { get; set; }
        public string ScriptName { get; set; }
        public DateTime DateApplied { get; set; }
        public DateTime VersionDate { get; set; }
        public int VersionNumber { get; set; }
        public int ClusterID { get; set; }
    }
}