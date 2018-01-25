namespace SWLOR.Web.Data.Entities
{
    public partial class CraftBlueprintComponents
    {
        public long CraftComponentId { get; set; }
        public long CraftBlueprintId { get; set; }
        public string ItemResref { get; set; }
        public int Quantity { get; set; }

        public CraftBlueprints CraftBlueprint { get; set; }
    }
}
