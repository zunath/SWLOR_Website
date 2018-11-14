namespace SWLOR.Web.Data.Entities
{
    public partial class PerkLevelQuestRequirement
    {
        public int ID { get; set; }
        public int PerkLevelID { get; set; }
        public int RequiredQuestID { get; set; }

        public PerkLevel PerkLevel { get; set; }
        public Quest RequiredQuest { get; set; }
    }
}
