namespace SWLOR.Web.Data.Entities
{
    public class CraftBlueprintComponent
    {
        public long CraftComponentID { get; set; }
        public long CraftBlueprintID { get; set; }
        public string ItemResref { get; set; }
        public int Quantity { get; set; }

        public CraftBlueprint CraftBlueprint { get; set; }
    }
}
