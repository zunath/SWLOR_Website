namespace SWLOR.Web.Data.Entities
{
    public partial class PCEquippedAbilities
    {
        public string PlayerId { get; set; }
        public int? Slot1 { get; set; }
        public int? Slot2 { get; set; }
        public int? Slot3 { get; set; }
        public int? Slot4 { get; set; }
        public int? Slot5 { get; set; }
        public int? Slot6 { get; set; }
        public int? Slot7 { get; set; }
        public int? Slot8 { get; set; }
        public int? Slot9 { get; set; }
        public int? Slot10 { get; set; }

        public PlayerCharacters Player { get; set; }
        public Abilities Slot10Navigation { get; set; }
        public Abilities Slot1Navigation { get; set; }
        public Abilities Slot2Navigation { get; set; }
        public Abilities Slot3Navigation { get; set; }
        public Abilities Slot4Navigation { get; set; }
        public Abilities Slot5Navigation { get; set; }
        public Abilities Slot6Navigation { get; set; }
        public Abilities Slot7Navigation { get; set; }
        public Abilities Slot8Navigation { get; set; }
        public Abilities Slot9Navigation { get; set; }
    }
}
