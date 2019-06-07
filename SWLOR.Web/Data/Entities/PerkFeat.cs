namespace SWLOR.Web.Data.Entities
{
    public partial class PerkFeat
    {
        public int ID { get; set; }
        public int PerkID { get; set; }
        public int FeatID { get; set; }
        public int PerkLevelUnlocked { get; set; }
        public int BaseFPCost { get; set; }
        public int ConcentrationFPCost { get; set; }
        public int ConcentrationTickInterval { get; set; }

        public virtual Perk Perk { get; set; }
    }
}