namespace SWLOR.Web.Data.Entities
{
    public partial class PCTerritoryFlagsPermissions
    {
        public int PcterritoryFlagPermissionId { get; set; }
        public int PcterritoryFlagId { get; set; }
        public string PlayerId { get; set; }
        public int TerritoryFlagPermissionId { get; set; }

        public PCTerritoryFlags PcTerritoryFlag { get; set; }
        public PlayerCharacters Player { get; set; }
        public TerritoryFlagPermissions TerritoryFlagPermission { get; set; }
    }
}
