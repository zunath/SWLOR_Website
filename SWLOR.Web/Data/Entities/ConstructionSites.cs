namespace SWLOR.Web.Data.Entities
{
    public partial class ConstructionSites
    {
        public int ConstructionSiteId { get; set; }
        public int? PcterritoryFlagId { get; set; }
        public string PlayerId { get; set; }
        public int StructureBlueprintId { get; set; }
        public int WoodRequired { get; set; }
        public int MetalRequired { get; set; }
        public int NailsRequired { get; set; }
        public int ClothRequired { get; set; }
        public int LeatherRequired { get; set; }
        public string LocationAreaTag { get; set; }
        public double LocationX { get; set; }
        public double LocationY { get; set; }
        public double LocationZ { get; set; }
        public double LocationOrientation { get; set; }
        public int IronRequired { get; set; }

        public PCTerritoryFlags PcTerritoryFlag { get; set; }
        public PlayerCharacters Player { get; set; }
        public StructureBlueprints StructureBlueprint { get; set; }
    }
}
