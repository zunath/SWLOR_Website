using System;

namespace SWLOR.Web.Data.Entities
{
    public partial class PCKeyItems
    {
        public int PckeyItemId { get; set; }
        public string PlayerId { get; set; }
        public int KeyItemId { get; set; }
        public DateTime AcquiredDate { get; set; }

        public KeyItems KeyItem { get; set; }
        public PlayerCharacters Player { get; set; }
    }
}
