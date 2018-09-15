namespace SWLOR.Web.Data.Entities
{
    public class StructureComponent
    {
        public int StructureComponentID { get; set; }
        public int StructureBlueprintID { get; set; }
        public string Resref { get; set; }
        public int Quantity { get; set; }

        public StructureBlueprint StructureBlueprint { get; set; }
    }
}
