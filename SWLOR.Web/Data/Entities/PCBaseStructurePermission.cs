using System;

namespace SWLOR.Web.Data.Entities
{
    public partial class PCBaseStructurePermission
    {
        public Guid ID { get; set; }
        public Guid PCBaseStructureID { get; set; }
        public Guid PlayerID { get; set; }
        public bool CanPlaceEditStructures { get; set; }
        public bool CanAccessStructureInventory { get; set; }
        public bool CanEnterBuilding { get; set; }
        public bool CanRetrieveStructures { get; set; }
        public bool CanAdjustPermissions { get; set; }
        public bool CanRenameStructures { get; set; }
        public bool CanEditPrimaryResidence { get; set; }
        public bool CanRemovePrimaryResidence { get; set; }
        public bool CanChangeStructureMode { get; set; }
        public bool IsPublicPermission { get; set; }
        public bool CanAdjustPublicPermissions { get; set; }
        public bool CanFlyStarship { get; set; }
        public int ClusterID { get; set; }

        public virtual PCBaseStructure PCBaseStructure { get; set; }
        public virtual Player Player { get; set; }
    }
}