using System;

namespace SWLOR.Web.Data.Entities
{
    public partial class ActivePlayers
    {
        public int ActivePlayerId { get; set; }
        public string AccountName { get; set; }
        public string CharacterName { get; set; }
        public int ExpPercentage { get; set; }
        public int LevelPercentage { get; set; }
        public int Level { get; set; }
        public string AreaName { get; set; }
        public DateTime CreateDate { get; set; }
        public string Description { get; set; }
    }
}
