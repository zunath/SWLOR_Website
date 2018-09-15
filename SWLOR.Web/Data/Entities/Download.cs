using System;
using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class Download
    {
        public int DownloadID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public bool IsActive { get; set; }
    }
}
