using System;

namespace SWLOR.Web.Data.Entities
{
    public partial class PCQuestItemProgress
    {
        public Guid ID { get; set; }
        public Guid PlayerID { get; set; }
        public Guid PCQuestStatusID { get; set; }
        public string Resref { get; set; }
        public int Remaining { get; set; }
        public bool MustBeCraftedByPlayer { get; set; }

        public PCQuestStatus PCQuestStatus { get; set; }
        public Player Player { get; set; }
    }
}
