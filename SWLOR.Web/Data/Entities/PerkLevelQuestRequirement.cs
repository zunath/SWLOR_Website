namespace SWLOR.Web.Data.Entities
{
    public partial class PerkLevelQuestRequirement
    {
        public int ID { get; set; }
        public int PerkLevelID { get; set; }
        public int RequiredQuestID { get; set; }

        public virtual PerkLevel PerkLevel { get; set; }
        public virtual Quest RequiredQuest { get; set; }
    }
}