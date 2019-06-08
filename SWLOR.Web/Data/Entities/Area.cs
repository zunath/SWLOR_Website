using System;
using System.Collections.Generic;

namespace SWLOR.Web.Data.Entities
{
    public partial class Area
    {
        public Area()
        {
            AreaWalkmesh = new HashSet<AreaWalkmesh>();
            PCBase = new HashSet<PCBase>();
        }

        public Guid ID { get; set; }
        public string Resref { get; set; }
        public string Name { get; set; }
        public string Tag { get; set; }
        public int ResourceSpawnTableID { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool IsBuildable { get; set; }
        public Guid? NorthwestOwner { get; set; }
        public Guid? NortheastOwner { get; set; }
        public Guid? SouthwestOwner { get; set; }
        public Guid? SoutheastOwner { get; set; }
        public bool IsActive { get; set; }
        public int PurchasePrice { get; set; }
        public int DailyUpkeep { get; set; }
        public string Walkmesh { get; set; }
        public DateTime DateLastBaked { get; set; }
        public bool AutoSpawnResources { get; set; }
        public int ResourceQuality { get; set; }
        public int? NorthwestLootTableID { get; set; }
        public int? NortheastLootTableID { get; set; }
        public int? SouthwestLootTableID { get; set; }
        public int? SoutheastLootTableID { get; set; }
        public int MaxResourceQuality { get; set; }
        public int ClusterID { get; set; }

        public virtual LootTable NortheastLootTable { get; set; }
        public virtual Player NortheastOwnerNavigation { get; set; }
        public virtual LootTable NorthwestLootTable { get; set; }
        public virtual Player NorthwestOwnerNavigation { get; set; }
        public virtual Spawn ResourceSpawnTable { get; set; }
        public virtual LootTable SoutheastLootTable { get; set; }
        public virtual Player SoutheastOwnerNavigation { get; set; }
        public virtual LootTable SouthwestLootTable { get; set; }
        public virtual Player SouthwestOwnerNavigation { get; set; }
        public virtual ICollection<AreaWalkmesh> AreaWalkmesh { get; set; }
        public virtual ICollection<PCBase> PCBase { get; set; }
    }
}