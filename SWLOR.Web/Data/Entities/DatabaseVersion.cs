using System;

namespace SWLOR.Web.Data.Entities
{
    public partial class DatabaseVersion
    {
        public Guid ID { get; set; }
        public string ScriptName { get; set; }
        public DateTime DateApplied { get; set; }
        public DateTime VersionDate { get; set; }
        public int VersionNumber { get; set; }
    }
}
