namespace SWLOR.Web.Data.Entities
{
    public class StructureCategory
    {
        public int StructureCategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public bool IsTerritoryFlagCategory { get; set; }
    }
}
