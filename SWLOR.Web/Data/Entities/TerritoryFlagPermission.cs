namespace SWLOR.Web.Data.Entities
{
    public class TerritoryFlagPermission
    {
        public int TerritoryFlagPermissionID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public bool IsSelectable { get; set; }
    }
}
