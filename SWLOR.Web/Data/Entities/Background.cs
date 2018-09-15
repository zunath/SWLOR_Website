using System;
using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class Background
    {
        public int BackgroundID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Bonuses { get; set; }
        public bool IsActive { get; set; }
    }
}
