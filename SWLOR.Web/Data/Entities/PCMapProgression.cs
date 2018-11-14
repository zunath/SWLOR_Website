﻿using System;

namespace SWLOR.Web.Data.Entities
{
    public partial class PCMapProgression
    {
        public Guid ID { get; set; }
        public Guid PlayerID { get; set; }
        public string AreaResref { get; set; }
        public string Progression { get; set; }

        public Player Player { get; set; }
    }
}