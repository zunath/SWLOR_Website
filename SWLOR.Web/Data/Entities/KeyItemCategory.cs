﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities.Data.Entities
{
    public partial class KeyItemCategory
    {
        public KeyItemCategory()
        {
            KeyItem = new HashSet<KeyItem>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        public virtual ICollection<KeyItem> KeyItem { get; set; }
    }
}