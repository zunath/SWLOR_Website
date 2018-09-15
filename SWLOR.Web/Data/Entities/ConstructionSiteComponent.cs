namespace SWLOR.Web.Data.Entities
{
    public class ConstructionSiteComponent
    {
        public int ConstructionSiteComponentID { get; set; }
        public int ConstructionSiteID { get; set; }
        public int Quantity { get; set; }
        public int StructureComponentID { get; set; }

        public ConstructionSite ConstructionSite { get; set; }
        public StructureComponent StructureComponent { get; set; }
    }
}
