using System;
using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class Area
    {
        public Area()
        {
            AreaWalkmesh = new HashSet<AreaWalkmesh>();
            PCBases = new HashSet<PCBase>();
        }

        public string AreaID { get; set; }
        public string Resref { get; set; }
        public string Name { get; set; }
        public string Tag { get; set; }
        public int ResourceSpawnTableID { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool IsBuildable { get; set; }
        public string NorthwestOwner { get; set; }
        public string NortheastOwner { get; set; }
        public string SouthwestOwner { get; set; }
        public string SoutheastOwner { get; set; }
        public bool IsActive { get; set; }
        public int PurchasePrice { get; set; }
        public int DailyUpkeep { get; set; }
        public string Walkmesh { get; set; }
        public DateTime DateLastBaked { get; set; }

        public PlayerCharacter NortheastOwnerNavigation { get; set; }
        public PlayerCharacter NorthwestOwnerNavigation { get; set; }
        public Spawn ResourceSpawnTable { get; set; }
        public PlayerCharacter SoutheastOwnerNavigation { get; set; }
        public PlayerCharacter SouthwestOwnerNavigation { get; set; }
        public ICollection<AreaWalkmesh> AreaWalkmesh { get; set; }
        public ICollection<PCBase> PCBases { get; set; }
    }
}
