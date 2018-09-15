namespace SWLOR.Web.Data.Entities
{
    public class PCTerritoryFlagsPermission
    {
        public int PCTerritoryFlagPermissionID { get; set; }
        public int PCTerritoryFlagID { get; set; }
        public string PlayerID { get; set; }
        public int TerritoryFlagPermissionID { get; set; }

        public PCTerritoryFlag PCTerritoryFlag { get; set; }
        public PlayerCharacter Player { get; set; }
        public TerritoryFlagPermission TerritoryFlagPermission { get; set; }
    }
}
